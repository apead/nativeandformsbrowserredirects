using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Support.V7.App;
using Android.Webkit;

namespace CreditCardNative.Droid
{
    [Activity(Label = "CreditCardPayment")]
    public class CreditCardPayment : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var webview = new WebView(this);
            var webviewClient = new InterceptWebview();
            webviewClient.Navigated += WebviewClient_Navigated;
            webview.SetWebViewClient(webviewClient);
            webview.LoadUrl("http://creditcardgatewayservice20170905011007.azurewebsites.net/");

            SetContentView(webview);

        }

        private void WebviewClient_Navigated(object sender, NavigatedEventArgs e)
        {
            if (e.Url == null) return;

            if (e.Url.ToLower().Contains("success"))
            {
                Intent intent = new Intent(this, typeof(CreditCardSuccessActivity));
                intent.AddFlags((Intent.Flags & ActivityFlags.ClearTop) | (Intent.Flags & ActivityFlags.ClearTask) | (Intent.Flags & ActivityFlags.NewTask));
                StartActivity(intent);
                Finish();
            }
            else
            {
                if (!e.Url.ToLower().Contains("declined")) return;

                Intent intent = new Intent(this, typeof(CreditCardDeclinedActivity));
                intent.AddFlags((Intent.Flags & ActivityFlags.ClearTop) | (Intent.Flags & ActivityFlags.ClearTask) | (Intent.Flags & ActivityFlags.NewTask));
                StartActivity(intent);
                Finish();
            }

        }
    }
}