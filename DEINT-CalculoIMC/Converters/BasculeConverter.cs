using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_CalculoIMC.Converters
{
    public class BasculeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            float imc = (float)value;

            if (imc <= 16) { return "Delgadez severa"; }
            else if (imc <= 17) { return "Delgadez moderada"; }
            else if (imc <= 18.5) { return "Delgadez ligera"; }
            else if (imc <= 25) { return "Normal"; }
            else if (imc <= 30) { return "Sobrepeso"; }
            else if (imc <= 35) { return "Obesidad clase I"; }
            else if (imc <= 40) { return "Obesidad clase II"; }
            else { return "Obesidad clase III"; }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
