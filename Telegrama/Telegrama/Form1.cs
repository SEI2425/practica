namespace Telegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Matenme
        //pORFAsi

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txt.Text;

            // Determino el tipo de telegrama
            // Si el checkbox de urgente está marcado, se asigna 'u' a tipoTelegrama
            if (radUrg.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                // Solo asigna 'o' si no está urgente
                tipoTelegrama = 'o';
            }

            // Obtengo el número de palabras que forma el telegrama
            String[] palabras = textoTelegrama.Split(' '); //separa las palabras y las introduce en una estructura numPalabras = palabras.Length; //Obtiene la longitud de la estructura, que será el número de palabras.
            numPalabras = palabras.Length;

            // Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    // Se suma 2.5 por las primeras 10 palabras, y 0.5 por cada palabra adicional
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else if (tipoTelegrama == 'u')
            {
                // Telegrama urgente
                if (numPalabras > 10)
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
                else
                {
                    // Se suma 5 por las primeras 10 palabras, y 0.75 por cada palabra adicional
                    coste = 5;
                }
            }
            else
            {
                coste = 0; // Esto se ejecuta si tipoTelegrama no es 'o' ni 'u'
            }

            // Formateo del precio para mostrarlo con dos decimales
            txtPrecio.Text = coste.ToString("F2") + " euros";
        }

        private void chkUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
