using System;
using CoreGraphics;
using UIKit;

namespace Sample.iOS
{
	public class ModalViewController : UIViewController
	{
		public ModalViewController()
		{
			View.BackgroundColor = UIColor.Purple;
			this.EdgesForExtendedLayout = UIRectEdge.None;

			var buttonBack = UIButton.FromType(UIButtonType.System);
			buttonBack.SetTitle("Bouton retour", UIControlState.Normal);
			buttonBack.Frame = new CGRect(0, 20, View.Bounds.Width, 40);
			buttonBack.TouchUpInside += ButtonBack_TouchUpInside;
			this.View.AddSubview(buttonBack);
		}

		private void ButtonBack_TouchUpInside(object sender, EventArgs e)
		{
			this.DismissViewController(true, null);
		}
	}
}
