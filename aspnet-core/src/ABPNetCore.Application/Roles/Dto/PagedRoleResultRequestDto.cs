using Abp.Application.Services.Dto;

namespace ABPNetCore.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

