// 1. Print 1-255
static void Printnumbers()
{
    int i = 1;
    while (i < 255)
    {
        Console.WriteLine(i);
        i++;
    }

}
Printnumbers();

//  2. Print odd numbers between 1-255

static void PrintOdds()
{
    for (int i = 1; i < 266; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
PrintOdds();

// 3. Print sum
static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:

    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int sum = 0;
    for (int j = 0; j <= 255; j++)
    {
        sum = sum + j;
        Console.WriteLine(sum);
    }

}
PrintSum();

// 4. Iterating through an Array
static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    foreach (int number in numbers)
    {
        Console.WriteLine( number);
    }
}
int[] myArray = { 1, 3, 5, 6, 7 };

LoopArray(myArray);

// 5. Find max
static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i])
        {
            max = numbers[i];
        }
    }
    Console.WriteLine(max);
    return max;
}
FindMax(myArray);

// 6. Get average

int[] numArray = { 2, 10, 3 };
int[] vargu = { 3, 5, 7, 7, 10 };
static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int average;
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
    }

    average = sum / numbers.Length;
    Console.WriteLine(average);
}
// myArray eshte deklaruar me lart
GetAverage(myArray);
// numArray eshte tek ky ushtrim
GetAverage(numArray);
GetAverage(vargu);

// //7. Array with Odd Numbers
static int[] OddArray(int nr)
{
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
    // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].



    int[] Odds = new int[nr];
    int inx = 0;
    for (int i = 1; i < nr * 2; i++)
    {
        if (i % 2 != 0)
        {

            Odds[inx] = i;
            inx++;
        }
    }
    for (int i = 0; i < Odds.Length; i++)
    {
        Console.WriteLine(Odds[i]);
    }

    return Odds;
}



static void printo(int[] nr)
{
    foreach (var item in nr)
    {
        Console.WriteLine(item);
    }
}
printo(OddArray(133));




int[] array = { 1, 3, 5, 7, 4, 6 };

//8. Greater than Y.
static int GreaterThanY(int[] numbers, int y)
{
    // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
    // That are greater than the "y" value. 
    // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
    // (since there are two values in the array that are greater than 3).
    List<int> number = new List<int>();
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > y)
        {

            number.Add(numbers[i]);
            Console.WriteLine(number.Count());
        }
    }

    return number.Count();
}
GreaterThanY(array, 3); // this function was created by me. Down is the example by the platform. In my function


static int BigerThanY(int[] numbers, int y)
{
    int idxTally = 0;
    foreach (int num in numbers)
    {
        if (num > y)
            idxTally++;
    }
    Console.WriteLine(idxTally);
    return idxTally;
}
Console.WriteLine("Greater than Y, solution from the platform");
BigerThanY(array, 3);


// 9. Square the Values

static void SquareArrayValues(int[] numbers)
{
    //     // Write a function that takes an integer array "numbers", and then multiplies each value by itself.

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= numbers[i];
    }
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
    //     // For example, [1,5,10,-10] should become [1,25,100,100]
}
Console.WriteLine("Square array values");
SquareArrayValues(array);

//10. Eliminate Negative Numbers
int[] negative = { 1, 5, -8, 10, -2 };
static void EliminateNegatives(int[] numbers)
{
    // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] = 0;
        }
    }
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    foreach (var it in numbers)
    {
        Console.WriteLine(it);
    }
}
Console.WriteLine("Negative returned 0");
EliminateNegatives(negative);

// 11. Min, Max, and Average

static void MinMaxAverage(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
    // the minimum value in the array, and the average of the values in the array.
    int min = numbers[0];;
    
    
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        min = numbers[i];
        
    }
   
    int max =  numbers[0];
    for (int i = 0; i < numbers.Length; i++){
    
        if(numbers[i] > max){
            max = numbers[i];
            
        }
    }
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++){
        sum = sum + numbers[i];
        
    }
    int average = sum / numbers.Length;
    
Console.WriteLine("Max number is " + max);
Console.WriteLine("Min number is " + min);
Console.WriteLine("Sum of array is " + sum);
Console.WriteLine("Average of the array is " + average);

}
MinMaxAverage(myArray);

// 12. Shifting the values in an array.

int [] shiftArray = {1, 5, 10, 7, -2};

static void ShiftValues(int[] numbers)
{
    // Given an integer array, say [, 
    // Write a function that shifts each number by one to the front and adds '0' to the end. 
    // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
    // it should become [5, 10, 7, -2, 0].

    for (int i = 0; i < numbers.Length -1; i++){

        numbers[i] = numbers[i + 1];
        
        
        
    }
        numbers[numbers.Length -1] = 0;
        foreach (var item in numbers)
        
        {
          Console.WriteLine(item);  
        }
        
    
}ShiftValues(shiftArray);



//13. // #13 Number to String
int [] DojoArray = new int [] {-6,-2, 0, 4, 3, -9, 5, 1, -3};

static object [] NumToString(int [] numbers)
{
object [] objects = new object[numbers.Length]; 
for (int i = 0; i < numbers.Length; i++)
{
 if (numbers[i] < 0)
    objects[i] = "Dojo";
 
 else   
    objects[i] = numbers[i];

 Console.WriteLine(objects[i]);
}
 
return objects;
}
NumToString(DojoArray);
