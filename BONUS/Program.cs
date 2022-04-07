using BONUS;

//Inserisco i valori che passerò alla classe con readLine
Console.WriteLine("Inserisci la base del rettangolo");
int baseInput = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci altezza rettangolo");
int altezzaInput = int.Parse(Console.ReadLine());

//Creo l'oggetto
Class1 mioRettangolo = new Class1(baseInput, altezzaInput);
mioRettangolo.perimetroRettangolo();
mioRettangolo.areaRettangolo();
mioRettangolo.stampaRettangolo();
mioRettangolo.disegnoRettangolo();

//Inserisco i valori che passerò alla classe con readLine
Console.WriteLine("Inserisci la base del rettangolo");
int baseInput2 = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci altezza rettangolo");
int altezzaInput2 = int.Parse(Console.ReadLine());

//Creo un altro oggetto
Class1 mioRettangolo2 = new Class1(baseInput2, altezzaInput2);

mioRettangolo2.perimetroRettangolo();
mioRettangolo2.areaRettangolo();
mioRettangolo2.stampaRettangolo();
mioRettangolo2.disegnoRettangolo();