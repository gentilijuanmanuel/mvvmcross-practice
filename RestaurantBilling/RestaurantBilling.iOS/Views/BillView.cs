using System;
using UIKit;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Platforms.Ios.Views;
using RestaurantBilling.Core.ViewModels;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Binding.BindingContext;

namespace RestaurantBilling.iOS.Views
{
    [MvxModalPresentation(WrapInNavigationController = true, ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve)]
    public class BillView : MvxViewController<BillViewModel>
    {
        UILabel emailLabel, subtotalLabel, gratuityLabel, tipValueLabel, tipLabel, totalValueLabel, totalLabel;
        UITextField emailTextField, subtotalValueTextField;
        UISlider gratuitySlider;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //this.View.BackgroundColor = UIColor.Clear;

            this.Title = "BillingRestaurant";

            this.emailLabel = new UILabel
            {
                Text = "Email customer:",
                TextColor = UIColor.White
            };

            this.subtotalLabel = new UILabel
            {
                Text = "Subtotal:",
                TextColor = UIColor.White
            };

            this.gratuityLabel = new UILabel
            {
                Text = "Gratuity",
                TextColor = UIColor.White
            };

            this.subtotalValueTextField = new UITextField
            {
                Placeholder = "400",
                TextColor = UIColor.White
            };

            this.tipLabel = new UILabel
            {
                Text = "Tip:",
                TextColor = UIColor.White
            };

            this.totalLabel = new UILabel
            {
                Text = "Total:",
                TextColor = UIColor.White
            };

            this.emailTextField = new UITextField
            {
                Placeholder = "gentili@gmail.com",
                TextColor = UIColor.White
            };

            this.gratuitySlider = new UISlider
            {
                MaxValue = 100
            };

            this.tipValueLabel = new UILabel
            {
                TextColor = UIColor.White
            };

            this.totalValueLabel = new UILabel
            {
                TextColor = UIColor.White
            };

            this.View.AddSubviews(
                this.emailLabel,
                this.subtotalLabel,
                this.gratuityLabel,
                this.subtotalValueTextField,
                this.tipLabel,
                this.totalLabel,
                this.emailTextField,
                this.gratuitySlider,
                this.tipValueLabel,
                this.totalValueLabel
            );

            this.View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            this.View.AddConstraints(
                this.emailLabel.AtTopOf(this.View, 80f),
                this.emailLabel.WithSameLeft(this.View),
                this.emailLabel.WithSameRight(this.View),

                this.emailTextField.Below(this.emailLabel, 5f),
                this.emailTextField.WithSameLeft(this.View),
                this.emailTextField.WithSameRight(this.View),

                this.subtotalLabel.Below(this.emailTextField, 5f),
                this.subtotalLabel.WithSameLeft(this.View),
                this.subtotalLabel.WithSameRight(this.View),

                this.subtotalValueTextField.Below(this.subtotalLabel, 5f),
                this.subtotalValueTextField.WithSameLeft(this.View),
                this.subtotalValueTextField.WithSameRight(this.View),

                this.gratuityLabel.Below(this.subtotalValueTextField, 5f),
                this.gratuityLabel.WithSameLeft(this.View),
                this.gratuityLabel.WithSameRight(this.View),

                this.gratuitySlider.Below(this.gratuityLabel, 5f),
                this.gratuitySlider.WithSameLeft(this.View),
                this.gratuitySlider.WithSameRight(this.View),

                this.tipLabel.Below(this.gratuitySlider, 5f),
                this.tipLabel.WithSameLeft(this.View),
                this.tipLabel.WithSameRight(this.View),

                this.tipValueLabel.Below(this.tipLabel, 5f),
                this.tipValueLabel.WithSameLeft(this.View),
                this.tipValueLabel.WithSameRight(this.View),

                this.totalLabel.Below(this.tipValueLabel, 5f),
                this.totalLabel.WithSameLeft(this.View),
                this.totalLabel.WithSameRight(this.View),

                this.totalValueLabel.Below(this.totalLabel, 5f),
                this.totalValueLabel.WithSameLeft(this.View),
                this.totalValueLabel.WithSameRight(this.View)
            );

            var set = this.CreateBindingSet<BillView, BillViewModel>();

            set.Bind(this.emailTextField).To(vm => vm.CustomerEmail);
            set.Bind(this.subtotalValueTextField).To(vm => vm.SubTotal);
            set.Bind(this.gratuitySlider).To(vm => vm.Gratuity);
            set.Bind(this.tipValueLabel).To(vm => vm.Tip);
            set.Bind(this.totalValueLabel).To(vm => vm.Total);

            set.Apply();
        }
    }
}