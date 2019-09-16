namespace TelaLogin
{
    partial class Quantidade
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
            this.bok = new System.Windows.Forms.Button();
            this.bcancela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(182, 92);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(75, 23);
            this.bok.TabIndex = 0;
            this.bok.Text = "OK";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // bcancela
            // 
            this.bcancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bcancela.Location = new System.Drawing.Point(88, 92);
            this.bcancela.Name = "bcancela";
            this.bcancela.Size = new System.Drawing.Size(75, 23);
            this.bcancela.TabIndex = 0;
            this.bcancela.Text = "Cancelar";
            this.bcancela.UseVisualStyleBackColor = true;
            this.bcancela.Click += new System.EventHandler(this.bcancela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a quantidade desejada";
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(147, 53);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(44, 20);
            this.txtquant.TabIndex = 2;
            this.txtquant.Text = "1";
            this.txtquant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquant.TextChanged += new System.EventHandler(this.txtquant_TextChanged);
            // 
            // Quantidade
            // 
            this.AcceptButton = this.bok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bcancela;
            this.ClientSize = new System.Drawing.Size(342, 127);
            this.ControlBox = false;
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bcancela);
            this.Controls.Add(this.bok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Quantidade";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Button bcancela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquant;
    }
}