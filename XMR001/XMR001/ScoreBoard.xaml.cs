using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace XMR001
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoreBoard : ContentPage
	{
		public ScoreBoard ()
		{
			InitializeComponent();
        }

        private void ContentPage_LayoutChanged(object sender, EventArgs e)
        {

        }
    }
}