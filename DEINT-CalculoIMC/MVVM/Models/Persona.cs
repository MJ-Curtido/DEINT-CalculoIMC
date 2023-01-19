using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_MVVMDemo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Persona
    {
        public int altura { get; set; }
        public int peso { get; set; }
        public float imc { get; set; }

        public Persona()
        {

        }
    }
}
