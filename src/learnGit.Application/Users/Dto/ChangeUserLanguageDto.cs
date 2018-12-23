using System.ComponentModel.DataAnnotations;

namespace learnGit.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}