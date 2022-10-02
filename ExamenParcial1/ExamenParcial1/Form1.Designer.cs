namespace ExamenParcial1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMoneda = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.gpConversiones = new System.Windows.Forms.GroupBox();
            this.txtJapon = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtEstadosUnidos = new System.Windows.Forms.TextBox();
            this.txtCanada = new System.Windows.Forms.TextBox();
            this.txtMexico = new System.Windows.Forms.TextBox();
            this.lblJapon1 = new System.Windows.Forms.Label();
            this.lblEuro1 = new System.Windows.Forms.Label();
            this.lblCanada1 = new System.Windows.Forms.Label();
            this.lblEstadosUnidos1 = new System.Windows.Forms.Label();
            this.lblMexico1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpConversiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMoneda
            // 
            this.txtMoneda.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtMoneda.FormattingEnabled = true;
            this.txtMoneda.Items.AddRange(new object[] {
            "MXN - Peso mexicano",
            "USD - Dólar estadounidense",
            "CAD - Dólar canadiense",
            "EUR - Euro",
            "JPY - Yen japonés"});
            this.txtMoneda.Location = new System.Drawing.Point(11, 30);
            this.txtMoneda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(187, 23);
            this.txtMoneda.TabIndex = 0;
            this.txtMoneda.SelectedIndexChanged += new System.EventHandler(this.txtMoneda_SelectedIndexChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(225, 30);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(112, 23);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMoneda.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMoneda.Image = global::ExamenParcial1.Properties.Resources.divisas_large;
            this.lblMoneda.Location = new System.Drawing.Point(11, 7);
            this.lblMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(57, 20);
            this.lblMoneda.TabIndex = 2;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMonto.Image = global::ExamenParcial1.Properties.Resources.divisas_large;
            this.lblMonto.Location = new System.Drawing.Point(225, 7);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 20);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // gpConversiones
            // 
            this.gpConversiones.BackColor = System.Drawing.Color.Lavender;
            this.gpConversiones.BackgroundImage = global::ExamenParcial1.Properties.Resources.ying_y_yang;
            this.gpConversiones.Controls.Add(this.txtJapon);
            this.gpConversiones.Controls.Add(this.txtEuro);
            this.gpConversiones.Controls.Add(this.txtEstadosUnidos);
            this.gpConversiones.Controls.Add(this.txtCanada);
            this.gpConversiones.Controls.Add(this.txtMexico);
            this.gpConversiones.Controls.Add(this.lblJapon1);
            this.gpConversiones.Controls.Add(this.lblEuro1);
            this.gpConversiones.Controls.Add(this.lblCanada1);
            this.gpConversiones.Controls.Add(this.lblEstadosUnidos1);
            this.gpConversiones.Controls.Add(this.lblMexico1);
            this.gpConversiones.ForeColor = System.Drawing.Color.Black;
            this.gpConversiones.Location = new System.Drawing.Point(11, 88);
            this.gpConversiones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpConversiones.Name = "gpConversiones";
            this.gpConversiones.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpConversiones.Size = new System.Drawing.Size(326, 196);
            this.gpConversiones.TabIndex = 4;
            this.gpConversiones.TabStop = false;
            this.gpConversiones.Text = "Conversiones";
            this.gpConversiones.Enter += new System.EventHandler(this.gpConversiones_Enter);
            // 
            // txtJapon
            // 
            this.txtJapon.Location = new System.Drawing.Point(172, 165);
            this.txtJapon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJapon.Name = "txtJapon";
            this.txtJapon.Size = new System.Drawing.Size(140, 23);
            this.txtJapon.TabIndex = 1;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(172, 132);
            this.txtEuro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(140, 23);
            this.txtEuro.TabIndex = 1;
            // 
            // txtEstadosUnidos
            // 
            this.txtEstadosUnidos.Location = new System.Drawing.Point(172, 60);
            this.txtEstadosUnidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstadosUnidos.Name = "txtEstadosUnidos";
            this.txtEstadosUnidos.Size = new System.Drawing.Size(140, 23);
            this.txtEstadosUnidos.TabIndex = 1;
            // 
            // txtCanada
            // 
            this.txtCanada.Location = new System.Drawing.Point(172, 97);
            this.txtCanada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCanada.Name = "txtCanada";
            this.txtCanada.Size = new System.Drawing.Size(140, 23);
            this.txtCanada.TabIndex = 1;
            // 
            // txtMexico
            // 
            this.txtMexico.Location = new System.Drawing.Point(172, 25);
            this.txtMexico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMexico.Name = "txtMexico";
            this.txtMexico.Size = new System.Drawing.Size(140, 23);
            this.txtMexico.TabIndex = 1;
            this.txtMexico.TextChanged += new System.EventHandler(this.txtMexico_TextChanged);
            // 
            // lblJapon1
            // 
            this.lblJapon1.AutoSize = true;
            this.lblJapon1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblJapon1.Location = new System.Drawing.Point(6, 173);
            this.lblJapon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJapon1.Name = "lblJapon1";
            this.lblJapon1.Size = new System.Drawing.Size(99, 15);
            this.lblJapon1.TabIndex = 0;
            this.lblJapon1.Text = "JPY - Yen japonés";
            // 
            // lblEuro1
            // 
            this.lblEuro1.AutoSize = true;
            this.lblEuro1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEuro1.Location = new System.Drawing.Point(6, 140);
            this.lblEuro1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuro1.Name = "lblEuro1";
            this.lblEuro1.Size = new System.Drawing.Size(63, 15);
            this.lblEuro1.TabIndex = 0;
            this.lblEuro1.Text = "EUR - Euro";
            // 
            // lblCanada1
            // 
            this.lblCanada1.AutoSize = true;
            this.lblCanada1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCanada1.Location = new System.Drawing.Point(6, 105);
            this.lblCanada1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanada1.Name = "lblCanada1";
            this.lblCanada1.Size = new System.Drawing.Size(130, 15);
            this.lblCanada1.TabIndex = 0;
            this.lblCanada1.Text = "CAD - Dólar canadiense";
            // 
            // lblEstadosUnidos1
            // 
            this.lblEstadosUnidos1.AutoSize = true;
            this.lblEstadosUnidos1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEstadosUnidos1.Location = new System.Drawing.Point(6, 67);
            this.lblEstadosUnidos1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadosUnidos1.Name = "lblEstadosUnidos1";
            this.lblEstadosUnidos1.Size = new System.Drawing.Size(154, 15);
            this.lblEstadosUnidos1.TabIndex = 0;
            this.lblEstadosUnidos1.Text = "USD - Dólar estadounidense";
            // 
            // lblMexico1
            // 
            this.lblMexico1.AutoSize = true;
            this.lblMexico1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMexico1.Location = new System.Drawing.Point(6, 33);
            this.lblMexico1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMexico1.Name = "lblMexico1";
            this.lblMexico1.Size = new System.Drawing.Size(121, 15);
            this.lblMexico1.TabIndex = 0;
            this.lblMexico1.Text = "MXN - Peso mexicano";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(232, 59);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::ExamenParcial1.Properties.Resources.divisas_large;
            this.ClientSize = new System.Drawing.Size(350, 295);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpConversiones);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtMoneda);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = " Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpConversiones.ResumeLayout(false);
            this.gpConversiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox txtMoneda;
        private TextBox txtMonto;
        private Label lblMoneda;
        private Label lblMonto;
        private GroupBox gpConversiones;
        private Button btnCalcular;
        private TextBox txtJapon;
        private TextBox txtEuro;
        private TextBox txtEstadosUnidos;
        private TextBox txtCanada;
        private TextBox txtMexico;
        private Label lblJapon1;
        private Label lblEuro1;
        private Label lblCanada1;
        private Label lblEstadosUnidos1;
        private Label lblMexico1;
    }
}