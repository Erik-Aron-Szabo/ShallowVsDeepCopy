using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace ShallowVsDeepCopy
{
    class Recipie
    {

        //ADD random ID, which is unique amongst recipies

        //public int ID { get; set; }
        public string Name { get; set; }

        public List<string> Ingredients { get; set; }

   
            
        public override string ToString()
        {
            return String.Format("{0}: Ingredients: {1}, {2}", Name,  Ingredients[0], Ingredients[1]);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
         /*
        public Recipie(string name, IEnumerable<string> ingredients)
        {
            Name = name;
            this.Ingredients = ingredients.ToList();


        } */

        public Recipie(string name, List<string> ingredients)
        {
            Name = name;
            this.Ingredients = ingredients;
        }

        

    }

    

}
