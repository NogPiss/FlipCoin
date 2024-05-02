using Microsoft.UI.Xaml.Input;
using System.Numerics;

namespace coinflipper
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipperButton_Clicked(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(picker.SelectedIndex);
            int moeda = new Random().Next(2);

            if (moeda == 0) {
                ImageSorteio.Source = "cara.png";
            }
            if (moeda == 1)
            {
                ImageSorteio.Source = "coroa.png";
            }

            if (indice == moeda)
            {
                LabelResult.Text = "Parabéns você acertou";
            }
            else
            {
                LabelResult.Text = "Tá errado sabixao";

            }

        }
    }

}
