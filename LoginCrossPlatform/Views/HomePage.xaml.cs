﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoginCrossPlatform.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
         async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
