namespace ProyectoII
{
    partial class fmrNombre1
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
            this.buttonGuardarNombre1 = new System.Windows.Forms.Button();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGuardarNombre1
            // 
            this.buttonGuardarNombre1.Location = new System.Drawing.Point(69, 102);
            this.buttonGuardarNombre1.Name = "buttonGuardarNombre1";
            this.buttonGuardarNombre1.Size = new System.Drawing.Size(163, 23);
            this.buttonGuardarNombre1.TabIndex = 1;
            this.buttonGuardarNombre1.Text = "Guardar";
            this.buttonGuardarNombre1.UseVisualStyleBackColor = true;
            this.buttonGuardarNombre1.Click += new System.EventHandler(this.buttonGuardarNombre1_Click);
            // 
            // textBoxName1
            // 
            this.textBoxName1.Location = new System.Drawing.Point(69, 59);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(163, 20);
            this.textBoxName1.TabIndex = 2;
            this.textBoxName1.TextChanged += new System.EventHandler(this.textBoxName1_TextChanged);
            // 
            // fmrNombre1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 193);
            this.Controls.Add(this.textBoxName1);
            this.Controls.Add(this.buttonGuardarNombre1);
            this.Name = "fmrNombre1";
            this.Text = "fmrNombre1";
            this.Load += new System.EventHandler(this.fmrNombre1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGuardarNombre1;
        private System.Windows.Forms.TextBox textBoxName1;
    }
}