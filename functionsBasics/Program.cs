using System;

// functions are used to group re-usable code together in a single unit
// that can be customized with parameters.

// functions have a return type, name, and optional parameters
float MilesToKm(float miles){
    float km = miles * 1.60f;
    return km;
}

// a function with no return type has a void return type
void print(string str){
    Console.WriteLine($"::> {str}");
}

//call first function
Console.WriteLine($"the result is {MilesToKm(8.0f)}");
Console.WriteLine($"the result is {MilesToKm(54.0f)}");

// call second function
print("string");
print("another string");