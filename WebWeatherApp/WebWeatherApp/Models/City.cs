using System.ComponentModel.DataAnnotations;

namespace WebWeatherApp.Models
{
    public class City
    {
        [Display(Name = "Şehir Adı:")]
        public string Name { get; set; }
        [Display(Name = "Hava Sıcaklığı:")]
        public float Temperature { get; set; }
        [Display(Name = "Nem:")]
        public int Humidity { get; set; }
        [Display(Name = "Basınç:")]
        public int Pressure { get; set; }
        [Display(Name = "Rüzgar Hızı:")]
        public float Wind { get; set; }
        [Display(Name = "Hava Durumu:")]
        public string Weather { get; set; }
    }
}
