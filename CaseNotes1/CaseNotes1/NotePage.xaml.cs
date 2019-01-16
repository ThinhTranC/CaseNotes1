using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CaseNotes1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotePage : ContentPage
	{
		public NotePage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewNotePage());
        }
    }
}