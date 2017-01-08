using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotDogs
{
    public partial class HotDogTableViewController : UITableViewController
    {
		HotDogDataService hotDogDataService = new HotDogDataService();

        public HotDogTableViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			var hotDogs = this.hotDogDataService.GetAllHotDogs();
			HotDogDataSource dataSource = new HotDogDataSource(hotDogs, this);
			this.TableView.Source = dataSource;
			this.NavigationItem.Title = "Ray's Hot Dog Menu";
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "HotDogDetailSegue")
			{
				var hotDogDetailViewController = segue.DestinationViewController as HotDogDetailViewController;
				if (hotDogDetailViewController != null)
				{
					var source = TableView.Source as HotDogDataSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					hotDogDetailViewController.SelectedHotDog = item;
				}

			}

		}
    }
}