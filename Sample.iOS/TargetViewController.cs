using CoreGraphics;
using UIKit;

namespace Sample.iOS
{

    public class TargetViewController : UIViewController
    {
        private string _data;

        public TargetViewController()
        {
			this.View.BackgroundColor = UIColor.Orange;
            this.EdgesForExtendedLayout = UIRectEdge.None;
		
        }

        public void Initialize(string data)
        {
            _data = data;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			View.Add(Label);
        }

		private UILabel _label;
		public UILabel Label
		{
			get
			{
				if (_label == null)
				{
					_label = new UILabel();
					_label.Frame = new CGRect(10, 10, View.Bounds.Width, 40);
				}

				return _label;
			}
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			Label.Text = _data;
		}
    }

}
