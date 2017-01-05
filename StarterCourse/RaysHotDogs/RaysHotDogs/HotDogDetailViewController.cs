using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotDogs
{
    public partial class HotDogDetailViewController : UIViewController
    {
		public HotDog SelectedHotDog { get; set; }

        public HotDogDetailViewController (IntPtr handle) : base (handle)
        {
			HotDogDataService hotDocDataService = new HotDogDataService();
			this.SelectedHotDog = hotDocDataService.GetHotDogById(1);
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			DatabindUI();

			AddToCartButton.TouchUpInside += (object sender, EventArgs e) =>
			{

				UIAlertView message = new UIAlertView("Ray's Hot Dogs", "That hot dog was added to your order", null, "OK", null);
				message.Show();

			};

			//CancelButton.TouchUpInside += (object sender, EventArgs e) =>
			//{
			//	//we'll come back this one later
			//};

		}

		private void DatabindUI()
		{
			UIImage img = UIImage.FromFile("Images/" + SelectedHotDog.ImagePath + ".jpg");
			HotDogImageView.Image = img;
			//NameLabel.Text = SelectedHotDog.Name;
			//ShortDescriptionLabel.Text = SelectedHotDog.ShortDescription;
			//LongDescriptionText.Text = SelectedHotDog.Description;
			//PriceLabel.Text = "$" + SelectedHotDog.Price.ToString();
		}
	}
}