namespace ClubDeportivoApp
{
    partial class ListarClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarClientesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.clientesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // clientesGridView
            // 
            this.clientesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesGridView.Location = new System.Drawing.Point(41, 127);
            this.clientesGridView.Name = "clientesGridView";
            this.clientesGridView.RowTemplate.Height = 25;
            this.clientesGridView.Size = new System.Drawing.Size(644, 389);
            this.clientesGridView.TabIndex = 1;
            // 
            // ListarClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 565);
            this.Controls.Add(this.clientesGridView);
            this.Controls.Add(this.label1);
            this.Name = "ListarClientesForm";
            this.Text = "ListarClientesForm";
            this.Load += new System.EventHandler(this.ListarClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView clientesGridView;
    }
}