
public class ReadAndWriteToJsonFile
{
    static string BuildJsonFilePath()
    {
        return "recipes.Json";
    }

     static string Format(List<string> listOfRecipes)
    {
        return string.Join(Environment.NewLine,listOfRecipes);
    }

    public static List<string> ReadFromJsonFile()
    {
        if (File.Exists(BuildJsonFilePath()))
        {
            var fileContents = File.ReadAllText(BuildJsonFilePath());
            var listOfRecipes = fileContents.Split(Environment.NewLine).ToList();
            return listOfRecipes;
        }
        return new List<string>();
    }

    public static void WriteToJsonFile(List<string> listOfRecipes)
    {
        File.WriteAllText(BuildJsonFilePath(), Format(listOfRecipes));
    }
}

