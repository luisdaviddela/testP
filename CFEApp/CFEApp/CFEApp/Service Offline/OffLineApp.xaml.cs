﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CFEApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OffLineApp : ContentPage
	{
		public OffLineApp ()
		{
			InitializeComponent ();
            BindingContext = new MainOfflineViewModel();
		}
	}
}