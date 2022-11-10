# 15 best_coding_practice
### 1 use meaningful name

```c#
 ///<summary> wrong code <summary>
    string x = "hello world"
///<summary> correct code <summary>
    string input = "hello world"
```
### 2 format your code properly
```c#
 ///<summary> wrong code <summary>
while (i < 5) 
{
Console.WriteLine(i);
i++;
}
///<summary> correct code <summary>
    while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}
```


### 3  code should speak for itself
** comment when is necessary

### 4 Make it dynamics
///<summary> wrong code <summary>
```c#
if(8>4){
    Console.WriteLine("good");
}
///<summary> correct code <summary>
int value1 = 8;
int value2 = 4;
if (value1 > value2){
    Console.WriteLine("good");
}


```
### 5 use of string Builder
```c#
///<summary> wrong code <summary>
string name = "amara";
name = "ezeh"
///<summary> correct code <summary>
StringBuilder name = new StringBuilder()
name.Append("ezeh")
```
### 6 check for null
```c#
///<summary> wrong code <summary>
int result = data.ToUpper.Length;
///<summary> correct code <summary>
int? result = data?.ToUpper.Length;
```

### 6 use public properties not public variables
```c#
person firstUser = new person()
///<summary> wrong code <summary>

firstUser.firstname = "akin";
firstUser.Lastname = "akin";
///<summary> correct code <summary>
public string firstname {get; set;}
public string lastname {get; set;}
```
### 8 Method should do one thing
```c#
 **Method should do one thing
```
### 9 Method should not return more than two arguments
```c#
 **Method should not return more than two arguments
```
### 10 keep your code simple
```c#
person firstUser = new person()
///<summary> wrong code <summary>

for(int i = person.count-1; i>= 0; i--){
  Console.WriteLine('')
}

///<summary> correct code <summary>

foreach(var person in people){
  Console.WriteLine('')
}
```
### 11) use curly braces for if statement
```c#
person firstUser = new person()
///<summary> wrong code <summary>

 
if (value1 > value2)
    Console.WriteLine("good");


///<summary> correct code <summary>

if (value1 > value2){
    Console.WriteLine("good");
}
```

### 12) concatenate strings using $""
```c#

///<summary> wrong code <summary>

Console.WriteLine("welcome" + person.firstname );

///<summary> correct code <summary>
Console.WriteLine($"welcome {person.firstname}");
```
### 13) avoid global variables
```c#

///<summary> wrong code <summary>

string input = ""
for(int i =0; i< 100; i++){
  input += "hi"
}
///<summary> correct code <summary>
for(int i =0; i< 100; i++){
  string input = ""
  input += "hi"
}

```
### 14) use public modifier only when necessary 
```c#

///<summary> wrong code <summary>

///<summary> correct code <summary>

class program{
  private static void name()
  {
    
  }
   }
```
### 15) one class per file ----create new class file for every class
```c#

///<summary> wrong code <summary>

///<summary> correct code <summary>

class program{
 public class person{

}
}
```




    
