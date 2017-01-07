
using System;
using System.Collections.Generic;
using Foundation;
using RaysHotDogs.Core;
using UIKit;

namespace RaysHotDogs
{
	public class HotDogDataSource : UITableViewSource
	{
		private List<HotDog> hotDogs;
		NSString cellIdentifer = new NSString("HotDogCell");

		public HotDogDataSource(List<HotDog> hotDogs, UITableViewController callingController)
		{
			this.hotDogs = hotDogs;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifer);
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifer);
			}

			var hotDog = this.hotDogs[indexPath.Row];

			cell.TextLabel.Text = hotDog.Name;
			cell.ImageView.Image = UIImage.FromFile("Images/" + hotDog.ImagePath + ".jpg");

			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return this.hotDogs.Count;
		}
	}
}
