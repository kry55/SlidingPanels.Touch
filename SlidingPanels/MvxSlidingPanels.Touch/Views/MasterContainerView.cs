using System;
using Cirrious.MvvmCross.Touch.Views;
using SlidingPanels.Lib;
using MonoTouch.UIKit;
using SlidingPanels.Lib.PanelContainers;
using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvxSlidingPanelsSample.Core.ViewModels;

namespace MvxSlidingPanels.Touch.Views
{
    public class MasterContainerView : MvxViewController
    {
		public override void ViewDidLoad()
		{
			View = new UIView(){ BackgroundColor = UIColor.White};
			base.ViewDidLoad();

			Title = "Master Container";

			var label = new UILabel(new RectangleF(10, 10, 300, 40));
			Add(label);

			var set = this.CreateBindingSet<MasterContainerView, MasterContainerViewModel>();
			set.Bind(label).To(vm => vm.DisplayName);
			set.Apply();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			NavigationController.NavigationBarHidden = true;
		}
    }
}
