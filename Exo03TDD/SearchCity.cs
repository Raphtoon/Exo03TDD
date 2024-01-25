using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo03TDD.Bibliotheque
{
    public class SearchCity
    {
        private List<string> _cities = new List<string>() { "Paris", " Budapest", " Skopje", " Rotterdam", " Valence", " Vancouver", " Amsterdam", " Vienne", " Sydney", " New York", " Londres", " Bangkok", " Hong Kong", " Dubaï", " Rome", " Istanbul" };

        public List<string> Cities { get => _cities; set => _cities = value; }

        public List<string> SearchCityByName(string word)
        {
            if (word.Length >= 2)
            {
                List<String> villesTrouvees = new List<String>();
                string wordWithUpperStart = word.Substring(0, 1).ToUpper() + word.Substring(1);
                foreach (string c in Cities)
                {
                    if (c.StartsWith(wordWithUpperStart) || c.Contains(word))
                    {
                        villesTrouvees.Add(c);
                    }
                }
                return villesTrouvees;
            }
            else
            throw new NotFoundException();  
        }
    }
}