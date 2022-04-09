using System;

namespace AcronymGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (Generation());
        }

        public static bool Generation()
        { 
            Console.WriteLine("AGM - Acronym Generation Machine");
            Console.WriteLine("Please enter a 3 character Acronym to generate its meaning.");
            string acronym = Console.ReadLine().ToUpper();

            var first = acronym[0].ToString();
            var second = acronym[1].ToString();
            var third = acronym[2].ToString();

            switch (first)
            {
                case "A":
                    first = "American";
                    break;
                case "B":
                    first = "Broadband";
                    break;
                case "C":
                    first = "Common";
                    break;
                case "D":
                    first = "Domain";
                    break;
                case "E":
                    first = "Energy";
                    break;
                case "F":
                    first = "First";
                    break;
                case "G":
                    first = "Global";
                    break;
                case "H":
                    first = "Historic";
                    break;
                case "I":
                    first = "International";
                    break;
                case "J":
                    first = "Javascript";
                    break;
                case "K":
                    first = "Key";
                    break;
                case "L":
                    first = "Latency";
                    break;
                case "M":
                    first = "Modern";
                    break;
                case "N":
                    first = "Neo";
                    break;
                case "O":
                    first = "Objective";
                    break;
                case "P":
                    first = "Program";
                    break;
                case "Q":
                    first = "Quick";
                    break;
                case "R":
                    first = "Reactive";
                    break;
                case "S":
                    first = "Scientific";
                    break;
                case "T":
                    first = "Transport";
                    break;
                case "U":
                    first = "Universal";
                    break;
                case "V":
                    first = "Vector";
                    break;
                case "W":
                    first = "Windows";
                    break;
                case "X":
                    first = "Cross-";
                    break;
                case "Y":
                    first = "Yearly";
                    break;
                case "Z":
                    first = "Zen";
                    break;
                default:
                    break;
            }
            switch(second)
            {
                case "A":
                    second = "Advanced";
                    break;
                case "B":
                    second = "Biological";
                    break;
                case "C":
                    second = "Cryptographic";
                    break;
                case "D":
                    second = "Data";
                    break;
                case "E":
                    second = "Emergency";
                    break;
                case "F":
                    second = "Fusion";
                    break;
                case "G":
                    second = "Gated";
                    break;
                case "H":
                    second = "Holistic";
                    break;
                case "I":
                    second = "Interface";
                    break;
                case "J":
                    second = "Jaunty";
                    break;
                case "K":
                    second = "Kaleidoscopic";
                    break;
                case "L":
                    second = "Legendary";
                    break;
                case "M":
                    second = "Modern";
                    break;
                case "N":
                    second = "Nasty";
                    break;
                case "O":
                    second = "Official";
                    break;
                case "P":
                    second = "Progressive";
                    break;
                case "Q":
                    second = "Qualified";
                    break;
                case "R":
                    second = "Recursive";
                    break;
                case "S":
                    second = "Seasonal";
                    break;
                case "T":
                    second = "Telecommunication";
                    break;
                case "U":
                    second = "United";
                    break;
                case "V":
                    second = "Voice-Activated";
                    break;
                case "W":
                    second = "Web";
                    break;
                case "X":
                    second = "Xenon";
                    break;
                case "Y":
                    second = "Yamoto";
                    break;
                case "Z":
                    second = "Zed";
                    break;
                default:
                    break;
            }

            switch(third)
            {
                case "A":
                    third = "Automation";
                    break;
                case "B":
                    third = "Blockchain";
                    break;
                case "C":
                    third = "Community";
                    break;
                case "D":
                    third = "Delivery";
                    break;
                case "E":
                    third = "Engine";
                    break;
                case "F":
                    third = "Fungible";
                    break;
                case "G":
                    third = "Geolocator";
                    break;
                case "H":
                    third = "Hashing";
                    break;
                case "I":
                    third = "Innovations";
                    break;
                case "J":
                    third = "Juice";
                    break;
                case "K":
                    third = "Keyboard";
                    break;
                case "L":
                    third = "Legion";
                    break;
                case "M":
                    third = "Management";
                    break;
                case "N":
                    third = "Network";
                    break;
                case "O":
                    third = "Operations";
                    break;
                case "P":
                    third = "Plug-in";
                    break;
                case "Q":
                    third = "Queue";
                    break;
                case "R":
                    third = "Registry";
                    break;
                case "S":
                    third = "Systems";
                    break;
                case "T":
                    third = "Technologies";
                    break;
                case "U":
                    third = "Union";
                    break;
                case "V":
                    third = "Vector";
                    break;
                case "W":
                    third = "Web";
                    break;
                case "X":
                    third = "Xenic";
                    break;
                case "Y":
                    third = "Yottabyte";
                    break;
                case "Z":
                    third = "Type-Z";
                    break;
                default:
                    break;
            }

            var final = first + " " + second+ " " + third;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + acronym + ": " + final + "\n");
            Console.ForegroundColor = ConsoleColor.White;

            return true;
        }
    }
}
