string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************************");
    Console.WriteLine("************* Převod z desítkové do binární (dvojkové) soustavy *************");
    Console.WriteLine("**********************************************");
    Console.WriteLine("**************** Tomáš Žižka *****************");
    Console.WriteLine("**************** 27.11.2025 ******************");
    Console.WriteLine("**********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu
    Console.Write("Zadejte přirozené číslo v desítkové soustavě: ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené číslo v desítkové soustavě znovu: ");
    }

    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;

    uint zbytek;

    uint i;
    for(i=0; number10 > 0  ;i++) {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek)/2;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část = {0}; zbytek = {1}", number10, zbytek); 
    }

    // zpětný výpis pole
    Console.Write("Desítkové číslo {0} ve dvojkové soustavě = ", backupNumber10);
    for(uint j = i-1; j>=0;j--) {
        Console.Write("{0}", myArray[j]);
    }
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}