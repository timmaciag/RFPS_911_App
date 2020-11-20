﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InCall : ContentPage
    {
        public InCall()
        {
            InitializeComponent();
        }

        private async void EndClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}