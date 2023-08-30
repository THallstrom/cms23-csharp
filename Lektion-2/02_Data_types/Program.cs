/*
 *  C# standard datatyper som används
 *  -------------------------------------
 *  string          Till för text           string name = "Thomas";
 *  int             till för heltal         int age = 43;
 *  long            till för heltal         long age = 43;
 *  decimal         till för decimaltal     decimal length = 164,5m;
 *  double          till för decimaltal     double lenght  = 165,6;
 *  float           till för decimaltal     float lenght =  165,5f;
 *  bool            till för sant/falskt    bool isHuman = true;
 *  char            till för enskilda tecken char gender = "M";
 *  dynamic         kan innehålla vad som   dynamic lastName = "Mattin-Lassei";
 *                                          dynamic weight = 90,0;
 *  Guid            globalt unikt id        Guid id = Guid.NewGuid();
 *  byte
 *  null
 *  object
 */

/*
 * Deklarera variabler
 * --------------------------------------------
 * Hur man skriver variabel namn:
 * 
 * camelCase        firstName           string firstName = "Thomas";
 * Pascal           FirstName           string FirstName = "Thomas";
 * kebab-case       first-name          string first-name = "Thomas";
 * snake-case       first_name          string first_name = "Thomas";
 * 
 * C# använder sig primärt av Pascal men även camelCase
 * 
 * korrekt sätt att deklarera:          string firstName = "Hans";
 * latmanssättet att deklarera:         var firstName = "Hans";
 */

/*
 * STRING - Text baserade värden
 * -------------------------------------------------------------------
 * string firstName = "Hans";
 * var lastName = "Mattin-Lassei";
 * 
 * string placeholder_1 = "Hej jag heter " + firstName + " " + lastname".";
 * string placeholder_2 = $"Hej jag heter {firstName} {lastName}";
 * string placeholder_3 = string.Format("Hej jag heter {0} {1}", firstName, lastName;
 */

Console.WriteLine("Skriv in ditt förnamn");
string firstName = Console.ReadLine() ?? "";

Console.WriteLine("Skriv in ditt efternanm");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Mitt namn är {firstName} {lastName}.");
Console.ReadKey();
