using CookieCookbook.Ingredients;
using System.Text.Json;


var listOfRecipes = ReadAndWriteToJsonFile.ReadFromJsonFile();


if (listOfRecipes.Count > 0)
{
    for (int i = 0; i < listOfRecipes.Count; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"*****{i + 1}*****");
        foreach (int j in JsonSerializer.Deserialize<int[]>(listOfRecipes[i]))
        {
            Recipe.ingredientObjArray[j - 1].DisplayInstruction();
        }

    }
}

Recipe.PrintAvailableIngredients();
Recipe.CreatingRecipe(listOfRecipes);
ReadAndWriteToJsonFile.WriteToJsonFile(listOfRecipes);
ReadAndWriteToTextFile.WriteToTextFile(listOfRecipes);
Console.WriteLine("\nPress any key to exit");
Console.ReadKey();