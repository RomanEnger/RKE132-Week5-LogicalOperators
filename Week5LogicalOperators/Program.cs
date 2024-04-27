

//AND - &&


//true && true --> true
//true && false --> false
//false && true --> false
//false && false --> false

//OR - || (pipes)

//true || true --> true
//true || false --> true
//false || true --> true
//false || false --> false

using System.ComponentModel.Design;

string userPIN, userName, password;
Console.WriteLine("Enter PIN:");
userPIN = Console.ReadLine();

if(userPIN == "1234")
{
    Console.WriteLine("Enter your username:");
    userName = Console.ReadLine();
    Console.WriteLine("Enter your password:");
    password = Console.ReadLine();
    if(userName == "admin1" && password == "admin1234")
    {
        Console.WriteLine("Welcome!");
    }
    else
    {
        Console.WriteLine("Invalid login credentials.");
    }
}
else
{
    Console.WriteLine("Invalid PIN.");
}