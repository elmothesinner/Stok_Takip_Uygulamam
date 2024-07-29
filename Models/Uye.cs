using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Uye
    {
        [Required(ErrorMessage = "adminİsim Gerekli is required.")]
        public  String? Uname { get; set; } = String.Empty;
        [Required(ErrorMessage = "Email Gerekli is required.")]
        public  String? UMail { get; set; } = String.Empty;
        [Required(ErrorMessage = "adminPass is required.")]
        public int? UPass { get; set; }
        public  String? UFullName => $"{Uname}";
        public  DateTime UKayıtAnı { get; set; }

        public Uye()
        {
            UKayıtAnı = DateTime.Now;
            ApplicationsList=new List<Uye>();
        }
        public static IEnumerable<Uye> ApplicationsList{get; set;}

    }
}