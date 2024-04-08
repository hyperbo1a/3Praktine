namespace _2prak
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
            ivestas_p = new TextBox();
            label1 = new Label();
            ivestas_q = new TextBox();
            label2 = new Label();
            ivestas_tekstas = new TextBox();
            label3 = new Label();
            Uzfifruotas_tekstas = new TextBox();
            label4 = new Label();
            atsifruotas_tekstas = new TextBox();
            label6 = new Label();
            sifruoti = new Button();
            atsifruot = new Button();
            SuspendLayout();
            // 
            // ivestas_p
            // 
            ivestas_p.Location = new Point(31, 144);
            ivestas_p.Name = "ivestas_p";
            ivestas_p.Size = new Size(199, 23);
            ivestas_p.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 116);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 3;
            label1.Text = "Iveskite q:";
            // 
            // ivestas_q
            // 
            ivestas_q.Location = new Point(31, 72);
            ivestas_q.Name = "ivestas_q";
            ivestas_q.Size = new Size(199, 23);
            ivestas_q.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 44);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 5;
            label2.Text = "Iveskite p:";
            // 
            // ivestas_tekstas
            // 
            ivestas_tekstas.Location = new Point(366, 72);
            ivestas_tekstas.Name = "ivestas_tekstas";
            ivestas_tekstas.Size = new Size(280, 23);
            ivestas_tekstas.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 44);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 7;
            label3.Text = "Iveskite teksta:";
            // 
            // Uzfifruotas_tekstas
            // 
            Uzfifruotas_tekstas.Location = new Point(366, 144);
            Uzfifruotas_tekstas.Name = "Uzfifruotas_tekstas";
            Uzfifruotas_tekstas.Size = new Size(280, 23);
            Uzfifruotas_tekstas.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(366, 116);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 9;
            label4.Text = "Uzfifruotas tekstas";
            // 
            // atsifruotas_tekstas
            // 
            atsifruotas_tekstas.Location = new Point(218, 219);
            atsifruotas_tekstas.Name = "atsifruotas_tekstas";
            atsifruotas_tekstas.Size = new Size(280, 23);
            atsifruotas_tekstas.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(218, 191);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 18;
            label6.Text = "Atsifruotas tekstas";
            // 
            // sifruoti
            // 
            sifruoti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sifruoti.Location = new Point(182, 277);
            sifruoti.Name = "sifruoti";
            sifruoti.Size = new Size(109, 30);
            sifruoti.TabIndex = 19;
            sifruoti.Text = "Sifruot";
            sifruoti.UseVisualStyleBackColor = true;
            sifruoti.Click += sifruoti_Click;
            // 
            // atsifruot
            // 
            atsifruot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atsifruot.Location = new Point(345, 277);
            atsifruot.Name = "atsifruot";
            atsifruot.Size = new Size(109, 30);
            atsifruot.TabIndex = 20;
            atsifruot.Text = "atsifruot";
            atsifruot.UseVisualStyleBackColor = true;
            atsifruot.Click += atsifruot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 347);
            Controls.Add(atsifruot);
            Controls.Add(sifruoti);
            Controls.Add(label6);
            Controls.Add(atsifruotas_tekstas);
            Controls.Add(label4);
            Controls.Add(Uzfifruotas_tekstas);
            Controls.Add(label3);
            Controls.Add(ivestas_tekstas);
            Controls.Add(label2);
            Controls.Add(ivestas_q);
            Controls.Add(label1);
            Controls.Add(ivestas_p);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ivestas_p;
        private Label label1;
        private TextBox ivestas_q;
        private Label label2;
        private TextBox ivestas_tekstas;
        private Label label3;
        private TextBox Uzfifruotas_tekstas;
        private Label label4;
        private TextBox atsifruotas_tekstas;
        private Label label6;
        private Button sifruoti;
        private Button atsifruot;
    }
}
