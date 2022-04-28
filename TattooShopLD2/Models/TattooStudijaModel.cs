namespace TattooShopLD2.Models
{
    public class TattooStudijaModel
    {
        public string Pavadinimas { get; set; }
        public string Adresas { get; set; }
        public string TelNr { get; set; }
        public string ElPastas { get; set; }
        public int VietuSk { get; set; }
        public int pk_TattooStudijaId { get; set; }
        public int fk_MiestasId { get; set; }
    }
}
