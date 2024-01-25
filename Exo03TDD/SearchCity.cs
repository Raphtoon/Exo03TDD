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
            throw new NotFoundException();
        }
    }
}