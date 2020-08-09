using System.ComponentModel.DataAnnotations;

namespace ABPNetCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}