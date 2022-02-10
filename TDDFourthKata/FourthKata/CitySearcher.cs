using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthKata
{
    public class CitySearcher : ICitySearcher
    {
        public List<string> CitySearch(string input)
        {
            if (input == "*") return CitiesList.CityList;
            if (input.Length <= 1) return new List<string>();
            var result = new List<string>();
            input = input.ToLower();
            foreach (string item in CitiesList.CityList)
            {
                if (item.ToLower().Contains(input))
                    result.Add(item);
            }

            return result;
        }
    }
}
