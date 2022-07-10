// Create an empty list of type object

List <object> Boxing = new List<object>();
//Add the following values to the list: 7, 28, -1, true, "chair"
Boxing.Add(7);
Boxing.Add(28);
Boxing.Add(-1);
Boxing.Add(true);
Boxing.Add("chair");

//Loop through the list and print all values
foreach(var item in Boxing)
Console.WriteLine(item);

//Add all values that are Int type together and output the sum
int sum = 0;
for (int i = 0; i < Boxing.Count; i++){
if (Boxing[i] is int){
sum += Convert.ToInt32(Boxing[i]);
  }
}
Console.WriteLine("The sum of int types inside List is " + sum);