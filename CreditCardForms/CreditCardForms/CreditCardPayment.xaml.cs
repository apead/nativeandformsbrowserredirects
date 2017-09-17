using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditCardForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditCardPayment : ContentPage
    {
        public CreditCardPayment()
        {
            InitializeComponent();

            Browser.Navigating += Browser_Navigating;
            Browser.Navigated += Browser_Navigated;
            Browser.Source = "http://creditcardgatewayservice20170905011007.azurewebsites.net/";

        }

        private async void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (e.Url == null) return;

            if (e.Url.ToLower().Contains("success"))
            {
                Navigation.InsertPageBefore(new  CreditCardSuccess(), this);
                await Navigation.PopAsync();
            }
            else
            {
                if (!e.Url.ToLower().Contains("declined")) return;

                Navigation.InsertPageBefore(new CreditCardDeclined(), this);
                await Navigation.PopAsync();
            }
        }

        private void Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {

        }

    }
}