using ShoppingCart.DependencyServices;
using ShoppingCart.ViewModels.Onboarding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCart.Views.Onboarding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LanguageSettings : ContentPage
    {
        public LanguageSettings()
        {
            InitializeComponent();
            BindingContext = new LanguageSettingsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var audServ = DependencyService.Get<IAudioPlayerService>();
          
            audServ.Play("1).3gpp");
        }
    }
}