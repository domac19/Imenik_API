namespace Imenik_API.Model
{
    public class DodatnaAdresa
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public int KucniBroj { get; set; }
        public int Kontakt { get; set; }
        public string Email { get; set; }
        public int SifarnikZupanijaId { get; set; }
        public int SifarnikDrzavaId { get; set; }
        public int ImenikId { get; set; }
    }
}
