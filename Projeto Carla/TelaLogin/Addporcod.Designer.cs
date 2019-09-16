namespace TelaLogin
{
    partial class Addporcod
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
            this.label2 = new System.Windows.Forms.Label();
            this.textcod = new System.Windows.Forms.TextBox();
            this.textquant = new System.Windows.Forms.TextBox();
            this.bcancela = new System.Windows.Forms.Button();
            this.bok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "quantidade:";
            // 
            // textcod
            // 
            this.textcod.Location = new System.Drawing.Point(131, 82);
            this.textcod.Name = "textcod";
            this.textcod.Size = new System.Drawing.Size(100, 20);
            this.textcod.TabIndex = 1;
            this.textcod.Text = "1";
            // 
            // textquant
            // 
            this.textquant.Location = new System.Drawing.Point(297, 79);
            this.textquant.Name = "textquant";
            this.textquant.Size = new System.Drawing.Size(100, 20);
            this.textquant.TabIndex = 2;
            this.textquant.Text = "1";
            // 
            // bcancela
            // 
            this.bcancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bcancela.Location = new System.Drawing.Point(147, 135);
            this.bcancela.Name = "bcancela";
            this.bcancela.Size = new System.Drawing.Size(75, 23);
            this.bcancela.TabIndex = 3;
            this.bcancela.Text = "Cancelar";
            this.bcancela.UseVisualStyleBackColor = true;
            this.bcancela.Click += new System.EventHandler(this.bcancela_Click);
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(240, 135);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(75, 23);
            this.bok.TabIndex = 4;
            this.bok.Text = "OK";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cadastro por código";
            // 
            // Addporcod
            // 
            this.AcceptButton = this.bok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.bcancela;
            this.ClientSize = new System.Drawing.Size(446, 241);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.bcancela);
            this.Controls.Add(this.textquant);
            this.Controls.Add(this.textcod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addporcod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicione um produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textcod;
        private System.Windows.Forms.TextBox textquant;
        private System.Windows.Forms.Button bcancela;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Label label3;
    }
}