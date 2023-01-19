using DEINT_MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_CalculoIMC.MVVM.ViewModels
{
    public class PersonaViewModel
    {
        public Persona persona { get; set; }
        public PersonaViewModel()
        {
            persona = new Persona()
            {
                altura = 25,
                peso = 50,
                imc = 800
            };
        }
    }
}
