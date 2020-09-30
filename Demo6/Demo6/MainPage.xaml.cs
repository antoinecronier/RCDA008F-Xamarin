using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Demo6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Get Metrics
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;

            Xamarin.Essentials.OrientationSensor.ReadingChanged += OrientationSensor_ReadingChanged;

            // Orientation (Landscape, Portrait, Square, Unknown)
            var orientation = mainDisplayInfo.Orientation;

            this.OrientationValue.Text = orientation.ToString();
        }

        private void OrientationSensor_ReadingChanged(object sender, OrientationSensorChangedEventArgs e)
        {
            this.OrientationValue.Text = DeviceDisplay.MainDisplayInfo.Orientation.ToString();
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            this.OrientationValue.Text = e.DisplayInfo.Orientation.ToString();
        }
    }
}
