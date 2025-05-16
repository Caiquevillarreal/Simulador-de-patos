namespace SimuladorPatosForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboPatos;
        private System.Windows.Forms.Button btnOuvirSom;
        private System.Windows.Forms.Label lblSom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboPatos = new System.Windows.Forms.ComboBox();
            this.btnOuvirSom = new System.Windows.Forms.Button();
            this.lblSom = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.comboPatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPatos.FormattingEnabled = true;
            this.comboPatos.Location = new System.Drawing.Point(30, 30);
            this.comboPatos.Name = "comboPatos";
            this.comboPatos.Size = new System.Drawing.Size(200, 21);

            this.btnOuvirSom.Location = new System.Drawing.Point(30, 70);
            this.btnOuvirSom.Name = "btnOuvirSom";
            this.btnOuvirSom.Size = new System.Drawing.Size(200, 30);
            this.btnOuvirSom.Text = "Ouvir Som";
            this.btnOuvirSom.UseVisualStyleBackColor = true;
            this.btnOuvirSom.Click += new System.EventHandler(this.btnOuvirSom_Click);

            this.lblSom.AutoSize = true;
            this.lblSom.Location = new System.Drawing.Point(30, 120);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(0, 13);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.comboPatos);
            this.Controls.Add(this.btnOuvirSom);
            this.Controls.Add(this.lblSom);
            this.Name = "Form1";
            this.Text = "Simulador de Patos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
