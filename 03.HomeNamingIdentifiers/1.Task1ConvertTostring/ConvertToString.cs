using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Task1ConvertToString
{
    class ConvertToString
    {
        const int max_count = 6;

        internal class Converter
        {
            internal string BoolToString(bool value)
            {
                string valueAsString = value.ToString();
                return valueAsString;
            }
        }

        public static void Main()
        {
            Converter converter = new Converter();
            var trueBoolValueAsString = converter.BoolToString(true);
            Console.WriteLine(trueBoolValueAsString);
        }

    }
}


