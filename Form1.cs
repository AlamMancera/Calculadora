namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }        

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }
        
        private void btnCuatro_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";
        }        

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ".";
        }  

        private void btnSuma_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "÷";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "%";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnApertura_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "(";
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ")";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "" + "0";
        }
    }
}
