using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthKata
{
    public interface ICitySearcher
    {
        List<string> CitySearch(string input);
    }
}
