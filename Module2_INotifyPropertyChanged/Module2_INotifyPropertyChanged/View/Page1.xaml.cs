using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2_INotifyPropertyChanged.ViewModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module2_INotifyPropertyChanged.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }
    }
}