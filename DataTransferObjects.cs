using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeknikServis.UI.Models
{
    public class AdresDetayDTO
    {
        
        public string Adi { get; set; }
        public string MahalleCadde { get; set; }
        public string Sokak { get; set; }
        public string Apartman { get; set; }
        public Nullable<byte> KapiNo { get; set; }
        public Nullable<byte> DaireNo { get; set; }
        public string Semt { get; set; }
        public string İlce { get; set; }
        public string İl { get; set; }
    }

    public class DetayDTO
    {
        [Required(ErrorMessage = "Servis Yeri Boş Geçilemez")]
        public int ServisyeriId { get; set; }
        [Required(ErrorMessage = "Arıza Türü Boş Geçilemez")]
        public int ArizaId { get; set; }
        [Required(ErrorMessage = "Servis Durumu Boş Geçilemez")]
        public int ServisDurumId { get; set; }
        [Required(ErrorMessage = "Teslim Alanı Boş Geçilemez")]
        public int UrunTeslimId { get; set; }
        public int UrunId { get; set; }
    }


    public class MusteriDTO
    {
        
        [Required(ErrorMessage = "Ad Boş Geçilemez")]
        public string Adi { get; set; }
        [Required(ErrorMessage = "Soyad Boş Geçilemez")]
        public string Soyadi { get; set; }

        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Geçerli bir e-posta giriniz.")]
        public string Email { get; set; }
        [MinLength(10, ErrorMessage = "En az 10 karakter girilmesi gerekmektedir.")]
        public string Telefon { get; set; }
    }
    public class PersonelDTO
    {
        
        [Required(ErrorMessage ="Ad Boş Geçilemez.")]
        public string Ad { get; set; }
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Geçerli bir e-posta giriniz.")]
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<System.DateTime> IseGirisTarihi { get; set; }
        [EmailAddress(ErrorMessage = "Email formatında giriş yapınız.")]
        public string Email { get; set; }
        [StringLength(10, ErrorMessage = "10 karakterden uzun olamaz.")]
        public string Telefon { get; set; }
    }
  
    public class UrunDTO
    {
        
        [Required(ErrorMessage ="İşlem numarası girişi yapınız")]
        public Nullable<int> IslemNo { get; set; }
        public Nullable<int> MarkaId { get; set; }
        public Nullable<int> ModelId { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<bool> Garantilimi { get; set; }
    }
    public class UrunTeslimDTO
    {
        
        public Nullable<int> TeslimEdenPersonelId { get; set; }
        public Nullable<decimal> ServisBedeli { get; set; }
        public Nullable<decimal> TeslimBedeli { get; set; }
        public Nullable<int> UrunId { get; set; }
        public Nullable<int> MusteriId { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
    }

}