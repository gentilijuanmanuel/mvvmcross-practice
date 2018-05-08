using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using TipCalc.Core.ViewModels;

namespace TipCalc.Forms.UI.Pages
{
    public partial class TipView : MvxContentPage<TipViewModel>
    {
        public TipView()
        {
            InitializeComponent();
        }
    }
}
