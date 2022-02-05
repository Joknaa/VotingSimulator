namespace VotingSimulation;

internal static class MainClass {
    private const string COUNTRY_NAME = "India";
    private const int MINIMAL_AGE = 18;

    public static void Main(string[ ] args) {
        Display("Hello and welcome to this vote simulation !");
        Display("Please enter your country name: ");
        string? countryName = Console.ReadLine();

        if (!COUNTRY_NAME.Equals(countryName)) {
            Display("You are NOT Indian !");
            return;
        }
        
        Display("You are Indian !");
        CheckAge();
    }

    private static void CheckAge() {
        Display("Please enter your age: ");
        int? age = int.Parse(Console.ReadLine() ?? string.Empty);

        if (age < MINIMAL_AGE) {
            Display("You are NOT eligible for voting (Your age is " + age + ")");
            return;
        }

        Display("You are eligible for voting (Your age is " + age + ")");
        CheckCountryName();
    }

    private static void CheckCountryName() {
        Display("Please enter your country name: ");
        string? countryName = Console.ReadLine();

        if (COUNTRY_NAME.Equals(countryName)) {
            Display("You are Indian ! your country name is " + countryName);
        }
        else {
            Display("You are NOT Indian ! your country name is " + countryName);
        }
    }


    private static void Display(string message) {
        Console.WriteLine(message);
    }
}