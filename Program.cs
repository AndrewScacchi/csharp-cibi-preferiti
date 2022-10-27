// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System;

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
    } else if (num1 < num2){
        Console.WriteLine(num2 + " is bigger than " + num1);
    }
    else
    {
        Console.WriteLine("They are the same number");
    }
}
//Snack2. L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga
{
    string word1;
    Console.WriteLine("Insert a word");
    word1= Console.ReadLine();

    string word2;
    Console.WriteLine("Insert another word");
    word2 = Console.ReadLine();

    if(word1.Length >= word2.Length)
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
//Snack4.Calcola la somma e la media dei numeri da 2 a 10.

//OPERATOR MODULE
//Snack5.Il software chiede all’utente di inserire un numero.Se il numero inserito è pari,stampa il numero, se è dispari, stampa il numero successivo.Array
//Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.Chiedi all’utente il suo nome e comunicagli se può partecipare o meno allafesta.
//Snack7.Crea un array vuoto.Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilonell’array.
//Snack8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono inposizione dispari.

//WHILE CYCLE
//Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando lasomma degli elementi è minore di 50.Random
//Snack10.Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.