namespace ClubDeportivoApp
{
    partial class PagarActForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarActForm));
            this.textDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarjetaButton = new System.Windows.Forms.RadioButton();
            this.efectivoButton = new System.Windows.Forms.RadioButton();
            this.pagarActButton = new System.Windows.Forms.Button();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(62, 127);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(207, 23);
            this.textDni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tarjetaButton);
            this.groupBox1.Controls.Add(this.efectivoButton);
            this.groupBox1.Location = new System.Drawing.Point(62, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FORMA DE PAGO";
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
            // pagarActButton
            // 
            this.pagarActButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pagarActButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pagarActButton.Location = new System.Drawing.Point(62, 342);
            this.pagarActButton.Name = "pagarActButton";
            this.pagarActButton.Size = new System.Drawing.Size(207, 46);
            this.pagarActButton.TabIndex = 3;
            this.pagarActButton.Text = "PAGAR";
            this.pagarActButton.UseVisualStyleBackColor = false;
            this.pagarActButton.Click += new System.EventHandler(this.pagarActButton_Click);
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(62, 185);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(207, 23);
            this.textMonto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MONTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "PAGAR ACTIVIDAD";
            // 
            // PagarActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(330, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMonto);
            this.Controls.Add(this.pagarActButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDni);
            this.Name = "PagarActForm";
            this.Text = "PagarActForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tarjetaButton;
        private System.Windows.Forms.RadioButton efectivoButton;
        private System.Windows.Forms.Button pagarActButton;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}