﻿using PropertyChanged;
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
        public float imc
        {
            get
            {
                return peso / (float) (Math.Pow(((double) altura / 100.0), 2));
            }
        }

        public Persona()
        {

        }
    }
}
