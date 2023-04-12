string title = "Clean Code: A Handbook of Agile Software Craftsmanship";
string author = "Robert C. Martin";
string isbn = "978-0132350884";
int pages = 431;
float weight = 800f;
float xDimensions = 17.78f;
float yDimensions = 23.37f;
float zDimensions = 2.79f;
float averageRating = 4.7f;
int numberOfVotes = 5414;
bool isEbookAvaiable = true;
bool isFlexibleCoverAvaiable = true;

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
} else
{
    Console.WriteLine("Copertina flessibile disponibile: No");
}
Console.WriteLine("------------------------------------------------------------------------------------");
