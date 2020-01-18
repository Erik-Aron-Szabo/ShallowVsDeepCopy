using System;
using System.Collections.Generic;


namespace ShallowVsDeepCopy
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<string> CSI = new List<string>( new string[] {"Chicken", "Water", "Carrots", "Parsley", "Spices"});

            List<string> GCI = new List<string>(new string[] { "Cheese", "Bread" });

            List<string> HI = new List<string>(new string[] { "Ham", "Bread", "Cheese", "Lettuce", "Tomato"});

            List<string> BaBI = new List<string>(new string[] { "Banana", "Bread"});

            List<string> TI = new List<string>(new string[] { "Egg", "Bread" });
            //string TIs = string.Join(",", TI);
            //string CSIs = string.Join(",", CSI);
            //string GCIs = string.Join(",", GCI);
            //string BuBIs = string.Join(",", BuBI);
            //string BaBIs = string.Join(",", BaBI);
            Recipie chickenSoup = new Recipie("ChickenSoup", CSI);
            Console.WriteLine(string.Format(chickenSoup.Name + " Ingredients: {0}", 
                string.Join(", ", chickenSoup.Ingredients)));


            Recipie grillCheese = new Recipie("GrillCheese", GCI);
            Console.WriteLine(string.Format(grillCheese.Name + " Ingredients: {0}", 
                string.Join(", ", grillCheese.Ingredients)));


            Recipie hamburger = new Recipie("Hamburger", HI);
            Console.WriteLine(string.Format(hamburger.Name + " Ingredients: {0}", 
                string.Join(", ", hamburger.Ingredients)));


            Recipie bananaBread = new Recipie("BananaBread", BaBI);
            Console.WriteLine(string.Format(bananaBread.Name + " Ingredients: {0}", 
                string.Join(", ", bananaBread.Ingredients)));
            //foreach (var item in BaBI)
            //{
            //    Console.WriteLine("Ingredients: " + item);
            //}

            Recipie toast = new Recipie("Toast", TI);
            Console.WriteLine(string.Format(toast.Name + " Ingredients: {0}",
                string.Join(", ", bananaBread.Ingredients)));

            Recipie clone1 = (Recipie)chickenSoup.Clone();
            List<string> BSI = new List<string>(new string[] { "Beef", "Carrots", "Salt", "Vinegar", "Onion" });
            clone1.Name = "BeefStew";
            clone1.Ingredients = BSI;
            Console.WriteLine(string.Format(clone1.Name + " Ingredients: {0}",
                string.Join(", ", clone1.Ingredients)));

            Recipie clone2 = (Recipie)bananaBread.Clone();
            List<string> PI = new List<string>(new string[] { "Pork", "Anise", "Curry" });
            clone2.Ingredients = PI;
            clone2.Name = "Asian Pork";
            Console.WriteLine(string.Format(clone2.Name + " Ingredients: {0}",
                string.Join(", ", clone2.Ingredients)));

            Recipie clone3 = (Recipie)toast.Clone();
            Console.WriteLine(string.Format(clone3.Name + " Ingredients: {0}",
                string.Join(", ", clone3.Ingredients)));

        }   
    }
}
