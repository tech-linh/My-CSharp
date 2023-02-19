//Schreibe ein Programm, das die Eingabe des Benutzers liest und überprüft, ob die eingegebene Zahl gerade oder ungerade ist.

bool fertig = false;


while (!fertig)
{
    try
    {
        Console.WriteLine("Gebe eine zufällige Nummer ein: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        { Console.WriteLine($"{number} ist eine gerade Zahl"); }
        else if (number % 2 == 1)
        { Console.WriteLine($"{number} ist eine ungerade Zahl"); }
        else
        {
            Console.WriteLine("Falsche Eingabe. Bitte versuche nochmal! ");
            Console.ReadLine();
        }


        Console.WriteLine("\nGeben Sie 'exit' ein, um das Programm zu beenden, oder drücken Sie eine beliebige Taste, um das Programm erneut zu verwenden.");
        string input = Console.ReadLine();
        if (input.ToLower() == "exit") { fertig = true; }
    }

    catch (FormatException)
    {
        Console.WriteLine("Falsche Eingabe. Bitte versuchen Sie es nochmal! ");
        Console.ReadLine();
    }
}


