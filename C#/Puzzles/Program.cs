// Create an empty array that will hold 10 integer values.

static int[] randomArray()
{
    Random r = new Random();
    int[] myArray = new int[10];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = r.Next(5, 25);
    }
    return myArray;
}

// the min value of the array
static int min(int[] myArray)
{
    int min = myArray[0];
    for (int i = 0; i < myArray.Length; i++)
    {

        if (myArray[i] < min)
        {
            min = myArray[i];
        }
    }
    return min;
}

int[] generatedArray = randomArray();
// testimi i funksionit 
foreach (int nr in generatedArray)
{
    Console.WriteLine(nr);
}
Console.WriteLine("//");
Console.WriteLine("Min number is " + min(generatedArray));

// max value of array

static int max(int[] myArray)
{
    int max = myArray[myArray.Length - 1];

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > max)
        {
            max = myArray[i];
        }
    }
    return max;

}
Console.WriteLine("Max number is " + max(generatedArray));

static int sum(int[] myArray)
{
    int sum = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        sum = sum + myArray[i];
    }
    return sum;
}

Console.WriteLine("Sum of all numbers in array is " + sum(generatedArray));


// Coin Flip
// Required:
// Create a function called TossCoin() that returns a strings
static string TossCoin()
{
    // Randomize a coin toss with a result signaling either side of the coin
    Random rand = new Random();
    // Have the function print "Tossing a Coin!"
    Console.WriteLine("Tossing a Coin! \n");

    // Have the function print either "Heads" or "Tails"
    int b = rand.Next(0, 2);
    if (b == 0)
    {
        Console.WriteLine("Heads!");
        return "Heads";
    }
    else
    {
        Console.WriteLine("Tails!");
        return "Tails";
    }

}
// Finally, return the result
TossCoin();





// //Names
// Build a function Names that returns a list of strings.  In this function:
static List<string> Names()
{
// Required: 
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney.
List <string> firstList = new List<string>(5);
List <string> secondList = new List<string>(5);


firstList.Add("Todd");
firstList.Add("Tiffany");
firstList.Add("Charlie");
firstList.Add("Geneva");
firstList.Add("Sydney");
// Return a list that only includes names longer than 5 characters
for (int i = 0; i < firstList.Count; i++)
{
    if ( firstList[i].Length > 5)
    secondList.Add(firstList[i]);    
}
    foreach (var item in secondList)
    {
       Console.WriteLine(item); 
    }
    // Optional:
// Shuffle the list and print the values in the new order.
   Console.WriteLine(" \n");
       Random rand = new Random();
    var randomized = secondList.OrderBy(item => rand.Next());
    foreach (var value in randomized)
    {
        Console.WriteLine(value);
    }
return secondList;

}
Names();


