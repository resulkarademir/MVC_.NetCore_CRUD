using System.ComponentModel.DataAnnotations;

namespace Uygulama1.Models
{
    public class Personeller
    {
        [Key]
        public int PersonelId { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelSehir { get; set; }

        public int BirimId { get; set; }
        public Birimler Birim { get; set; }

    }
}
