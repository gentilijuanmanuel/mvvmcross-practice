
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.ViewModels;
using MvvmCross.Platforms.Android.Views;
using ExampleNavigation.Core.ViewModels;

namespace ExampleNavigation.Droid.Views
{
	[Activity(Label = "Ejemplo de navegación", MainLauncher = true)]
	public class FirstActivity : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.FirstView);
        }
    }
}
