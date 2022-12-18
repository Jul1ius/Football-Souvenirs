using System;

namespace Football_Souvenirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string club = Console.ReadLine();
            string typeSouvenirs = Console.ReadLine();
            int buyedSouvenirs = int.Parse(Console.ReadLine());
            double total = 0;

            if (club == "Argentina")
            {
                switch (typeSouvenirs)
                {
                    case "flags":
                        total = buyedSouvenirs * 3.25; break;
                    case "caps":
                        total = buyedSouvenirs * 7.20; break;
                    case "posters":
                        total = buyedSouvenirs * 5.10; break;
                    case "stickers":
                        total = buyedSouvenirs * 1.25; break;
                }
            }
            else if (club == "Brazil")
            {
                switch (typeSouvenirs)
                {
                    case "flags":
                        total = buyedSouvenirs * 4.20; break;
                    case "caps":
                        total = buyedSouvenirs * 8.50; break;
                    case "posters":
                        total = buyedSouvenirs * 5.35; break;
                    case "stickers":
                        total = buyedSouvenirs * 1.20; break;
                }
            }
            else if (club == "Croatia")
            {
                switch (typeSouvenirs)
                {
                    case "flags":
                        total = buyedSouvenirs * 2.75; break;
                    case "caps":
                        total = buyedSouvenirs * 6.90; break;
                    case "posters":
                        total = buyedSouvenirs * 4.95; break;
                    case "stickers":
                        total = buyedSouvenirs * 1.10; break;
                }
            }
            else if (club == "Denmark")
            {
                switch (typeSouvenirs)
                {
                    case "flags":
                        total = buyedSouvenirs * 3.10; break;
                    case "caps":
                        total = buyedSouvenirs * 6.50; break;
                    case "posters":
                        total = buyedSouvenirs * 4.80; break;
                    case "stickers":
                        total = buyedSouvenirs * 0.90; break;
                }
            }

            if ((club == "Argentina" || club == "Brazil" || club == "Croatia" || club == "Denmark") && (typeSouvenirs == "flags" || typeSouvenirs == "caps" || typeSouvenirs == "posters" || typeSouvenirs == "stickers"))
            {
                Console.WriteLine($"Pepi bought {buyedSouvenirs} {typeSouvenirs} of {club} for {total:f2} lv.");
            }
            else if ((club != "Argentina" || club != "Brazil" || club != "Croatia" || club != "Denmark") && (typeSouvenirs == "flags" || typeSouvenirs == "caps" || typeSouvenirs == "posters" || typeSouvenirs == "stickers"))
            {
                Console.WriteLine("Invalid country!");
            }
            else if ((club == "Argentina" || club == "Brazil" || club == "Croatia" || club == "Denmark") && (typeSouvenirs != "flags" || typeSouvenirs != "caps" || typeSouvenirs != "posters" || typeSouvenirs != "stickers"))
            {
                Console.WriteLine("Invalid stock!");
            }
            
        }
    }
}
