﻿
string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************************");
    Console.WriteLine("************* Součet a součin cifer *************");
    Console.WriteLine("*************************************************");
    Console.WriteLine("**************** Tomáš Žižka ********************");
    Console.WriteLine("**************** Aktuální datum ******************");
    Console.WriteLine("**************************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;

    if (number < 0)
    {
        number = -number;
    }

    while (number >= 10)
    {
        digit = number % 10;
        number = (number - digit) / 10;
        Console.WriteLine("Zbytek = {0}", digit);
        suma = suma + digit;
    }
    
    Console.WriteLine("Poslední zbytek: {0}", number);

    // musíme přičíst ještě poslední cifru
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}


