using System.ComponentModel.DataAnnotations;

namespace TattooShopLD2.Models
{
    public class UzsakytasDarbasModel
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime pk_UzsakymoData { get; set; }
        public string fk_UzsakymasTelNr { get; set; }
    }
}
