﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginCrossPlatform
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Console.WriteLine("artrebui aici sa aduci pagina cu pagina proiectul din partea cealalta. " +
                "Acum incerc sa fac o modificare in proiect si apoi s-o commitez");
        }
    }
}
