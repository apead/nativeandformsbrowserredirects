using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CreditCardNative.Droid
{
    public class NavigatedEventArgs : EventArgs
    {
        public string Url { get; set; }

        public NavigatedEventArgs(string url)
        {
            Url = url;
        }
    }
}