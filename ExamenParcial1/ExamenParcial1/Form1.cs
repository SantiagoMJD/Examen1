using Microsoft.VisualBasic;
using System.Drawing;

namespace ExamenParcial1
{
    public partial class Form1 : Form
    {
        public Conversor conversor { get; set; }
        public bool Mexico { get; set; } 
        public bool EstadosUnidos { get; set; }
        public bool Canada { get; set; }
        public bool Euro { get; set; }
        public bool Japon { get; set; }
  

        public Form1()
        {
            InitializeComponent();

            conversor = new Conversor();

            Mexico = false;
            EstadosUnidos = false;
            Canada = false;
            Euro = false;
            Japon = false;

            txtMexico.Visible = false;
            lblMexico1.Visible = false;

            txtEstadosUnidos.Visible = false;
            lblEstadosUnidos1.Visible = false;


            txtCanada.Visible = false;
            lblCanada1.Visible = false;

            txtEuro.Visible = false;
            lblEuro1.Visible = false;

            txtJapon.Visible = false;
            lblJapon1.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            //parametro txtMoneda para conocer el string que se envia en la opcion 1 


            //EVUALUAR VALORES INGRESADOS 
            Form2 form2 = new Form2(txtMoneda.Text);
            if (txtMoneda.Text == "" && txtMonto.Text ==""  )
            {
                MessageBox.Show("DEBES INGRESAR VALORES");
               
            }
            else if (txtMoneda.Text == "")
            {
                MessageBox.Show("DEBES INGRESAR MONEDA");
            }
            else if (txtMonto.Text == "")
            {
                MessageBox.Show("DEBES INGRESAR MONTO");
            }
            else {

                form2.ShowDialog();
                conversor.Monto = double.Parse(txtMonto.Text);

            }

            // asignamos valor bool a variables de form1 desde form2 (comunicacion entre formas)
            Mexico = form2.cMexico;
            EstadosUnidos = form2.cEstadosUnidos;
            Canada = form2.cCanada;
            Euro = form2.cEuro;
            Japon = form2.cJapon;
            //MOSTRAR O NO CAMPOS DE TEXTO Y LBL 
            txtMexico.Visible = Mexico;
            lblMexico1.Visible = Mexico;
            txtEstadosUnidos.Visible = EstadosUnidos;
            lblEstadosUnidos1.Visible = EstadosUnidos;
            txtCanada.Visible = Canada;
            lblCanada1.Visible = Canada;
            txtEuro.Visible = Euro;
            lblEuro1.Visible = Euro;
            txtJapon.Visible = Japon;
            lblJapon1.Visible = Japon;

            //IFS PARA HACER CALCULOS
            
            conversor.total = conversor.Monto;
            if (txtMoneda.SelectedIndex == 0)
            {
                txtEstadosUnidos.Text= "$" + (conversor.total*.05).ToString("0.##");
                txtCanada.Text= "$" + (conversor.total*.07).ToString("0.##");
                txtEuro.Text= "€"+(conversor.total*.05).ToString("0.##");
                txtJapon.Text = "¥ "+(conversor.total * 7.13).ToString("0.##");    
            }
            if (txtMoneda.SelectedIndex == 1) {
                //conversor.total = conversor.Monto;
                txtMexico.Text = "$"+(conversor.total * 20.25).ToString("0.##");
                txtCanada.Text = "$" + (conversor.total * 1.36).ToString("0.##");
                txtEuro.Text = "€"+(conversor.total * 1.03).ToString("0.##");
                txtJapon.Text = "¥ "+(conversor.total * 144.33).ToString("0.##");
            }
            if (txtMoneda.SelectedIndex == 2)
            {
               
                txtMexico.Text = "$" + (conversor.total * 14.84).ToString("0.##");
                txtEstadosUnidos.Text = "$"+(conversor.total * .73).ToString("0.##");
                txtEuro.Text = "€"+(conversor.total * .76).ToString("0.##");
                txtJapon.Text = "¥ "+(conversor.total * 105.74).ToString("0.##");
            }
            if (txtMoneda.SelectedIndex == 3)
            {
                
                txtMexico.Text = "$" + (conversor.total * 19.62).ToString("0.##");
                txtEstadosUnidos.Text = "$"+(conversor.total * .97).ToString("0.##");
                txtCanada.Text = "$" + (conversor.total * 1.32).ToString("0.##");
                txtJapon.Text = "¥ "+(conversor.total * 139.89).ToString("0.##");
            }
            if (txtMoneda.SelectedIndex == 4)
            {
                
                txtMexico.Text = "$"+(conversor.total *.14 ).ToString("0.##");
                txtEstadosUnidos.Text = "$"+(conversor.total * .01).ToString("0.##");
                txtCanada.Text = "$" + (conversor.total * .01).ToString("0.##");
                txtEuro.Text = "€"+(conversor.total * .01).ToString("0.##");
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gpConversiones_Enter(object sender, EventArgs e)
        {   
        }

        private void txtMexico_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255)||e.KeyChar == 47)
            {
                MessageBox.Show("SOLO SE ACEPTAN NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
    }
}