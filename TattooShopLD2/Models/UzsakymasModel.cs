using System.ComponentModel.DataAnnotations;

namespace TattooShopLD2.Models
{
    public class UzsakymasModel
    {
        public string pk_TelNr { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int ArSpalvota { get; set; }
        public double GalutineKaina { get; set; }
        public string TattooStilius { get; set; }
        public int Nuskausminamieji { get; set; }
        public string KunoVieta { get; set; }
        public string TattooDydis { get; set; }
        public string UzsakymoBusena { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string UzsakymoData { get; set; }
        public string fk_KlientasTelNr { get; set; }
        public string fk_TattooMeistrasTelNr { get; set; }
    }
}
