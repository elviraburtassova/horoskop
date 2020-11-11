using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace horoskop
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class horosk : ContentPage
	{
		DatePicker dateP;
		Editor edi;
		Image img;
		System.DateTime moment = new System.DateTime();
		int month = Value.Date.Day;
		int day = DateTime.Now.Day;
		public horosk()
		{
			dateP = new DatePicker
			{
				Format = "D",
				MaximumDate = DateTime.Now.AddYears(30),                                                                                                                                                                                                                            
				MinimumDate = DateTime.Now.AddYears(-90)
			};

			

			edi = new Editor
			{
				IsReadOnly = true
			};
			dateP.DateSelected += DateP_DateSelected;
			StackLayout stack = new StackLayout { Children = {dateP, edi } };
			this.Content = stack;
		}

		private void DateP_DateSelected(object sender, DateChangedEventArgs e)
		{
			if (month >= 3 && day >= 21 && month <= 4 && day <= 19)
			{
				edi.Text = "Aries";
			}
			else if (month >= 4 && day >= 20 && month <= 5 && day <= 20)
			{
				edi.Text = "Taurus";
			}
			//edi.Text = e.NewDate.ToString("dd/MM/yyyy");
		}
	}
}