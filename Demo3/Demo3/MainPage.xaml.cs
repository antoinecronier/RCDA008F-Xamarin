using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btn.Clicked += Btn_Clicked;
            //this.btn.Clicked -= Btn_Clicked;
            this.doSmt.TextChanged += DoSmt_TextChanged;
            this.doSmt4.ValueChanged += DoSmt4_ValueChanged;
            this.doSmt5.ValueChanged += DoSmt5_ValueChanged;
        }

        private void DoSmt5_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.doSmt5Display.Text = e.NewValue.ToString();
        }

        private void DoSmt4_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.doSmt4Display.Text = e.NewValue.ToString();
        }

        private void DoSmt_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.doSmt2.Text = e.NewTextValue;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            this.resultPrint.Text = $"{this.doSmt.Text}  {this.doSmt2.Text}  {this.doSmt3.IsToggled.ToString()} {this.doSmt4.Value.ToString()} {this.doSmt5.Value.ToString()} {this.doSmt6.Date.ToString()} {this.doSmt7.Time.ToString()}";
        }
    }
}
