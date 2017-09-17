using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace CreditCardNative.Droid
{
    public class InterceptWebview : WebViewClient
    {
        public event EventHandler<NavigatedEventArgs> Navigated;

        public override WebResourceResponse ShouldInterceptRequest(WebView view, IWebResourceRequest request)
        {
            return base.ShouldInterceptRequest(view, request);
        }

        public override void OnPageFinished(WebView view, string url)
        {
            var args = new NavigatedEventArgs(url);

            Navigated?.Invoke(this, args);

            base.OnPageFinished(view, url);
        }
    }
}