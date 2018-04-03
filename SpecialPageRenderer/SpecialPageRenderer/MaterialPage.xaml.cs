using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpecialPageRenderer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MaterialPage : ContentPage
	{
		public MaterialPage ()
		{
			InitializeComponent ();
		}
	}
}