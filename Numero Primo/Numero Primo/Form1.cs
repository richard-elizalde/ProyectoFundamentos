namespace Numero_Primo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int.TryParse(nudNumero.Text, out int numero);

            int Contador = 0;

            for (int i = 1; i <= numero; i++)
            {


                if( numero % i == 0)
                {
                    Contador++;
                }
            }

             if (Contador != 2)

             {
                MessageBox.Show("El numero no es primo" , "aviso" ,MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
             }
            else
             {
                MessageBox.Show("El numero  es primo", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
