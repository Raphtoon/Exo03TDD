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
            if (word == "*")
                return Cities;
            if (word.Length >= 2)
            {
                string wordWithUpperStart = char.ToUpper(word[0]) + word.Substring(1);

                List<string> villesTrouvees = Cities.Where(c => c.StartsWith(wordWithUpperStart) || c.Contains(word)).ToList();
                return villesTrouvees;
            }
            else
                throw new NotFoundException();
        }
    }
}