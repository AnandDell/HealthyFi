using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyJobAssistent
{
    public interface IApiService
    {
        Task<List<AppHealthConfig>> GetHealthStatusList();
    }
}