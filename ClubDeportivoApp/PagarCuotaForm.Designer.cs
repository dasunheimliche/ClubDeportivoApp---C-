namespace ClubDeportivoApp
{
    partial class PagarCuotaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarCuotaForm));
            this.textDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarjetaButton = new System.Windows.Forms.RadioButton();
            this.efectivoButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDni
            // 
            this.textDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDni.Location = new System.Drawing.Point(61, 112);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(201, 23);
            this.textDni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(62, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "PAGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tarjetaButton);
            this.groupBox1.Controls.Add(this.efectivoButton);
            this.groupBox1.Location = new System.Drawing.Point(62, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODO DE PAGO";
            // 
            // tarjetaButton
            // 
            this.tarjetaButton.AutoSize = true;
            this.tarjetaButton.Location = new System.Drawing.Point(6, 47);
            this.tarjetaButton.Name = "tarjetaButton";
            this.tarjetaButton.Size = new System.Drawing.Size(68, 19);
            this.tarjetaButton.TabIndex = 1;
            this.tarjetaButton.TabStop = true;
            this.tarjetaButton.Text = "TARJETA";
            this.tarjetaButton.UseVisualStyleBackColor = true;
            // 
            // efectivoButton
            // 
            this.efectivoButton.AutoSize = true;
            this.efectivoButton.Location = new System.Drawing.Point(6, 22);
            this.efectivoButton.Name = "efectivoButton";
            this.efectivoButton.Size = new System.Drawing.Size(76, 19);
            this.efectivoButton.TabIndex = 0;
            this.efectivoButton.TabStop = true;
            this.efectivoButton.Text = "EFECTIVO";
            this.efectivoButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PAGAR CUOTA";
            // 
            // PagarCuotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(324, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDni);
            this.Name = "PagarCuotaForm";
            this.Text = "PagarCuotaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tarjetaButton;
        private System.Windows.Forms.RadioButton efectivoButton;
        private System.Windows.Forms.Label label2;
    }
}