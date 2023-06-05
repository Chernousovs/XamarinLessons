using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Slider = Xamarin.Forms.PlatformConfiguration.iOSSpecific.Slider;

namespace LearningX
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridPage : ContentPage
    {
        private Button greetButton;
        private StackLayout layout = new StackLayout();

        public GridPage()
        {
            InitializeComponent();

            //greetButton = new Button
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    Text = "Greet"
            //};

            //greetButton.Clicked += GreetButton_Clicked;
            //layout.Children.Add(greetButton);
            //Content = layout;


        }

        //private void GreetButton_Clicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Greet", "Hello Xam", "OK");
        //}

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            var value = e.NewValue;

            RotatingLabel.Rotation = value;
            SliderValue.Text = value.ToString();
            
        }
        
    }
}