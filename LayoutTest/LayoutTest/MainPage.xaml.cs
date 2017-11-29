﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnHrefToAbsolute.Clicked += (sender, e) =>
            {
                this.Navigation.PushAsync(new AbsoluteLayoutPage());
            };
		}
	}
}
