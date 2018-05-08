
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
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using ExampleNavigation.Core.ViewModels;

namespace ExampleNavigation.Droid.Views
{
    [Activity(Label = "SecondActivity")]
	public class SecondActivity : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SecondView);

            // Create your application here
        }
    }
}
