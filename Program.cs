bool isRunning = true;

string firstOption = "Debug Hero";
string secondOption = "Bugs of Horror";
string thirdOption = "Speedy XL";
string fourthOption = "Turbo Tom 2000";

//Console.Clear();

//Console.WriteLine("Wat is je gewicht?");
//int weight = int.Parse(Console.ReadLine());

while (isRunning)
{
    Console.WriteLine("Welkom bij Attractie-Checker!");
    Console.WriteLine("1. Debug Hero");
    Console.WriteLine("2. Bugs of Horror");
    Console.WriteLine("3. Speedy XL");
    Console.WriteLine("4. Turbo Tum 2000");

    string answer = Console.ReadLine();
    Console.Clear();

    if (answer == "1")
    {
        Console.Clear();
        Console.WriteLine("Wat is je leeftijd?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Wat is je lengte?");
        int length = int.Parse(Console.ReadLine());

        if (age >= 12 && length >= 120)
            Console.WriteLine($"Je mag in {firstOption}!");

        Console.WriteLine("Wilt u afsluiten? Ja / Nee");
        string closeQ = Console.ReadLine();

        if (closeQ == "Nee")
            Console.Clear();

        else if(closeQ == "Ja")
        {
            break;
        }

        Console.Clear();
        continue;

    }

    if (answer == "2")
    {
        Console.Clear();
        Console.WriteLine("Vul je leeftijd in:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Vul je gewicht in:");
        int weight = int.Parse(Console.ReadLine());

        if (age > 16 && weight < 95)
            Console.WriteLine($"Je mag in {secondOption}!");
        else
            Console.WriteLine($"Je mag niet in {secondOption}!");

        Console.WriteLine("Wilt u afsluiten? Ja / Nee");
        string closeQ = Console.ReadLine();

        if (closeQ == "Nee")
            Console.Clear();

        else if (closeQ == "Ja")
        {
            break;
        }

        Console.Clear();
        continue;

    }

    if (answer == "3")
    {
        Console.WriteLine("Vul je lengte in:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Vul je gewicht in:");
        int weight = int.Parse(Console.ReadLine());

        if (length > 90 && weight < 120)
        {
            Console.WriteLine($"Je mag in {thirdOption}!");
        }
        else
        {
            Console.WriteLine($"Je mag niet in {thirdOption}!");
        }

        Console.WriteLine("Wilt u afsluiten? Ja / Nee");
        string closeQ = Console.ReadLine();

        if (closeQ == "Nee")
            Console.Clear();

        else if (closeQ == "Ja")
        {
            break;
        }

        Console.Clear();
        continue;
    }

    if (answer == "4")
    {
        Console.Clear();
        Console.WriteLine("Vul je leeftijd in:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Vul je lengte in:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Vul je gewicht in:");
        int weight = int.Parse(Console.ReadLine());

        if (age > 12 && weight < 120 || length > 100 && weight < 120)
        {
           Console.WriteLine($"Je mag in {fourthOption}!");
        }
        else
        {
            Console.WriteLine($"Je mag niet in {fourthOption}!");
        }

        Console.WriteLine("Wilt u afsluiten? Ja / Nee");
        string closeQ = Console.ReadLine();

        if (closeQ == "Nee")
            Console.Clear();

        else if (closeQ == "Ja")
        {
            break;
        }

        Console.Clear();
        continue;
    }
}
