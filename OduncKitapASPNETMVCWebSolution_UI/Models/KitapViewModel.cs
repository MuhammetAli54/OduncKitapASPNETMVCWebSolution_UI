using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OduncKitapASPNETMVCWebSolution_UI.Models
{
    public class KitapViewModel
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; }

        [Required(ErrorMessage ="Kitap adı girişi gereklidir")]
        [StringLength(maximumLength:50,ErrorMessage ="Kitap adı en az 1 en fazla 50 karakter olmalıdır.")]
        public string KitapAdi { get; set; }
        public byte TurId { get; set; }
        public int YazarId { get; set; }

        [Required(ErrorMessage = "Sayfa sayısı gereklidir")]
        public int SayfaSayisi { get; set; }

        [Required(ErrorMessage = "Stok adeti gereklidir")]
        public int StokAdeti { get; set; }
        public bool SilindiMi { get; set; }
        public string ResimLink { get; set; }
        public HttpPostedFileBase Resim { get; set; }
    }
}