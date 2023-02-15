// lange versie (makkelijk):

namespace CSharp {
    class Program {
        public static void Main(string[] args) {
            Console.Write("What is your first name: ");
            string? firstName = Console.ReadLine();
            Console.Write("What is your last name: ");
            string? lastName = Console.ReadLine();
            Console.Write("In what year you born: ");
            string? year = Console.ReadLine();
            Console.Write("In what month you born: ");
            string? month = Console.ReadLine();
            Console.Write("In what day you born: ");
            string? day = Console.ReadLine();
            int? age = calculateAge(year, month, day);
            Console.WriteLine($"Your name is {firstName + " " + lastName} and you're {age} years old");

            static int calculateAge(string year, string month, string day) {
                DateTime start = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                DateTime end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                TimeSpan difference = end - start;
                return (int)(difference.TotalDays / 365.25);
            }
        }
    }
}

// Korte versie (moeilijk):

namespace CSharp {
    class Program {
        public static void Main(string[] args) {
            Console.Write("What is your first name: ");
            string? firstName = Console.ReadLine();
            Console.Write("What is your last name: ");
            string? lastName = Console.ReadLine();
            Console.Write("In what year you born (dd-mm-yyyy): ");
            string? date = Console.ReadLine();
            int? age = calculateAge(date);
            Console.WriteLine($"Your name is {firstName + " " + lastName} and you're {age} years old");

            static int calculateAge(string date) {
                var bornDate = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                var currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                var difference = currentDate - bornDate;
                return (int)(difference.TotalDays / 365.25);
            }
        }
    }
}

// Template voor leerlingen:

namespace CSharp {
    class Program {
        public static void Main(string[] args) {
            // Maak hier een formulier waarin je om de voornaam, achternaam en geboortedatum van de gebruiker vraagt.
            // Zoek op hoe je een regel print/leest in de console
            // Zoek op hoe je een string naar een integer kan converteren binnen C Sharp

            Console.WriteLine($"Your name is {firstName + " " + lastName} and you're {age} years old");

            // Maak de functie verder af:
            static int calculateAge(string year, string month, string day) {
                return (int)(difference.TotalDays / 365.25);
            }
        }
    }
}

// Handige informatiebronnen, maak er zeker gebruik van als je er echt niet uitkomt: 
// - https://stackoverflow.com/questions/10495802/how-to-get-the-total-number-of-days-in-a-year-from-the-given-date
// - https://www.w3resource.com/csharp-exercises/datetime/csharp-datetime-exercise-30.php


