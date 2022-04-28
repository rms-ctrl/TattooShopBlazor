using System.ComponentModel.DataAnnotations;

namespace TattooShopLD2.Models
{
    public class KlientasModel
    {
        public string pk_TelNr { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string GimimoData { get; set; }
        public string ElPastas { get; set; }
        public int Alergijos { get; set; }
    }
}
