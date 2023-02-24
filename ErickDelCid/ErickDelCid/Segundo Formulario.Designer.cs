namespace ErickDelCid
{
    partial class Segundo_Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // ProdutoTextBox
            // 
            this.ProdutoTextBox.Location = new System.Drawing.Point(167, 66);
            this.ProdutoTextBox.Name = "ProdutoTextBox";
            this.ProdutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProdutoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(167, 167);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(167, 105);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox.TabIndex = 4;
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(167, 131);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // Segundo_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProdutoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Segundo_Formulario";
            this.Text = "Segundo_Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdutoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label3;
    }
}