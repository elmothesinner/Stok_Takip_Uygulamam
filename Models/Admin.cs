using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Admin
    {
        [Required(ErrorMessage = "adminİsim Gerekli is required.")]
        public String? adminİsim { get; set; } = String.Empty;
        [Required(ErrorMessage = "Email Gerekli is required.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "adminPass is required.")]
        public int adminPass { get; set; }
        public String? adminTamAd => $"{adminİsim}";
        public DateTime adminKayıtAnı { get; set; }

        public Admin()
        {
            adminKayıtAnı = DateTime.Now;
            ApplicationsList=new List<Admin>();
        }
        public static IEnumerable<Admin> ApplicationsList{get; set;}

    }
}