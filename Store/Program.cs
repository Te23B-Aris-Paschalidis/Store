using Microsoft.VisualBasic;

int kronor = 100;


while (kronor > 0)
{


    Console.WriteLine($"Du har {kronor} kronor att spendera\n");
    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. Keps 10kr");
    Console.WriteLine("2. Tröja 30kr");
    Console.WriteLine("3. Jeans 50kr");

    string val = Console.ReadLine();

    Console.WriteLine("Hur många?");
    string antal = Console.ReadLine();

    int ant;

    int.TryParse(antal, out ant);

    if (val == "1")
    {
        int totalKostnad = ant * 10;
        if (totalKostnad <= kronor)
        {
            Console.WriteLine("Ja");
            kronor -= totalKostnad;
            Console.WriteLine($"Du har {kronor} kr kvar");
        }
        else
        {
            Console.WriteLine("Nej");
        }
        Console.WriteLine(totalKostnad);
    }

    if (val == "2")
    {
        int totalKostnad = ant * 30;
        if (totalKostnad <= kronor)
        {
            Console.WriteLine("Ja");
            kronor -= totalKostnad;
            Console.WriteLine($"Du har {kronor} kr kvar");
        }
        else{
            Console.WriteLine("Nej det går ej");
        }
    }

if (val == "3")
{
    int totalKostnad = ant * 50;
    if (totalKostnad <= kronor)
    {
        Console.WriteLine("Ja");
        kronor -= totalKostnad;
        Console.WriteLine($"Du har {kronor} kr kvar");
    }
    else{
        Console.WriteLine("Nej det går ej");
    }
}

}

Console.ReadLine();






// int i = 0;wqdwdsa
// while (i < 10)
// {
// Console.WriteLine("hej");
// i++;
// }

// for (int j=0; j < 10; j++)
// {
//     Console.WriteLine("hej");
// }



// bool success = false;
// int ageNum = 0;

// while (success != true)
// {
//     Console.WriteLine("Ålder:");
//     string age = Console.ReadLine();


//     success = int.TryParse(age, out ageNum);

//     if (success == false)
//     {
//         Console.WriteLine("Skriv en siffra, dumhuvve");
//     }
// }

// if (ageNum >= 18)
// {
//     Console.WriteLine("Välkommen!");
// }

// Console.ReadLine();