using System;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views.Gestures;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using RestaurantBilling.Core.ViewModels;
using UIKit;

namespace RestaurantBilling.iOS.Views
{
    [MvxRootPresentation]
    public class MainMenuView : MvxViewController<MainMenuViewModel>
    {
        UIButton btnBill;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.btnBill = new UIButton();
            this.btnBill.SetTitle("Create bill", UIControlState.Normal);

            this.View.AddSubview(this.btnBill);

            this.View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            this.View.AddConstraints(
                this.btnBill.Height().EqualTo(100),
                this.btnBill.Width().EqualTo(150),
                this.btnBill.WithSameCenterX(this.View),
                this.btnBill.WithSameCenterY(this.View)
            );

            var set = this.CreateBindingSet<MainMenuView, MainMenuViewModel>();

            set.Bind(this.btnBill.Tap()).For(c => c.Command).To(vm => vm.NavigateCreateBillCommand);

            set.Apply();
        }
    }
}
