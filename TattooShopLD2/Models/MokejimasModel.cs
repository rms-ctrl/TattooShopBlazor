using System.ComponentModel.DataAnnotations;

namespace TattooShopLD2.Models
{
    public class MokejimasModel
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Data { get; set; }      
        public double Suma { get; set; }
        public int pk_MokejimasId { get; set; }
        public int fk_SaskaitaId { get; set; }
        public string fk_KlientasTelNr { get; set; }
    }
}
