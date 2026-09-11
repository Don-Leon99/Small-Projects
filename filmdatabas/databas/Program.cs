/*
Funktioner:
    Lägg till en film (Titel, Regissör, Betyg 1–5, Årtal).
    Visa alla filmer i en snygg lista eller tabell.
    Sök efter en film baserat på titel eller regissör.
    ----------------------------------------------------------------
    Bonus: Spara och läs in datan från en textfil (.txt eller .json)
    så att filmerna finns kvar nästa gång du startar programmet.
    Vad du tränar på: Filhantering (File.ReadAllText, File.WriteAllText),
    JSON-serialisering, klasser och söklogik.
*/

List<string> movies = new List<string>()
{
    "Inception",
    "The Matrix",
    "Interstellar",
    "Batman",
    "Gladiator"
};
List<string> transactions = new List<string>();

Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("Välkommen Filmbas!");
Console.WriteLine("Meny alternativ");
Console.WriteLine("För att avsluta programmet tryck på tangenten 'x'");
Console.WriteLine("För att sätta lägga till en film tryck på tangenent 'd'");
Console.WriteLine("För att ta ut en film tryck på tangenten 'w'");
Console.WriteLine("För att visa filmdatabasen tryck på tangenten 'b'");
Console.WriteLine("För att visa lånehistorik tryck på tangenten 't'");
Console.WriteLine("För att söka efter en film tryck på tangenten 's'");
Console.WriteLine("------------------------------------------------------------------");

bool isRunning = true;

try
{
    while (isRunning)
    {
        var key = Console.ReadLine()?.ToLower();

        switch (key)
        {
            case "x":
                Console.WriteLine("Programmet avslutas...");
                isRunning = false;
                break;

            case "d":
                Console.WriteLine("Vilken film vill du tillsätta?");
                var depositInput = Console.ReadLine();
                AddFilm(depositInput);
                break;

            case "w":
                Console.WriteLine("Vilken film vill du ta ut?");
                var withdrawInput = Console.ReadLine();
                RemoveFilm(withdrawInput);
                break;

            case "b":
                Console.WriteLine("Filmdatabas: ");
                DisplayList();
                break;

            case "t":
                Console.WriteLine("Lånehistorik: ");
                DisplayHistory();
                break;

            case "s":
                Console.WriteLine("Vilken film vill du söka efter?");
                var searchInput = Console.ReadLine();
                SearchFilm(searchInput);
            break;

            default:
                Console.WriteLine("Ogiltigt val, försök igen.");
                break;
        }
    }
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
    Environment.Exit(0);
}

finally
{
    Console.WriteLine("Klar!");
}


void AddFilm(string? depositInput)
{
    if (string.IsNullOrWhiteSpace(depositInput))
    {
        Console.WriteLine("Fel: Titeln kan inte vara tom!");
        return;
    }
    movies.Add(depositInput);
    transactions.Add($"Transaktionstyp: insättning: {depositInput}");
    Console.WriteLine($"{depositInput} är nu inlagd i databasen!");
}

void RemoveFilm(string? withdrawInput)
{
    if (string.IsNullOrWhiteSpace(withdrawInput))
    {
        Console.WriteLine("Fel: Titeln kan inte vara tom!");
        return;
    }
    bool removed = movies.Remove(withdrawInput);
    if (removed)
    {
        Console.WriteLine($"{withdrawInput} är nu borttagen från databasen!");
        transactions.Add($"Transaktionstyp: borttagning: {withdrawInput}");
    }
    else
    {
        Console.WriteLine($"Fel: Hittade inte {withdrawInput} i listan.");
    }
}

void DisplayList()
{
    Console.WriteLine($"Antal filmer: {movies.Count}");
    for (int i = 0; i < movies.Count; i++)
    {
        Console.WriteLine($"{i+1}. {movies[i]}");
    }
}

void DisplayHistory()
{
    if (transactions.Count == 0)
    {
        Console.WriteLine("Inga transaktioner finns registrerade ännu.");
        return;
    }
    foreach (var tran in transactions)
    {
        Console.WriteLine(tran);
    }
}

void SearchFilm(string? searchInput)
{
    // 1. Validera indata
    if (string.IsNullOrWhiteSpace(searchInput))
    {
        Console.WriteLine("Fel: Sökordet kan inte vara tomt!");
        return;
    }

    // 2. Sök ut alla filmer som innehåller sökordet (oavsett stora/små bokstäver)
    List<string> results = movies
        .Where(m => m.Contains(searchInput, StringComparison.OrdinalIgnoreCase))
        .ToList();

    // 3. Visa sökresultatet
    if (results.Count > 0)
    {
        Console.WriteLine($"\nHittade {results.Count} film(er) som matchar \"{searchInput}\":");
        foreach (var film in results)
        {
            Console.WriteLine($"- {film}");
        }
    }
    else
    {
        Console.WriteLine($"\nInga filmer hittades som matchar \"{searchInput}\".");
    }
}