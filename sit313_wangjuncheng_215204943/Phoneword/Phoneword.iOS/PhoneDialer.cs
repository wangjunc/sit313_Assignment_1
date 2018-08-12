using Foundation;
using Phoneword.iOS;
using UIKit;
using Xamarin.Forms;

//This code will create the Dial method, which will be used on iOS platform to Dial the translated phone number:

[assembly: Dependency(typeof(PhoneDialer))]
namespace Phoneword.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}