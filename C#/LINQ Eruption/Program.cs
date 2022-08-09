
List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

//Print first Eruption of Chile
IEnumerable<Eruption> firstEruptionInChile = eruptions.Where(c => c.Location == "Chile").OrderBy(c => c.Year).Take(1);
PrintEach(firstEruptionInChile,"Fist Eruption in Chile");

//Find the first Hawaian is location and print it. If none is found, print "No Hawaian Is Eruption found".
IEnumerable <Eruption> firstHawaianIs = eruptions.Where(c => c.Location == "Hawaiian Is").OrderBy(c => c.Year).Take(1).ToList();
if (firstHawaianIs.Count() < 1)
{
    Console.WriteLine("No Hawaian Is Eruption found");
}
else
{
    PrintEach(firstHawaianIs, "The Hawaian Eruption");
}

//Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
IEnumerable<Eruption> newZelandAfter1900 = eruptions.Where(c => c.Location == "New Zealand").OrderBy(y => y.Year > 1900).Take(1);
PrintEach(newZelandAfter1900, "New Zeland volcano afer 1900 is");

//Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> elevationOver2000 = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
PrintEach(elevationOver2000, "The eruptions over 2000m above sea level");

//Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(e => e.ElevationInMeters);
Console.WriteLine($"Highest elevations is {highestElevation}");

//Use the highest elevation variable to find a print the name of the Volcano with that elevation.
Eruption highName = eruptions.Where(h => h.ElevationInMeters == highestElevation).First();
Console.WriteLine("The name of highes Eruption is ", highName.Volcano);

//Print all Volcano names alphabetically.
List<Eruption> volcanoNames = eruptions.OrderBy(n => n.Volcano).ToList();

foreach (var item in volcanoNames)
{
    Console.WriteLine(item.Volcano);
}

//Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> before1000 = eruptions.Where(n => n.Year < 1000).OrderBy(n => n.Volcano);
PrintEach(before1000, "Eruptions before 1000");

//BONUS: Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.

List<string> names = new List<string>();
foreach (var item in before1000)
{
    names.Add(item.Volcano);

}
foreach (var item in names)
{
    Console.WriteLine(item);
}

//Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
