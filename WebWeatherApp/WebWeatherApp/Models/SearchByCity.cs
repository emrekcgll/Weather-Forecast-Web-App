using System.ComponentModel.DataAnnotations;

namespace WebWeatherApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "Lütfen şehir ismini yazınız!")]
        [Display(Name = "Şehir Adı")]

        public string CityName { get; set; }
    }
}
