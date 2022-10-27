// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;
using Microsoft.VisualBasic;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("//");

////Initializing Work
//string[] myFoods = { "Lasagna", "Pizza", "Gelato", "Pizza all'Ananasso", "BurroFritto", "Ragu con Mayonese" }; //add an extra name like "banana" to make the array ODD

//// Length of Array
//Console.WriteLine("You like " + myFoods.Length + " different foods");
//Console.WriteLine("//");
//// First position of Array
//Console.WriteLine("First food is " + myFoods[0]);
//Console.WriteLine("//");

//// All food types
//Console.WriteLine("All the foods are:");
//for (int i = 0; i < myFoods.Length; i++)
//{
//    // ArrayIndex+1 + ArrayElement as string
//    Console.WriteLine(" " + (i+1) + " - " + myFoods[i]);

//    // If i == lengthArray - 1 then last item is
//    if(i == (myFoods.Length - 1))
//    {
//        Console.WriteLine("//");
//        Console.WriteLine("Last food is " + myFoods[i]);
//    }
//};

////Bonus Exercise: print only Middle Array element (account for even or odd array lengths
//int arrayLength = myFoods.Length;

//Console.WriteLine("//");
//Console.WriteLine("Array length is " + arrayLength);

//// % is the module operator, reminder after dividing
//int arrayMiddle = (arrayLength/2);

//if (arrayLength % 2 == 0)
//{
//    Console.WriteLine("The Array has an Even pair of elements");
//    Console.WriteLine("The Middle elements are " + myFoods[arrayMiddle-1] + " and " + myFoods[arrayMiddle]);
//}
//else
//{
//    Console.WriteLine("The Array has an Odd pair of elements");
//    Console.WriteLine("The Middle element is " + myFoods[arrayMiddle]);
//}




//SNACKS

//CONDITIONAL STATEMENTS
//Snack1: L’utente inserisce due numeri in successione.Il software stampa il maggiore.
{
Console.WriteLine("//");
Console.WriteLine("SNACK 1");

string string1;
Console.WriteLine("Insert a number ");
string1 = Console.ReadLine();
int num1 = Convert.ToInt32(string1);

string string2;
Console.WriteLine("Insert another number ");
string2 = Console.ReadLine();
int num2 = Convert.ToInt32(string2);

if (num1 > num2)
{
Console.WriteLine(num1 + " is bigger than " + num2);
}
else if (num1 < num2)
{
Console.WriteLine(num2 + " is bigger than " + num1);
}
else
{
Console.WriteLine("They are the same number");
}
}
//Snack2. L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga
{
Console.WriteLine("//");
Console.WriteLine("SNACK 2");

string word1;
Console.WriteLine("Insert a word");
word1 = Console.ReadLine();

string word2;
Console.WriteLine("Insert another word");
word2 = Console.ReadLine();

if (word1.Length >= word2.Length)
{
Console.WriteLine(word1 + " " + word2);
}
else
{
Console.WriteLine(word2 + " " + word1);
}
}


//FOR CYCLE
//Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.
{
Console.WriteLine("//");
Console.WriteLine("SNACK 3");

int totalSum = 0;
for (int i = 1; i < 11; i++)
{

string answer;
Console.WriteLine(i + ") Insert a number:");
answer = Console.ReadLine();
int localSum = Convert.ToInt32(answer);

totalSum = (totalSum + localSum);
Console.WriteLine("You inserted " + localSum);
}

Console.WriteLine("The total sum is " + totalSum);
}

//Snack4.Calcola la somma e la media dei numeri da 2 a 10.
{
Console.WriteLine("//");
Console.WriteLine("SNACK 4");
int totalSum = 0;
int iterCount = 0;
for (int i = 2; i < 11; i++)
{
totalSum = (totalSum + i);
iterCount = (iterCount + 1);
}

int media = (totalSum / iterCount);

Console.WriteLine("The totalSum is " + totalSum);
Console.WriteLine("The media is " + media);

}

//OPERATOR MODULE
//Snack5.Il software chiede all’utente di inserire un numero.Se il numero inserito è pari,stampa il numero, se è dispari, stampa il numero successivo.Array
{
Console.WriteLine("//");
Console.WriteLine("SNACK 5");

string answer;
Console.WriteLine("Insert a number:");
answer = Console.ReadLine();
int numGiven = Convert.ToInt32(answer);
int numGivenPlus = (numGiven + 1);

if (numGiven % 2 == 0)
{
Console.WriteLine("The number " + numGiven + " is even");
}
else
{
Console.WriteLine("The number " + numGiven + " is odd, the next even number " + numGivenPlus);
}

}
//Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.Chiedi all’utente il suo nome e comunicagli se può partecipare o meno allafesta.
{
Console.WriteLine("//");
Console.WriteLine("SNACK 6");

string[] guestList = { "marco", "andrea", "paolo", "luca", "anna", "lara", "valeria" };
string nameUser;
Console.WriteLine("What is your name?");
nameUser = Console.ReadLine();

if (guestList.Any(nameUser.Contains))
{
Console.WriteLine("Welcome to the party " + nameUser);
}
else
{
Console.WriteLine("You are not invited");
}
}
//Snack7.Crea un array vuoto.Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
{
Console.WriteLine("//");
Console.WriteLine("SNACK 7");

List<int> numList = new List<int>();

for (int i = 1; i < 7; i++)
{
string string1;
Console.WriteLine(i + ") Insert a number ");
string1 = Console.ReadLine();
int num1 = Convert.ToInt32(string1);

if (num1 % 2 != 0)
{
numList.Add(num1);
}
//convertrng back to array

}
int[] array = numList.ToArray();
//printing final array
Console.WriteLine("The Array contains");
array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
}

//Snack8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
{
    Console.WriteLine("//");
    Console.WriteLine("SNACK 7");

    int[] myArray = { 1, 2, 3, 4, 5, 6, };

    int totalSum = 0;

    for (int i=0; i<myArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            int localValue = myArray[i];
            Console.WriteLine("The number " + localValue + " is in the odd index of " + i);

            totalSum = (totalSum + localValue);
        }
    }

    Console.WriteLine("The Sum of all number in Odd index positionm is " + totalSum);


}


//WHILE CYCLE
//Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando lasomma degli elementi è minore di 50.Random
//Snack10.Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.