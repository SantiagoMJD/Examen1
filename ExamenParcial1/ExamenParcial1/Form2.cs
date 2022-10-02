using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ExamenParcial1
{
    public partial class Form2 : Form
    {
        //VARIABLES BOOL PARA MANDAR A FORM1 
        public bool cMexico { get; set; }
        public bool cEstadosUnidos { get; set; }
        public bool cCanada { get; set; }
        public bool cEuro { get; set; }
        public bool cJapon { get; set; }
        string seleMexico1{ get; set; }

        public Form2(string seleMexico)
        {
            InitializeComponent();
            lblseleMexico.Text=seleMexico;//label para almacenar txtMoneda que entra en form1 
            lblseleMexico.Visible = false;
            cMexico = false;
            cEstadosUnidos = false;
            cCanada = false;
            cEuro= false;
            cJapon= false;
            seleMexico1 = seleMexico;

            chMexico.Visible = false;
            chEstadosUnidos.Visible = false;
            chCanada.Visible = false;
            chEuro.Visible = false;
            chJapon.Visible = false; 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (chMexico.Checked == true)
            {

                cMexico = true;

            }
            else
            {
                cMexico = false;
            }
            if (chEstadosUnidos.Checked == true)
            {
                cEstadosUnidos = true;
            }
            else { 
                cEstadosUnidos = false;
            }
            
            if (chCanada.Checked == true)
            {
                cCanada = true;
            }
            else
            {
                cCanada = false;
            }
            if (chEuro.Checked == true)
            {
                cEuro = true;
            }
            else {
                cEuro = false; 
            }
            if (chJapon.Checked == true)
            {
                cJapon = true;
            }
            else
            {
                cJapon = false;
            }
            if (chMexico.Checked == false && chEstadosUnidos.Checked == false && chCanada.Checked == false && chEuro.Checked == false && chJapon.Checked == false)
            {
                MessageBox.Show("NO SELECCIONASTE CASILLAS");
            }
            else {
                DialogResult = DialogResult.OK;
                Close();
            }

            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (seleMexico1 == "MXN - Peso mexicano")
            {
                //chMexico.Visible = false;
                chEstadosUnidos.Visible = true;
                chCanada.Visible = true;
                chEuro.Visible = true;
                chJapon.Visible = true;

            }
            if (seleMexico1 == "USD - Dólar estadounidense"){
               // chEstadosUnidos.Visible = false;
                chCanada.Visible = true; 
                chMexico.Visible = true;
                chEuro.Visible = true;
                chJapon.Visible = true;
            }
            if (seleMexico1 == "CAD - Dólar canadiense")
            {
                //chCanada.Visible = false;
                chEstadosUnidos.Visible = true;
                chMexico.Visible = true;
                chEuro.Visible = true;
                chJapon.Visible = true;

            }
            if (seleMexico1 == "EUR - Euro")
            {
                chEstadosUnidos.Visible = true;
                chMexico.Visible = true;
                chJapon.Visible = true;
                chCanada.Visible = true;
               // chEuro.Visible = false;

            }
            if (seleMexico1== "JPY - Yen japonés")
            {
                chEstadosUnidos.Visible = true;
                chMexico.Visible = true;
                chEuro.Visible = true;
                chCanada.Visible = true;
               // chJapon.Visible = false;
            }


        }
    }
}
