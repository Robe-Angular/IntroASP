using System.ComponentModel.DataAnnotations;

namespace IntroASP.Models.ViewModels
{
    public class BeerViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int BrandId { get; set; }
    }
}
