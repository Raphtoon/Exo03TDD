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


        public List<string> SearchCityByName(string word)
        {
            if (word.Length >= 2)
            {
                List<String> villesTrouvees = new List<String>();
                foreach (string c in _cities)
                {
                    if (c.StartsWith(word))
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