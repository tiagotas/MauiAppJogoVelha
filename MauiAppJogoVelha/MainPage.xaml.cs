﻿namespace MauiAppJogoVelha
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
        } // Fecha Button_Clicked

    } // Fecha a classe MainPage
} // Fecha o Namespace
