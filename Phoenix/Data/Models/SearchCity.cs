using System.ComponentModel.DataAnnotations;

namespace Phoenix.Data.Models
{
    public class SearchCity
    {
        [Required(ErrorMessage = "Ввести название города обязательно!")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Only text allowed")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "От 2 до 20 символов!")]
        [Display(Name = "Название города")]
        public string CityName { get; set; }
    }
}
