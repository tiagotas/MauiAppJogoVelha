namespace MauiAppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;
            
            disparador.IsEnabled = false;

            if(vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            } else
            {
                disparador.Text = "X";
                vez = "O";
            } // Fecha if

            // Verificando se o X ganhou na 1ª Linha
            if(btn10.Text == "X"
               && btn11.Text == "X" 
               && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                limpar();
            }

        } // Fecha Button_Clicked

        private void limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
        }

    } // Fecha a classe MainPage
} // Fecha o Namespace
