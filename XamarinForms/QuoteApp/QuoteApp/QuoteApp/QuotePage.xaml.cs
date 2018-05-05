using QuoteApp.Quote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteApp
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotePage : ContentPage
	{
        Quotes quotes;

        public QuotePage ()
		{
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            quotes = new Quotes();
            quotes.GenerateQuote();
            BindingContext = quotes;
        }
    }

}