namespace ExamenParcial1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.chMexico = new System.Windows.Forms.CheckBox();
            this.chEstadosUnidos = new System.Windows.Forms.CheckBox();
            this.chCanada = new System.Windows.Forms.CheckBox();
            this.chEuro = new System.Windows.Forms.CheckBox();
            this.chJapon = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblseleMexico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chMexico
            // 
            this.chMexico.AutoSize = true;
            this.chMexico.BackColor = System.Drawing.Color.Turquoise;
            this.chMexico.Location = new System.Drawing.Point(24, 12);
            this.chMexico.Name = "chMexico";
            this.chMexico.Size = new System.Drawing.Size(144, 19);
            this.chMexico.TabIndex = 0;
            this.chMexico.Text = "MXN - Peso mexicano";
            this.chMexico.UseVisualStyleBackColor = false;
            // 
            // chEstadosUnidos
            // 
            this.chEstadosUnidos.AutoSize = true;
            this.chEstadosUnidos.BackColor = System.Drawing.Color.Turquoise;
            this.chEstadosUnidos.Location = new System.Drawing.Point(24, 37);
            this.chEstadosUnidos.Name = "chEstadosUnidos";
            this.chEstadosUnidos.Size = new System.Drawing.Size(176, 19);
            this.chEstadosUnidos.TabIndex = 0;
            this.chEstadosUnidos.Text = "USD - Dólar estadounidense";
            this.chEstadosUnidos.UseVisualStyleBackColor = false;
            // 
            // chCanada
            // 
            this.chCanada.AutoSize = true;
            this.chCanada.BackColor = System.Drawing.Color.Turquoise;
            this.chCanada.Location = new System.Drawing.Point(24, 62);
            this.chCanada.Name = "chCanada";
            this.chCanada.Size = new System.Drawing.Size(152, 19);
            this.chCanada.TabIndex = 0;
            this.chCanada.Text = "CAD - Dólar canadiense";
            this.chCanada.UseVisualStyleBackColor = false;
            // 
            // chEuro
            // 
            this.chEuro.AutoSize = true;
            this.chEuro.BackColor = System.Drawing.Color.Turquoise;
            this.chEuro.Location = new System.Drawing.Point(24, 87);
            this.chEuro.Name = "chEuro";
            this.chEuro.Size = new System.Drawing.Size(82, 19);
            this.chEuro.TabIndex = 0;
            this.chEuro.Text = "EUR - Euro";
            this.chEuro.UseVisualStyleBackColor = false;
            // 
            // chJapon
            // 
            this.chJapon.AutoSize = true;
            this.chJapon.BackColor = System.Drawing.Color.Turquoise;
            this.chJapon.Location = new System.Drawing.Point(24, 112);
            this.chJapon.Name = "chJapon";
            this.chJapon.Size = new System.Drawing.Size(119, 19);
            this.chJapon.TabIndex = 0;
            this.chJapon.Text = "JPY - Yen japonés";
            this.chJapon.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::ExamenParcial1.Properties.Resources.bolsa_de_dinero;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Image = global::ExamenParcial1.Properties.Resources.icons8_billetes_y_monedas_48;
            this.btnAceptar.Location = new System.Drawing.Point(24, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 38);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Image = global::ExamenParcial1.Properties.Resources.icons8_billetes_y_monedas_48;
            this.btnCancelar.Location = new System.Drawing.Point(120, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblseleMexico
            // 
            this.lblseleMexico.AutoSize = true;
            this.lblseleMexico.Location = new System.Drawing.Point(87, 190);
            this.lblseleMexico.Name = "lblseleMexico";
            this.lblseleMexico.Size = new System.Drawing.Size(0, 15);
            this.lblseleMexico.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ExamenParcial1.Properties.Resources.bolsa_de_dinero;
            this.ClientSize = new System.Drawing.Size(221, 203);
            this.Controls.Add(this.lblseleMexico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chJapon);
            this.Controls.Add(this.chEuro);
            this.Controls.Add(this.chCanada);
            this.Controls.Add(this.chEstadosUnidos);
            this.Controls.Add(this.chMexico);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chMexico;
        private CheckBox chEstadosUnidos;
        private CheckBox chCanada;
        private CheckBox chEuro;
        private CheckBox chJapon;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblseleMexico;
    }
}