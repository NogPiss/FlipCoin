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
            Random rnd = new Random();
            int indice = Convert.ToInt32(picker.SelectedIndex);
            int maxValue = 1;
            int RandonNumber = rnd.Next(maxValue);

            if (RandonNumber == 0) {
                LabelSorteio.Text = "cara";
            }
            if (RandonNumber == 1)
            {
                LabelSorteio.Text = "coroa";

            }

            if (indice == RandonNumber)
            {
                LabelResult.Text = "parabens você acertou";
            }
            else
            {
                LabelResult.Text = "Tá errado sabixao";

            }

        }
    }

}
