using System.ComponentModel.DataAnnotations;

namespace Phoenix.Data.Models
{
    public class City
    {
        [Display(Name = "Город:")]
        public string Name { get; set; }


        [Display(Name = "Температура:")]
        public float Temp { get; set; }


        [Display(Name = "Влажность")]
        public int Humidity { get; set; }


        [Display(Name = "Давление:")]
        public int Pressure { get; set; }


        [Display(Name = "Скорость ветра:")]
        public float Wind { get; set; }


        [Display(Name = "Погодные условия:")]
        public string Weather { get; set; }
    }
}
