using System;

namespace voetbalclub.models
{
    public class TennisclubModel
    {
        public string Naam { get; set; }
        public int AantalVelden { get; set; }
        public int AantalLeden { get; set; }
        public int VeldType { get; set; }
        public int AantalTennisrackets { get; set; }

        public TennisclubModel()
        {
            
        }

        public TennisclubModel(string naam, int aantalVelden, int aantalLeden, int veldType, int aantalTennisrackets)
        {
            Naam = naam;
            AantalVelden = aantalVelden;
            AantalLeden = aantalLeden;
            VeldType = veldType;
            AantalTennisrackets = aantalTennisrackets;
        }

        public virtual int BerekenLidgeld(int kosten)
        {
            return (int)(kosten/AantalLeden) + 21;
        }
    }
}
