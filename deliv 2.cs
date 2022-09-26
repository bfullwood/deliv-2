// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;


//int num = int.Parse(Console.ReadLine());


//decimal cost;
//int numbppl = (num);
//int wtr = (num);
//int pop = (num);



//if (numbppl > 6)
//{
//    Console.WriteLine("Sorry but the buffet is only availble for up to 6");

//}
//else
//{

//    Console.WriteLine("Please have a seat, Can we get started with some drinks? Pop or water?");



//    {


//        string name = "Pop";
//        switch (name)

//        {


//            case "Pop":
//                Console.WriteLine("Pop, good choice");
//                break;

//            case "Anything":
//                Console.WriteLine("Anything, good choice");
//                break;




//            case "Water":
//                Console.WriteLine("water, good choice");
//                break;
//        }

//        while (numbppl <= 6) ;
//        Console.WriteLine("Alright, person 1, Pop or water?");
//    }
//}



Console.WriteLine("Hi, Welcome to our buffet. All you can eat for just $9.99! We only charge extra for pop. " +
    "How many people are in your group? Please, parties of 6 or lower.");

var numOfPeople = int.Parse(Console.ReadLine());

if (numOfPeople > 6)
{
    Console.WriteLine("Sorry but the buffet is only availble for up to 6");
    return;
}
else
{
    Console.WriteLine("Please have a seat, Can we get started with some drinks? Pop or water?");
}

string selection;

int numPops = 0;
int numWaters = 0;

for (int i = 1; i <= numOfPeople; i++)
{
    Console.WriteLine($"Person {i} what do you want ");
    selection = Console.ReadLine();

    if (selection != "water" && selection != "pop")
    {
        Console.WriteLine($"{selection}, We dont have that");
    }
    else if(selection == "water")
    {
        Console.WriteLine("Water, Good Choice");
        numWaters++;
    }
    else if(selection == "pop")
    {
        Console.WriteLine("Pop, Good Choice");
        numPops++;
    }
}


Console.WriteLine($"Okay thats {numPops} Waters and {numWaters} Pops, Ill be right back");

int buffet = 0;
int numbppl = 0;
int total;

Console.WriteLine("Here's your bill! Total Price:");



