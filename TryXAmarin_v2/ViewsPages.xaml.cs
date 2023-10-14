using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryXAmarin_v2
{
    public partial class ViewsPages : ContentPage
    {
        public ViewsPages()
        {
            InitializeComponent();
        }

        private void DiversosViews_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ViewsPage.ViewsComponents_());
        }

        async void btnRotarTexto_Clicked(object sender, EventArgs e)
        {
            //await labelRotate.RotateTo(360, 1000);
        }
    }
}