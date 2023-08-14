
using System.Text.Json;

public class ReadAndWriteToTextFile
{
    static string BuildTextFilePath()
    {
        return "recipes.txt";
    }

    static string Format(List<string> listOfRecipes)
    {
        var newTextListOfRecipes = new List<string>();
        foreach (var recipe in listOfRecipes)
        {
            var newArray = JsonSerializer.Deserialize<int[]>(recipe);
            var stringOfRecipe = string.Join(',', newArray);
            newTextListOfRecipes.Add(stringOfRecipe);
        }
        return string.Join(Environment.NewLine, newTextListOfRecipes);
    }

    public static void WriteToTextFile(List<string> listOfRecipes)
    {
        
        File.WriteAllText(BuildTextFilePath(), Format(listOfRecipes));
        Console.WriteLine("\nRecipe saved to the text file");
    }
}

