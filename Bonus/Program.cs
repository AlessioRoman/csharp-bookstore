//CREO E ASSEGNO LE VARIABILI

Console.WriteLine("Inserisci il titolo: ");
string title = Console.ReadLine();

Console.WriteLine("Inserisci l'autore: ");
string author = Console.ReadLine();

Console.WriteLine("Inserisci l'isbn: ");
string isbn = Console.ReadLine();

Console.WriteLine("Inserisci il numero di pagine: ");
int pages = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il peso: ");
float weight = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la larghezza: ");
float xDimensions = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza: ");
float yDimensions = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la larghezza: ");
float zDimensions = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci la valutazione in stelle di amazon: ");
float averageRating = float.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il numero di recensioni: ");
int numberOfVotes = int.Parse(Console.ReadLine());

Console.WriteLine("Digita [true] ebook disponibile - [false] ebook non disponibile: ");
bool isEbookAvaiable = bool.Parse(Console.ReadLine());

Console.WriteLine("Digita [true] copertina flessibile disponibile - [false] copertina flessibile disponibile: ");
bool isFlexibleCoverAvaiable = bool.Parse(Console.ReadLine());

//STAMPO RESOCONTO

Console.WriteLine("------ IL LIBRO DI OGGI: " + title + " di " + author + " ------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + isbn);
Console.WriteLine("Numero di pagine: " + pages + " pagine");
Console.WriteLine("Peso del libro: " + weight + "g");
Console.WriteLine("Dimensioni del libro: " + xDimensions + "cm x " + yDimensions + "cm x " + zDimensions + "cm");
Console.WriteLine();
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + numberOfVotes + " recensioni");
Console.WriteLine("Valutazione media: " + averageRating + " stelline");
if (isEbookAvaiable)
{
    Console.WriteLine("Kindle disponibile: Si");
}
else
{
    Console.WriteLine("Kindle disponibile: No");
}
if (isFlexibleCoverAvaiable)
{
    Console.WriteLine("Copertina flessibile disponibile: Si");
}
else
{
    Console.WriteLine("Copertina flessibile disponibile: No");
}
Console.WriteLine("------------------------------------------------------------------------------------");
