﻿namespace OficinaMecanica
{
    partial class frmEstoque
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtOpcao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(95, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblOpcao.Location = new System.Drawing.Point(12, 87);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(136, 18);
            this.lblOpcao.TabIndex = 1;
            this.lblOpcao.Text = "Posição/Armazem:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNome.Location = new System.Drawing.Point(154, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 23);
            this.txtNome.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(128, 148);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(73, 25);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtOpcao
            // 
            this.txtOpcao.AutoSize = true;
            this.txtOpcao.Location = new System.Drawing.Point(154, 90);
            this.txtOpcao.Name = "txtOpcao";
            this.txtOpcao.Size = new System.Drawing.Size(15, 14);
            this.txtOpcao.TabIndex = 4;
            this.txtOpcao.UseVisualStyleBackColor = true;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(341, 208);
            this.Controls.Add(this.txtOpcao);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulário Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox txtOpcao;
    }
}