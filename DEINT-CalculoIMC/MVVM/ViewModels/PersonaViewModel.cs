using DEINT_CalculoIMC;
using DEINT_MVVMDemo.MVVM.Models;
using System.Windows.Input;

namespace DEINT_MVVMDemo.MVVM.ViewModels
{
    public class PersonaViewModel
    {
        public Persona persona { get; set; }

        public PersonaViewModel()
        {
            persona = new Persona
            {
                altura = 25,
                peso = 50
            };
        }
    }
}
