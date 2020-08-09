using System.Threading.Tasks;
using Abp.Application.Services;
using ABPNetCore.Authorization.Accounts.Dto;

namespace ABPNetCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
