using Demo_Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Demo_Day8_DB
{
    public static class WordExtensions
    {
        public static string GetSeries(this Word w)
        {
            string r = "";
            foreach(var part in w.Name.Split())
            {
                r += part + ".";
            }
            return r;
        }
    }
}
