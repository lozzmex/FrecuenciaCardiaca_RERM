

namespace FrecuenciaCardiaca_RERM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Latidos.Text))
            {
                int latidos = int.Parse(Latidos.Text);

                int frecuencia = latidos * 4;

                Frecuencia.Text = frecuencia.ToString();

                string resultado = "";

                if (frecuencia < 60)
                {
                    resultado = "Frecuencia cardiaca baja";
                }
                else if (frecuencia > 100)
                {
                    resultado = "Frecuencia cardiaca alta";
                }
                else
                {
                    resultado = "Frecuencia cardiaca normal";
                }

                DisplayAlert(
                    "Resultado",
                    resultado,
                    "Aceptar");
            }
            else
            {
                 DisplayAlert(
                    "Error",
                    "Por favor ingresa los latidos",
                    "Aceptar");
            }
        }
    }
}
