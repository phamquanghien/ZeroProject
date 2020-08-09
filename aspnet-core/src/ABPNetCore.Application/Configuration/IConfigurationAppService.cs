using System.Threading.Tasks;
using ABPNetCore.Configuration.Dto;

namespace ABPNetCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
