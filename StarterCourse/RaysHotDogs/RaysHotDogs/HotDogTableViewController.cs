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
		}
    }
}