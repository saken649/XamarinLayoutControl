using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsoluteLayoutPage : ContentPage
	{
		public AbsoluteLayoutPage ()
		{
			InitializeComponent ();

            btnHrefToRelative.Clicked += (sender, e) =>
            {
                this.Navigation.PushAsync(new LayoutTest.RelativeLayoutPage());
            };
		}
	}
}