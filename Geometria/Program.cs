

using Geometria;

//Inserisco i valori che passerò alla classe con readLine
Console.WriteLine("Inserisci la base del rettangolo");
int baseInput = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci altezza rettangolo");
int altezzaInput = int.Parse(Console.ReadLine());

//Creo l'oggetto
Rettangolo mioRettangolo = new Rettangolo(baseInput , altezzaInput);

mioRettangolo.perimetroRettangolo();
mioRettangolo.areaRettangolo();
mioRettangolo.stampaRettangolo();



