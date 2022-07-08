// Three Basic Arrays
// Create and array to hold integer values 0 through 9.

int [] numbers = new int [10];

//Create an array of the names "Tim", "Martin", "Nikki", & "Sara"

string [] names = {"Tim", "Martin", "NIkki", "Sara"};

// Create an array of length 10 that alternates between true and false values, starting with true.

bool [] TrueFalse = new bool [10];
for (int i = 0; i < TrueFalse.Length; i++){
    if (i % 2 == 0){
        TrueFalse[i]= true;
    }
    else{
        TrueFalse[i] = false;
    }
    Console.WriteLine(TrueFalse[i]);
}
// List of Flavors

// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)

List<string> iceCream = new List<string>();
iceCream.Add("cherry");
iceCream.Add("chocolate");
iceCream.Add("vanila");
iceCream.Add("forest fruits");
iceCream.Add("Pistachio");

// Output the length of this list after building it
Console.WriteLine(iceCream.Count);
//Output the third flavor in the list, then remove this value

Console.WriteLine(iceCream[2]);
iceCream.Remove("vanila");
//Output the new length of the list (It should just be one fewer!)
Console.WriteLine(iceCream.Count);


// //User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly elected flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor
Random rand = new Random();
Dictionary<string,string> join = new Dictionary<string, string>();
for (int i = 0; i < names.Length; i++){
    join.Add(names[i], iceCream[rand.Next(0,iceCream.Count - 1)]);
}
foreach (var item in join)
{
    Console.WriteLine(item.Key +"-"+ item.Value );
}
