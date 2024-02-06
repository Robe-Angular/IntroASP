using System.ComponentModel.DataAnnotations;
namespace IntroASP.Models.ViewModels
{
    public class BrandViewModel
    {
        [Required]
        public string Name { get; set; }

    }
}