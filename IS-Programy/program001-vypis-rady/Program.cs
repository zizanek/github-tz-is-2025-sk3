﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("************* Výpis číselné řady *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Tomáš Žižka *****************");
    Console.WriteLine("**************** 02.10.2025 ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    // Vstup číselné hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());  


    // Vstup číselné hodnoty do programu - lépe řešený
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }


    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    Console.Write("Zadejte diferenci (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu: ");
    }


    











    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}


