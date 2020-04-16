using ShoppingCart.Commands;
using ShoppingCart.Views.Onboarding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ShoppingCart.ViewModels.Onboarding
{
    public class LanguageSettingsViewModel : BaseViewModel
    {
        public LanguageSettingsViewModel()
        {
            SubmitCommand = new DelegateCommand(Submit);


        }
        public DelegateCommand SubmitCommand { get; set; }

        private string languageSelected;
        public string LanguageSelected
        {
            get => languageSelected; set
            {
                if (languageSelected == value) return;

                languageSelected = value;
                OnPropertyChanged();
            }
        }
        private async void Submit(object obj)
        {
            

            if (LanguageSelected == "Yoruba")
            {
                SetCultureToYoruba();
            }
            
           await Application.Current.MainPage.Navigation.PushAsync(new OnBoardingAnimationPage());
            

        }
        private void SetCultureToYoruba()
        {
            var yorubaCultureInfo = new CultureInfo("yo-NG");
            CultureInfo.DefaultThreadCurrentCulture = yorubaCultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = yorubaCultureInfo;
        }
    }
}
