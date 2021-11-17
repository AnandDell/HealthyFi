using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyJobAssistent
{
    public static class EmailHelper
    {
        static EmailHelper()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token1.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Gmail API Service.
            Service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

        }

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        static string[] Scopes = { GmailService.Scope.MailGoogleCom, GmailService.Scope.GmailModify };
        static string ApplicationName = "Gmail API .NET Quickstart";

        static string ToMailAddress = "hackathondell2021@gmail.com";
        static string[] FromAddresses = { "hackathondell2021@gmail.com",
            "Prabal_Khajanchi@Dell.com",
            "Pinkey_Ratnani@Dell.com",
            "Jitesh_Kumaradesara@Dell.com",
            "Sachin_Koshti@Dell.com",
            "Ajeya.Kumar@Dell.com",
            "Anand_Kumar_tripathi@Dell.com" };

        static string[] Subjects = { "restart the service",
            "re-initialize the service" };

        static string[] BodySubstrings = { "urgently required to restart service" };
        static GmailService Service;

        static string UrlHealthOfServer = "http://dellrestapi-env.eba-enmpcutb.us-east-2.elasticbeanstalk.com/health";
        static string UrlSetUnhealth = "http://dellrestapi-env.eba-enmpcutb.us-east-2.elasticbeanstalk.com/health/error%20heart%202";
        static string UrlSetHealty = "http://dellrestapi-env.eba-enmpcutb.us-east-2.elasticbeanstalk.com/health/healthy";

        public static async Task CheckForRestart(AppHealthActionConfig appHealthActionConfig)
        {
            //
            // Fetch all the mails from inbox
            //
            var inboxlistRequest = Service.Users.Messages.List("hackathondell2021@gmail.com");
            inboxlistRequest.Q = "is:unread";
            inboxlistRequest.LabelIds = "INBOX";
            inboxlistRequest.IncludeSpamTrash = false;
            var emailListResponse = inboxlistRequest.Execute();
            if (emailListResponse != null && emailListResponse.Messages != null)
            {
                // loop through each email
                foreach (var email in emailListResponse.Messages)
                {
                    //
                    // fetch email details
                    //
                    var emailInfoRequest = Service.Users.Messages.Get("hackathondell2021@gmail.com", email.Id);
                    var emailInfoResponse = emailInfoRequest.Execute();

                    if (emailInfoResponse != null)
                    {
                        //
                        // update email - mark as read
                        //
                        var modifyRequest = new ModifyMessageRequest() { RemoveLabelIds = new[] { "UNREAD" }, ETag = emailInfoResponse.ETag };
                        var modifyResponse = Service.Users.Messages.Modify(modifyRequest, "me", emailInfoResponse.Id).Execute();

                        //loop through the headers to get from, date, subject and body  
                        string from = "", date = "", subject = "", body = "";
                        bool breakLoop = false;
                        foreach (var mParts in emailInfoResponse.Payload.Headers)
                        {
                            if (mParts.Name == "Date")
                            {
                                date = mParts.Value;
                            }
                            else if (mParts.Name == "From")
                            {
                                from = mParts.Value;
                            }
                            else if (mParts.Name == "Subject")
                            {
                                subject = mParts.Value;
                            }

                            if (subject != "" && from != "")
                            {
                                if (emailInfoResponse.Payload.Parts != null)
                                {
                                    foreach (MessagePart p in emailInfoResponse.Payload.Parts)
                                    {
                                        if (p.MimeType == "text/html")
                                        {
                                            byte[] data = FromBase64ForUrlString(p.Body.Data);
                                            body = Encoding.UTF8.GetString(data);

                                            await CheckForTrigger(from, subject, body);
                                            breakLoop = true;
                                            break;
                                        }
                                    }
                                }
                                else if (emailInfoResponse.Payload.Body.Data != null)
                                {
                                    byte[] data = FromBase64ForUrlString(emailInfoResponse.Payload.Body.Data);
                                    body = Encoding.UTF8.GetString(data);

                                    await CheckForTrigger(from, subject, body);
                                    breakLoop = true;
                                    break;
                                }

                                if (breakLoop)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        public static byte[] FromBase64ForUrlString(string base64ForUrlInput)
        {
            int padChars = (base64ForUrlInput.Length % 4) == 0 ? 0 : (4 - (base64ForUrlInput.Length % 4));
            StringBuilder result = new StringBuilder(base64ForUrlInput, base64ForUrlInput.Length + padChars);
            result.Append(String.Empty.PadRight(padChars, '='));
            result.Replace('-', '+');
            result.Replace('_', '/');
            return Convert.FromBase64String(result.ToString());
        }

        public static async Task CheckForTrigger(string from, string subject, string body)
        {
            if (FromAddresses.Any(fromAdd => from.ToLower().Contains(fromAdd.ToLower()))
                && Subjects.Any(sub => subject.ToLower().Contains(sub.ToLower()))
                && BodySubstrings.Any(substring => body.ToLower().Contains(substring.ToLower())))
            {
                //
                // Can API to set reset
                //
                await CallAPI(UrlSetHealty);
            }
        }

        public static void SendMail()
        {
            string plainText = $"To: {ToMailAddress}\r\n" +
                               $"Subject: {Subjects[0]}\r\n" +
                               "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                               $"{BodySubstrings[0]}";

            var newMsg = new Google.Apis.Gmail.v1.Data.Message();
            newMsg.Raw = Base64UrlEncode(plainText.ToString());
            Service.Users.Messages.Send(newMsg, "me").Execute();
        }

        public static void SendMail(string to, string subject, string body)
        {
            string plainText = $"To: {to}\r\n" +
                               $"Subject: {subject}\r\n" +
                               "Content-Type: text/html; charset=us-ascii\r\n\r\n" +
                               $"{body}";

            var newMsg = new Google.Apis.Gmail.v1.Data.Message();
            newMsg.Raw = Base64UrlEncode(plainText.ToString());
            Service.Users.Messages.Send(newMsg, "me").Execute();
        }

        public static async Task CallAPI(string Url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var resulthealth = await client.GetAsync(Url);
            var content = resulthealth.Content.ReadAsStringAsync().Result;
        }


        public static void SendMail(List<AppHealthActionConfig> config)
        {
            if (!config.Any())
            {
                return;
            }

            StringBuilder _sb = new StringBuilder();

            _sb.Append($"<table>\n");
            _sb.Append("<tbody>");

            foreach(var item in config)
            {
                _sb.Append("\t<tr>\n");

                _sb.Append("\t\t<td>\n");
                _sb.Append("\t\t\t" + item.EndPoint + "\t\t\t");
                _sb.Append("\t\t</td>\n");

                _sb.Append("\t\t<td>\n");
                _sb.Append("\t\t\t" + item.ApiType + "\t\t\t");
                _sb.Append("\t\t</td>\n");

                _sb.Append("\t\t<td>\n");
                _sb.Append("\t\t\t" + (item.BackColor == Color.Red ? "   Error" : "   Success"));
                _sb.Append("\t\t</td>\n");

                _sb.Append("\t</tr>\n");
            }

            _sb.Append("</tbody>");
            _sb.Append("</table>");

            string body = _sb.ToString();

            SendMail("Anand_Kumar_tripathi@Dell.com;Prabal_Khajanchi@Dell.com;Ajeya.Kumar@Dell.com;Jitesh_Kumaradesara@Dell.com;Pinkey_Ratnani@Dell.com;Sachin_Koshti@Dell.com", "Endpoint status.", body);
        }


    } // email helper
}
