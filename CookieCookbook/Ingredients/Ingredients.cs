using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCookbook.Ingredients
{
    public interface IIngredient
    {
        public void PrintIngredient(int i);
        public void DisplayInstruction();
    }
    public class WheatFlour : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Wheat Flour");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Wheat Flour. Sieve. Add to other ingredients.");
        }
    }
    public class CoconutFlour : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Coconut Flour");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Coconut flour. Sieve. Add to other ingredients.");
        }
    }
    public class Butter : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Butter");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Butter. Melt on low heat. Add to other ingredients.");
        }
    }
    public class Chocolate : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Chocolate");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Chocolate. Melt in a water bath. Add to other ingredients.");
        }
    }
    public class Sugar : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Sugar");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Sugar. Add to other ingredients.");
        }
    }
    public class Cardamom : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Cardamom");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Cardamom. Take half a teaspoon. Add to other ingredients.");
        }
    }
    public class Cinnamon : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Cinnamon");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Cinnamon. Take half a teaspoon. Add to other ingredients.");
        }
    }
    public class CocoaPowder : IIngredient
    {
        public void PrintIngredient(int i)
        {
            Console.WriteLine($"{i}. Cocoa Powder");
        }
        public void DisplayInstruction()
        {
            Console.WriteLine("Cocoa Powder.  Add to other ingredients.");
        }
    }
}
