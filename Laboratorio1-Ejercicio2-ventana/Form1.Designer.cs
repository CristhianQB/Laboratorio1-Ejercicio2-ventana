namespace Laboratorio1_Ejercicio2_ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtb = new System.Windows.Forms.TextBox();
            lbl3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(110, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 28);
            label1.TabIndex = 0;
            label1.Text = "Minutos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(82, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 28);
            label2.TabIndex = 1;
            label2.Text = "Horas y Minutos";
            // 
            // txtb
            // 
            txtb.Location = new System.Drawing.Point(259, 48);
            txtb.Name = "txtb";
            txtb.Size = new System.Drawing.Size(104, 23);
            txtb.TabIndex = 2;
            txtb.TextChanged += txtb_TextChanged;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl3.Location = new System.Drawing.Point(282, 101);
            lbl3.Name = "lbl3";
            lbl3.Size = new System.Drawing.Size(32, 37);
            lbl3.TabIndex = 3;
            lbl3.Text = "0";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(185, 185);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(166, 47);
            button1.TabIndex = 4;
            button1.Text = "convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(507, 450);
            Controls.Add(button1);
            Controls.Add(lbl3);
            Controls.Add(txtb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button button1;
    }
}
