using System;
using Foundation;
using UIKit;
using WebKit;

namespace CreditCardNative.iOS
{
    public partial class CreditCardPaymentViewController : UIViewController, IWKScriptMessageHandler, IWKNavigationDelegate
    {
        public CreditCardPaymentViewController() : base("CreditCardPaymentViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var webView = new WKWebView(View.Frame, new WKWebViewConfiguration())
            {
                WeakNavigationDelegate = this
            };

            View.AddSubview(webView);

            var url = new NSUrl("http://creditcardgatewayservice20170905011007.azurewebsites.net/");
            var request = new NSUrlRequest(url);
            webView.LoadRequest(request);
        }

        public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
        {
            
        }

        [Export("webView:didFinishNavigation:")]
        public  void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
        {

            Console.WriteLine(webView.Url);
            /* example script handler
            webView.EvaluateJavaScript("callCsharp()", (result, error) =>
            {
                if (error != null) Console.WriteLine(error);
            });*/

            if (webView.Url == null) return;

            if (webView.Url.ToString().ToLower().Contains("success"))
            {
               NavigationController.PushViewController(new CreditCardSuccessViewController(), true);
               NavigationController.ViewControllers[1].RemoveFromParentViewController();
            }
            else
            {
                if (!webView.Url.ToString().ToLower().Contains("declined")) return;
                NavigationController.PushViewController(new CreditCardDeclinedViewController(), true);
                NavigationController.ViewControllers[1].RemoveFromParentViewController();
            }

        }
    }
}