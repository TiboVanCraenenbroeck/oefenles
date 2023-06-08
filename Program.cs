// See https://aka.ms/new-console-template for more information

using voetbalclub.models;

List<VoetbalclubModel> voetbalclubs = new List<VoetbalclubModel>();
List<TennisclubModel> tennisclubs = new List<TennisclubModel>();


bool isDone = false;

while (!isDone)
{
    Console.WriteLine("Kies een actie (0 = voetbalclub toevoegen, 1 = tennisclub toevoegen, 2 = namen van voetbalclubs opvragen,3 = lidgeld berekenen, 4 = stoppen)");

    int keuzeGebruiker = Convert.ToInt16(Console.ReadLine());
    switch (keuzeGebruiker)
    {
        case 0:
            // Nieuw object aanmaken
            VoetbalclubModel voetbalclub = new VoetbalclubModel();

            // Object opvullen met waarden
            Console.WriteLine("Clubnaam: ");
            voetbalclub.Naam = Console.ReadLine();
            
            Console.WriteLine("Aantal velden: ");
            voetbalclub.AantalVelden = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Aantal leden: ");
            voetbalclub.AantalLeden = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Veldtype (0= kunstgras, 1 = gras): ");
            voetbalclub.VeldType = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Basisspelers: ");
            voetbalclub.BasisSpelers = new List<string>();

            for (int i = 0; i < 2; i++)
            {
                voetbalclub.BasisSpelers.Add(Console.ReadLine());
            }

            // Object toevoegen aan list
            voetbalclubs.Add(voetbalclub);

            break;
        case 1:
            // Object opvullen met waarden
            Console.WriteLine("Clubnaam: ");
            string clubnaam = Console.ReadLine();
            
            Console.WriteLine("Aantal velden: ");
            int aantalVelden = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Aantal leden: ");
            int aantalLeden = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Veldtype (0= gras, 1 = gravel): ");
            int veldType = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Aantal tennisrackets beschikbaar: ");
            int aantalTennisRackets = Convert.ToInt16(Console.ReadLine());

             // Nieuw object aanmaken
            TennisclubModel tennisclub = new TennisclubModel(clubnaam, aantalVelden, aantalLeden, veldType, aantalTennisRackets);

            // Tennisclub toevoegen aan list
            tennisclubs.Add(tennisclub);
            
            break;
        case 2:
            Console.WriteLine("Namen van voetbalclubs: ");
            foreach (VoetbalclubModel vc in voetbalclubs)
            {
                Console.WriteLine(vc.Naam);
            }
            break;
        case 3:
            Console.WriteLine("0 = Voetbalclub, 1 = Tennisclub");
            Console.WriteLine("Selecteer club:");

            int clubType = Convert.ToInt16(Console.ReadLine());

            if(clubType == 0)
            {
                for (int i = 0; i < voetbalclubs.Count; i++)
                {
                    Console.WriteLine($"{i}: {voetbalclubs[i].Naam}");
                }
            }
            else
            { 
                for (int i = 0; i < tennisclubs.Count; i++)
                {
                    Console.WriteLine($"{i}: {tennisclubs[i].Naam}");
                }
            }

            int keuzeClub = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Totale clubkosten: ");
            int totaleClubkosten = Convert.ToInt16(Console.ReadLine());

            int lidgeld;
            if (clubType == 0)
            {
                lidgeld = voetbalclubs[keuzeClub].BerekenLidgeld(totaleClubkosten);
            }
            else
            {
                lidgeld = tennisclubs[keuzeClub].BerekenLidgeld(totaleClubkosten);
            }

            Console.WriteLine($"Elk lid moet {lidgeld} euro betalen.");
            
            break;
        case 4:
            isDone = true;
            break;
        default: break;
    }
}