using System.ComponentModel.DataAnnotations;

namespace TattooShopLD2.Models
{
    public class SaskaitaModel
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Data { get; set; }
        public double Kaina { get; set; }
        public double Arbatpinigiai { get; set; }
        public int pk_SaskaitaId { get; set; }
        public string fk_UzsakymasTelNr { get; set; }
    }
}
