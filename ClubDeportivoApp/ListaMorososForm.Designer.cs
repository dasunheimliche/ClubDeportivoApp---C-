namespace ClubDeportivoApp
{
    partial class ListaMorososForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaMorososForm));
            this.morososGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.morososGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // morososGridView
            // 
            this.morososGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.morososGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.morososGridView.Location = new System.Drawing.Point(30, 95);
            this.morososGridView.Name = "morososGridView";
            this.morososGridView.RowTemplate.Height = 25;
            this.morososGridView.Size = new System.Drawing.Size(644, 452);
            this.morososGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOROSOS";
            // 
            // ListaMorososForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.morososGridView);
            this.Name = "ListaMorososForm";
            this.Text = "ListaMorososForm";
            this.Load += new System.EventHandler(this.ListaMorososForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.morososGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView morososGridView;
        private System.Windows.Forms.Label label1;
    }
}