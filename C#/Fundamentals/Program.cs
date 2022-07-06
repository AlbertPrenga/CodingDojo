//  Fundamentals
//first loop from 1-255
for (int i = 1; i <=255; i++){
    Console.WriteLine(i);
}
// second loop from 1-100 that are divisible by 3 and 5.

for (int j = 1; j <= 100; j++){
    if ( j % 3 == 0 && j % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else if ( j % 3 == 0 ){
        Console.WriteLine("Fizz");
    }
    else if (j % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else{
        Console.WriteLine(j);
    }
}

// Now the same execise worked with while loop

int count = 1;
while(count < 255){
    Console.WriteLine(count);
    count++;
   
}

int countNew = 1;
while( countNew < 100){
    if (countNew % 3 == 0 && countNew % 5 == 0){
        Console.WriteLine("FizzBuzz");
        countNew++;
    }
    else if (countNew % 3 == 0){
        Console.WriteLine("Fizz");
        countNew++;
    }
       else if (countNew % 5 == 0){
        Console.WriteLine("Buzz");
        countNew++;
    }
    else{
        Console.WriteLine(countNew);
        countNew++;
    }
}