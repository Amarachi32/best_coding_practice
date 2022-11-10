// 1) use meaningful name

string x = "hello world"
string input = "hello world"

// 2) format your code properly

while (i < 5) 
{
Console.WriteLine(i);
i++;
}

while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}

// 3) code should speak for itself
// comment when there's need

// 4) assigning default value
if(8>4){
    Console.WriteLine("good");
}

int value1 = 8;
int value2 = 4;
if (value1 > value2){
    Console.WriteLine("good");
}

// 5) use of string builder
string name = "amara";
name = "ezeh"

StringBuilder name = new StringBuilder()
name.Append("ezeh")

// 6) check for null
int? result = data?.ToUpper.Length;

// 7) use public properties not public variables
person firstUser = new person()
firstUser.firstname = "akin";
firstUser.Lastname = "akin";

public string firstname {get; set;}
public string lastname {get; set;}

// 8) methods should do one thing

// 9) methods should not return more that one arguement

// 10) keep your code simple
for(int i = person.count-1; i>= 0; i--){
  Console.WriteLine('')
}

foreach(var person in people){
  Console.WriteLine('')
}

// 11) use curly braces for if statement
if (value1 > value2)
    Console.WriteLine("good");

if (value1 > value2){
    Console.WriteLine("good");
}

// 12) concatenate strings using $""
Console.WriteLine("welcome" + person.firstname );
Console.WriteLine($"welcome {person.firstname}");

// 13) avoid global variables
string input = ""
for(int i =0; i< 100; i++){
  input += "hi"
}


for(int i =0; i< 100; i++){
  string input = ""
  input += "hi"
}
// 14) use public modifier only when necessary 
class program{
  private static void name()
  {
    
  }
}

// 15) one class per file ----create new class file for every class
public class person{

}