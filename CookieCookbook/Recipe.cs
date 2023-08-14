using CookieCookbook.Ingredients;
using System.Text.Json;

public static class Recipe
{
    public static List<IIngredient> ingredientObjArray = new List<IIngredient> { new WheatFlour(), new CoconutFlour(), new Butter(), new Chocolate(),
new Sugar(), new Cardamom(), new Cinnamon(), new CocoaPowder()};
public static void PrintAvailableIngredients()
    {
        Console.WriteLine();
        var count = 1;
        foreach(var ingredient in ingredientObjArray) 
        {
            ingredient.PrintIngredient(count);
            count++;
        }
    }

    public static void CreatingRecipe(List<string> listOfRecipes)
    {
        var recipeIngredientList = new List<int>();
        var isRecipeFinished = false;
        while (!isRecipeFinished)
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if Finished.");
            var userInput = Console.ReadLine();
            var isInputParsable = int.TryParse(userInput, out var ingredientIndex);
            if (isInputParsable)
            {
                if (ingredientIndex >= 1 && ingredientIndex <= ingredientObjArray.Count)
                {
                    recipeIngredientList.Add(ingredientIndex);
                }
            }
            else
            {
                if (recipeIngredientList.Count > 0)
                {
                    isRecipeFinished = true;
                    Console.WriteLine("Recipe completed");
                }
                else
                {
                    Console.WriteLine("No Ingredient selected");
                    Console.WriteLine("The recipe cannot be saved");
                }
            }
        }
        AddRecipeToListOfRecipes(listOfRecipes, recipeIngredientList);
    }

    public static void AddRecipeToListOfRecipes(List<string> listOfRecipes, List<int>recipeIngredientList)
    {
        var recipe = JsonSerializer.Serialize(recipeIngredientList);
        listOfRecipes.Add(recipe);
        Console.WriteLine("\nThe following Recipe has been Added:");
        foreach (var item in recipeIngredientList)
        {
            Recipe.ingredientObjArray[item - 1].DisplayInstruction();
        }
    }
}

