using System.ComponentModel.DataAnnotations;

namespace Uygulama1.Models
{
    public class Birimler
    {
        [Key]
        public int BirimId { get; set; }
        public string BirimAd { get; set; }

        public IList<Personeller> Personellers { get; set; }
    }
}
