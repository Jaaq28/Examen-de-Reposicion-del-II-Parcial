
namespace Examen_Repo
{
    partial class Form1
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
            this.AgregarBbutton = new System.Windows.Forms.Button();
            this.MovimientoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgregarBbutton
            // 
            this.AgregarBbutton.Location = new System.Drawing.Point(76, 126);
            this.AgregarBbutton.Name = "AgregarBbutton";
            this.AgregarBbutton.Size = new System.Drawing.Size(191, 54);
            this.AgregarBbutton.TabIndex = 0;
            this.AgregarBbutton.Text = "Agregar Cuenta";
            this.AgregarBbutton.UseVisualStyleBackColor = true;
            this.AgregarBbutton.Click += new System.EventHandler(this.AgregarBbutton_Click);
            // 
            // MovimientoButton
            // 
            this.MovimientoButton.Location = new System.Drawing.Point(355, 126);
            this.MovimientoButton.Name = "MovimientoButton";
            this.MovimientoButton.Size = new System.Drawing.Size(191, 54);
            this.MovimientoButton.TabIndex = 1;
            this.MovimientoButton.Text = "Movimiento";
            this.MovimientoButton.UseVisualStyleBackColor = true;
            this.MovimientoButton.Click += new System.EventHandler(this.MovimientoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovimientoButton);
            this.Controls.Add(this.AgregarBbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarBbutton;
        private System.Windows.Forms.Button MovimientoButton;
        private System.Windows.Forms.Label label1;
    }
}