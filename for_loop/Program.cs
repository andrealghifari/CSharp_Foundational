// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// for loop contain --> for([initializer], [condition], [iteration])

string[] name = ["Alex", "Eddie", "David", "Michael"];
for(int i = name.Length - 1; i >= 0; i--){
    if(name[i] == "David") name[i] = "Sammy";
}
foreach(string person in name){
    Console.WriteLine(person);
}

// FIZZBUZZ Challenge
/*
 - output the value from 1 to 100, one number perline
-  when the current value divisible by 3, print Fizz
-  when the current value divisible by 5, print Buzz
-  when the current value divisible by 3 and 5, print FizzBuzz
*/
for(int i = 0; i <= 100; i++){
     if((i % 3 == 0) && (i % 5 == 0)){
        Console.WriteLine($"{i} - FizBuzz");
    }
    else if(i % 3 == 0 ){
        Console.WriteLine($"{i} - Fizz");
    }
    else if(i % 5 == 0 ){
        Console.WriteLine($"{i} - Buzz");
    }
   
    else{
            Console.WriteLine($"{i}");
    }
}