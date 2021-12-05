
namespace Examen_Repo
{
    partial class Form3
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
            this.DatosListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RetrocederButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositoTextBox = new System.Windows.Forms.TextBox();
            this.DepositoButton = new System.Windows.Forms.Button();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatosListBox
            // 
            this.DatosListBox.FormattingEnabled = true;
            this.DatosListBox.ItemHeight = 16;
            this.DatosListBox.Location = new System.Drawing.Point(68, 204);
            this.DatosListBox.Name = "DatosListBox";
            this.DatosListBox.Size = new System.Drawing.Size(618, 276);
            this.DatosListBox.TabIndex = 0;
            this.DatosListBox.SelectedIndexChanged += new System.EventHandler(this.DatosListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLE DE MOVIMIENTOS DE CUENTA";
            // 
            // RetrocederButton
            // 
            this.RetrocederButton.Location = new System.Drawing.Point(68, 498);
            this.RetrocederButton.Name = "RetrocederButton";
            this.RetrocederButton.Size = new System.Drawing.Size(182, 75);
            this.RetrocederButton.TabIndex = 2;
            this.RetrocederButton.Text = "Retroceder";
            this.RetrocederButton.UseVisualStyleBackColor = true;
            this.RetrocederButton.Click += new System.EventHandler(this.RetrocederButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor del Deposito:";
            // 
            // DepositoTextBox
            // 
            this.DepositoTextBox.Location = new System.Drawing.Point(199, 136);
            this.DepositoTextBox.Name = "DepositoTextBox";
            this.DepositoTextBox.Size = new System.Drawing.Size(157, 22);
            this.DepositoTextBox.TabIndex = 4;
            // 
            // DepositoButton
            // 
            this.DepositoButton.Location = new System.Drawing.Point(393, 521);
            this.DepositoButton.Name = "DepositoButton";
            this.DepositoButton.Size = new System.Drawing.Size(160, 52);
            this.DepositoButton.TabIndex = 5;
            this.DepositoButton.Text = "Deposito";
            this.DepositoButton.UseVisualStyleBackColor = true;
            this.DepositoButton.Click += new System.EventHandler(this.DepositoButton_Click);
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(514, 139);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.Size = new System.Drawing.Size(157, 22);
            this.SaldoTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 604);
            this.Controls.Add(this.SaldoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepositoButton);
            this.Controls.Add(this.DepositoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetrocederButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosListBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DatosListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RetrocederButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepositoTextBox;
        private System.Windows.Forms.Button DepositoButton;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label label3;
    }
}