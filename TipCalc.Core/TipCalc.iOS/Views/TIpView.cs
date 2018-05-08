using System;
using UIKit;
using TipCalc.Core.ViewModels;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Binding.BindingContext;

namespace TipCalc.iOS.Views
{
    // the inherit is used to link TipView to TipViewModel
    public partial class TIpView : MvxViewController<TipViewModel>
    {
        public TIpView() : base("TIpView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<TIpView, TipViewModel>();

            //In the following lines, we create the binding between the view and the view model.
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Bind(SubTotalTextField).To(vm => vm.SubTotal);
            set.Bind(GenerositySlider).To(vm => vm.Generosity);

            //Apply the changes
            set.Apply();

            // this is optional. What this code does is to close the keyboard whenever you 
            // tap on the screen, outside the bounds of the TextField
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.SubTotalTextField.ResignFirstResponder();
            }));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

