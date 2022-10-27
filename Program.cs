// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("//");

//Initializing Work

string[] myFoods = { "Lasagna", "Pizza", "Gelato", "Pizza all'Ananasso", "BurroFritto", "Ragu con Mayonese" };

// Length of Array
Console.WriteLine("You like " + myFoods.Length + " different foods");
Console.WriteLine("//");
// First position of Array
Console.WriteLine("First food is " + myFoods[0]);
Console.WriteLine("//");

// All food types
Console.WriteLine("All the foods are:");
for (int i = 0; i < myFoods.Length; i++)
{
    // ArrayIndex+1 + ArrayElement as string
    Console.WriteLine(" " + (i+1) + " - " + myFoods[i]);

    // If i == lengthArray - 1 then last item is
    if(i == (myFoods.Length - 1))
    {
        Console.WriteLine("//");
        Console.WriteLine("Last food is " + myFoods[i]);
    }
};

