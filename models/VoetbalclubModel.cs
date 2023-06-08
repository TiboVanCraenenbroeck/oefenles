using System;

namespace voetbalclub.models
{
    public class VoetbalclubModel
    {
        public string Naam { get; set; }
        public int AantalVelden { get; set; }
        public int AantalLeden { get; set; }
        public int VeldType { get; set; }
        public List<string> BasisSpelers { get; set; }

        public virtual int BerekenLidgeld(int kosten)
        {
            return (int)kosten/AantalLeden;
        }
    }
}
