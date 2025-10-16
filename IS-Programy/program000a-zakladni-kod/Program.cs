string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("************* Název programu *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Tomáš Žižka *****************");
    Console.WriteLine("**************** Aktuální datum ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }










    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}


