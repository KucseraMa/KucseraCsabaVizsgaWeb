namespace KucseraCsabaVizsgaWeb
{
    public partial class Munka
    {
        public override string ToString()
        {
            return $"Sorsz: {Id} Tipus: {Tipus} Munkatárs: {Munkatars} Állapot: {Allapot} Javítás dátum: {Idotartam} Hiba Id {BejelentoId}";
        }
    }
}
