using System.ComponentModel.DataAnnotations;

namespace Dws.Note_One.Api.Resources
{
    public class SaveUserResouce
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
    }
}