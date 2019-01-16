using CaseNotes1.Model;
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
	public partial class CasePage : ContentPage
	{
		public CasePage ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewCasePage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //var cases = await Case.Get("thinh.tran@housing.wa.gov.au");
            var cases = await Case.Get(App.user.userEmail);
            caseListView.ItemsSource = cases;
            caseListView.IsPullToRefreshEnabled = true;
        }

       


        private void OnMore(object sender, EventArgs e)
        {

        }

        private void OnDelete(object sender, EventArgs e)
        {

        }

        private void OnEdit(object sender, EventArgs e)
        {

        }
    }
}