using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public ObservableCollection<CarouselItem> CarouselItems { get; set; }

        public Page2()
        {
            InitializeComponent();
            CarouselItems = new ObservableCollection<CarouselItem>()
        {
            new CarouselItem() {ImageSource = "Frame" },
            new CarouselItem() { ImageSource = "Frame" },
            new CarouselItem() { ImageSource = "Frame" }
        };

            BindingContext = this;
        }
    }
    public class CarouselItem
    {
        public string Title { get; set; }
        public string ImageSource { get; set; }
    }
}
        
        