using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isim değeri giriniz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim değeri giriniz!")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen bir mail giriniz!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyet seçiniz")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Şifrele eşleşmiyor!")]
        public string ComfirmPassword { get; set; }
    }
}
