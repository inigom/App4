using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App4
{
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}
        void PulsadoClick(object o, EventArgs e)
        {
    
            salida.Text = entrada.Text;
        }
        async void Navegara2(object o , EventArgs e)
        {
            await Navigation.PushAsync(new Page2(entrada.Text)); 
        }
        

    }
}
