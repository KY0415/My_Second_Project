// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string a = "Tomal";
string b = "Yasin";

Console.WriteLine($"My name is {a} {b}");       // "$" means interpolation. Interpolation means: substitutes values of variables into placeholders in a string. It's kind of concatenation.....



// Use of "Trim()" function

string f1 = "   Jack    ";
string f2 = "   John    ";

Console.WriteLine("My Friends are " + f1.TrimStart() + " and " + f2.Trim());        // "TrimStart()" will remove the extra spaces before the string, "TrimEnd()" will delete remove the extra spaces after the string and "Trim()" will remove all the extra spaces (before & after) of the string.....




// "Replace()" Function


string friends = $"My friends are {f1.Trim()} and {f2.Trim()}";


Console.WriteLine(friends);
Console.WriteLine(friends.Replace("John", "Tom"));  // That will not change the "friends" variable.....
Console.WriteLine(friends);


// Now I will change the value of variable "friends"

friends = friends.Replace("John", "Tom");

Console.WriteLine(friends);     // Now it is changed 


// "Contain()" function

Console.WriteLine(friends.Contains("Tomal"));   // It will give True of False


// "ToUpper()" & "ToLower()" function


Console.WriteLine(friends.ToUpper());

// "Length" function

Console.WriteLine(friends.Length);