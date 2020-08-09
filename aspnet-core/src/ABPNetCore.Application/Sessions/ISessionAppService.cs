using System.Threading.Tasks;
using Abp.Application.Services;
using ABPNetCore.Sessions.Dto;

namespace ABPNetCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
