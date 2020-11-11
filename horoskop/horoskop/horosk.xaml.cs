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
		Editor edi,sign;
		Image img;
		DateTime aries = new DateTime(21 / 03);
		DateTime ariesend = new DateTime(19 / 04);
		System.DateTime moment = new System.DateTime();
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
			StackLayout stack = new StackLayout { Children = {dateP, edi} };
			this.Content = stack;
		}

		private void DateP_DateSelected(object sender, DateChangedEventArgs e)
		{

			if (e.NewDate.Month>=3 && e.NewDate.Day <= 21 && e.NewDate.Month<=4 && e.NewDate.Day <= 19)
			{
				edi.Text = "asfdsadfdsf";
			}
			/*

			if (e.NewDate>=aries && e.NewDate<=ariesend)
			{
				edi.Text = "Aries";
			}

			edi.Text = e.NewDate.ToString("dd/MM");
			if (edi.Text>=("21/03"))
			{
				edi.Text = "Aries";
			}*/
			//edi.Text = e.NewDate.ToString("dd/MM");
			
		}
	}
}