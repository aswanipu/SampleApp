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
    public partial class RegistrationDetails : ContentPage
    {
        RegistrationDetailViewModel vm;
        public RegistrationDetails()
        {
            InitializeComponent();
            vm = new RegistrationDetailViewModel();
            BindingContext = vm;
        }
    }
}