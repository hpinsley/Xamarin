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
			
        }
    }
}