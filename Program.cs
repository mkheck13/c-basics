// These characters will generate a place to write notes to ourselves or disable any code we do not want to fire.

/* 
this is a multi line comment. it is used to write notes to ourselves or disable any code we do not want to fire.
*/

Console.Clear(); // this will clear the console
Console.Write("Welcome to the basics!"); // Console.Write will write to the console on the same line
Console.WriteLine(""); // Console.WriteLine will write to the console and then move to the next line
Console.WriteLine("I am going to be on a new line.");

Console.ReadLine(); // This will pause the console and wait for the user to input something before moving on after the enter key is pressed

// variables give us the ability to store the type of data we want into them

string myVariable; // we have initialezed our variable but did not assign a value to it

myVariable = "String Text"; // we have assigned the value to the variable with its correct type

string newVariable = "This is a new variable"; // we can do this in one line

// we created a new variable and combined the two variables together
string conbinedVariable = myVariable + " " + newVariable;

Console.WriteLine(myVariable);

// this is known as concatenation. we are using a string and then printing out the value of the variable
Console.WriteLine("The value of myVariable is: " + myVariable);
Console.WriteLine(myVariable + " " + newVariable);
Console.WriteLine(conbinedVariable);
Console.WriteLine("The value of your fist variable is: " + myVariable + " ,The value of the second variable is: " + newVariable);

// this is known as string interpolation
Console.WriteLine($"The values of our data is: {myVariable} and {newVariable}");

// we have initialzed our variable to a int data type and set the value to 2
int fistNum = 2;
int secNum = 2;

// Console.WriteLine(fistNum + secNum);

int doMath = fistNum + secNum;
Console.WriteLine(doMath);
Console.WriteLine(fistNum + secNum);

Console.WriteLine("<---------------------------------------------------------------------------->");

Console.WriteLine("Good afternoon! Who are you?");
string yourName = Console.ReadLine();
Console.WriteLine($"Hello {yourName} it is nice to meet you!");