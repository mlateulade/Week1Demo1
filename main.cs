using System;

class MainClass {
  public static void Main (string[] args) {
    //single line comment

    /* multi line comment
    hola
    como estas
    tenga buen dia
    */
    Console.WriteLine("Enter your name:");//Prompt for name
    var name = Console.ReadLine();//Ask for name
    Console.WriteLine("Your name is ");
    Console.WriteLine(name);
    
    /*age of a person
    int, double, float, decimal
    int = whole number 5
    double = decimal value 5.46
    */

    //age of a person
    int age;//declaring a variable

    //slary
    double salary = 64000.56;//and initializing a variable
    
    age = 6;
    salary = 0;

    //string datatype
    string address = "1111 Main St, cleveland, OH";

    //bool = true or false?
    bool isUnderAge = false;



  }
}