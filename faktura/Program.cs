// Faktura genererings app:
using Faktura;


Console.WriteLine("Hej! Välkommen till att generera din faktura!");
Console.WriteLine("Vill du generera en faktura att skicka? Tryck 'd'");
Console.WriteLine("Vill du betala en faktura? Tryck 'b'");
Console.WriteLine("Vill du avbryta? Tryck 'x'");

App();

static void App()
{
    try
    {
        while (true)
        {
            var key = Console.ReadLine();
            if (string. IsNullOrWhiteSpace(key) || key == "x")
            {
                Environment.Exit(0);
            }
            switch (key)
            {
                case "d":
                break;

                case "b":
                break;
                
                default:
                break;
            }
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine(ex.Message);
        Console.WriteLine("Nu blev det errors!");
        Console.ResetColor();
    }
    finally
    {
        Console.WriteLine("klar!");
    }
}

// Metoder:
static void CustomerID()
{
    // Kundnummer, kvittonummer, namn
}

static void CalculatePurchases()
{
    // Matematik, moms osv
}

static void DisplayPurchases()
{
    // Köpta produkter, transaction id (inkl datum)
}

static void DisplayInfo()
{
    // Företagsnamn, företagsinfo, kontaktinfo
}