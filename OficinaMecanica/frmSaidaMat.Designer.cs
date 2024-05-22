namespace OficinaMecanica
{
    partial class frmSaidaMat
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
            this.dgvSaidaMat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaidaMat
            // 
            this.dgvSaidaMat.AllowUserToAddRows = false;
            this.dgvSaidaMat.AllowUserToDeleteRows = false;
            this.dgvSaidaMat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvSaidaMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidaMat.Location = new System.Drawing.Point(12, 12);
            this.dgvSaidaMat.Name = "dgvSaidaMat";
            this.dgvSaidaMat.ReadOnly = true;
            this.dgvSaidaMat.Size = new System.Drawing.Size(627, 380);
            this.dgvSaidaMat.TabIndex = 12;
            // 
            // frmSaidaMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(651, 404);
            this.Controls.Add(this.dgvSaidaMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaidaMat";
            this.Text = "frmSaidaMat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaidaMat;
    }
}