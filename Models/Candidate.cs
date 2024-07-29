using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        //[Required(ErrorMessage = "Ürün Adı is required.")]
        public String? ÜrünAd { get; set; } = String.Empty;
        //[Required(ErrorMessage = "ÜrünKat (sayı girmeyiniz)is required.")]
        public String? ÜrünKat { get; set; } = String.Empty;
        //[Required(ErrorMessage = "Ürün Kayıt Eden Personel is required.")]
        public String? ÜrünKayit { get; set; } = String.Empty;
        public String? Ürünnet => $"{ÜrünAd} {ÜrünKat?.ToUpper()}";
        //[Required(ErrorMessage = "Ürün Fiyat is required.")]
        public int? Ürünfiat { get; set; }
        //[Required(ErrorMessage = "Stok adeti girin is required.")]
        public int? Stokdurum { get; set; }
        public int? SeriNo { get; set; }
        public String? YeniKategori { get; set; } = String.Empty;
        public String? DepoLokasyon { get; set; } = String.Empty;

        public String? Depo { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public int? Depodaürünce { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
    
}//ürün sayfası olucak neler gelerli
/* ürün kayıt
ürün kategori
ürün fiyat
giriş tarihi
depo
ürün sayısı
seri no
ürünü kayıt eden kişi
*/
/* admin kullanıcı
admin urun giriş veya cıkarmaya ulaşamaz
ürünlerin cıkarıldıgı tarih
*/
/**/