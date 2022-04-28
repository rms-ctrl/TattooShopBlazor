namespace TattooShopLD2.Models
{
    public class TattooMeistrasModel
    {
        public string pk_TelNr { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public double PatirtiesMetai { get; set; }
        public string ElPastas { get; set; }
        public string TattooStilius { get; set; }
        public int fk_TattooStudijaId { get; set; }
    }
}
