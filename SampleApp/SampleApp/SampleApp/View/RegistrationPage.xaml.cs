using SampleApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class RegistrationPage : ContentPage
    {
        RegistrationViewModel vm;
        List<string> Nations = new List<string> { "India", "USA", "China", "Malasia" };
        public RegistrationPage()
        {
            InitializeComponent();
            NationalityPicker.ItemsSource = Nations;
            vm = new RegistrationViewModel();
            BindingContext = vm;
            
        }
        

        private void NationalityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = NationalityPicker.Items[NationalityPicker.SelectedIndex];
            vm.AddToList(selectedCountry);
            StatesPicker.ItemsSource = vm.StateList;
           
            
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            vm.AddToLocalMemory();
            Navigation.PushAsync(new RegistrationDetails());
        }
    }
}