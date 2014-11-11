namespace Lab1_Shev
{
    partial class Lab1_Shev
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom_lab = new System.Windows.Forms.Label();
            this.nom_var = new System.Windows.Forms.Label();
            this.variant = new System.Windows.Forms.Label();
            this.TBa = new System.Windows.Forms.TextBox();
            this.TBb = new System.Windows.Forms.TextBox();
            this.LBa = new System.Windows.Forms.Label();
            this.LBb = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnEsc = new System.Windows.Forms.Button();
            this.PnRes = new System.Windows.Forms.Panel();
            this.LbRes = new System.Windows.Forms.Label();
            this.TbRes = new System.Windows.Forms.TextBox();
            this.PnRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nom_lab
            // 
            this.Nom_lab.AutoSize = true;
            this.Nom_lab.Location = new System.Drawing.Point(99, 9);
            this.Nom_lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom_lab.Name = "Nom_lab";
            this.Nom_lab.Size = new System.Drawing.Size(223, 22);
            this.Nom_lab.TabIndex = 0;
            this.Nom_lab.Text = "Лабораторная работа №1";
            // 
            // nom_var
            // 
            this.nom_var.AutoSize = true;
            this.nom_var.Location = new System.Drawing.Point(144, 43);
            this.nom_var.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_var.Name = "nom_var";
            this.nom_var.Size = new System.Drawing.Size(128, 22);
            this.nom_var.TabIndex = 1;
            this.nom_var.Text = "Вариант № 19";
            // 
            // variant
            // 
            this.variant.AutoSize = true;
            this.variant.Location = new System.Drawing.Point(176, 77);
            this.variant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.variant.Name = "variant";
            this.variant.Size = new System.Drawing.Size(69, 22);
            this.variant.TabIndex = 2;
            this.variant.Text = "a^2-b-5";
            // 
            // TBa
            // 
            this.TBa.Location = new System.Drawing.Point(71, 118);
            this.TBa.Name = "TBa";
            this.TBa.Size = new System.Drawing.Size(100, 28);
            this.TBa.TabIndex = 3;
            // 
            // TBb
            // 
            this.TBb.Location = new System.Drawing.Point(273, 118);
            this.TBb.Name = "TBb";
            this.TBb.Size = new System.Drawing.Size(100, 28);
            this.TBb.TabIndex = 4;
            // 
            // LBa
            // 
            this.LBa.AutoSize = true;
            this.LBa.Location = new System.Drawing.Point(34, 118);
            this.LBa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBa.Name = "LBa";
            this.LBa.Size = new System.Drawing.Size(30, 22);
            this.LBa.TabIndex = 5;
            this.LBa.Text = "a=";
            // 
            // LBb
            // 
            this.LBb.AutoSize = true;
            this.LBb.Location = new System.Drawing.Point(242, 118);
            this.LBb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBb.Name = "LBb";
            this.LBb.Size = new System.Drawing.Size(30, 22);
            this.LBb.TabIndex = 6;
            this.LBb.Text = "b=";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(71, 172);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(100, 32);
            this.BtnCalc.TabIndex = 7;
            this.BtnCalc.Text = "Вычисл.";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnEsc
            // 
            this.BtnEsc.Location = new System.Drawing.Point(273, 172);
            this.BtnEsc.Name = "BtnEsc";
            this.BtnEsc.Size = new System.Drawing.Size(100, 32);
            this.BtnEsc.TabIndex = 8;
            this.BtnEsc.Text = "Выход";
            this.BtnEsc.UseVisualStyleBackColor = true;
            this.BtnEsc.Click += new System.EventHandler(this.BtnEsc_Click);
            // 
            // PnRes
            // 
            this.PnRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnRes.Controls.Add(this.TbRes);
            this.PnRes.Controls.Add(this.LbRes);
            this.PnRes.Location = new System.Drawing.Point(71, 219);
            this.PnRes.Name = "PnRes";
            this.PnRes.Size = new System.Drawing.Size(302, 47);
            this.PnRes.TabIndex = 9;
            this.PnRes.Visible = false;
            // 
            // LbRes
            // 
            this.LbRes.AutoSize = true;
            this.LbRes.Location = new System.Drawing.Point(7, 11);
            this.LbRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbRes.Name = "LbRes";
            this.LbRes.Size = new System.Drawing.Size(115, 22);
            this.LbRes.TabIndex = 7;
            this.LbRes.Text = "Результат =";
            // 
            // TbRes
            // 
            this.TbRes.Location = new System.Drawing.Point(123, 8);
            this.TbRes.Name = "TbRes";
            this.TbRes.Size = new System.Drawing.Size(172, 28);
            this.TbRes.TabIndex = 8;
            // 
            // Lab1_Shev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Controls.Add(this.PnRes);
            this.Controls.Add(this.BtnEsc);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LBb);
            this.Controls.Add(this.LBa);
            this.Controls.Add(this.TBb);
            this.Controls.Add(this.TBa);
            this.Controls.Add(this.variant);
            this.Controls.Add(this.nom_var);
            this.Controls.Add(this.Nom_lab);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Lab1_Shev";
            this.Text = "Шевцов Юрий 611 пст";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnRes.ResumeLayout(false);
            this.PnRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom_lab;
        private System.Windows.Forms.Label nom_var;
        private System.Windows.Forms.Label variant;
        private System.Windows.Forms.TextBox TBa;
        private System.Windows.Forms.TextBox TBb;
        private System.Windows.Forms.Label LBa;
        private System.Windows.Forms.Label LBb;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnEsc;
        private System.Windows.Forms.Panel PnRes;
        private System.Windows.Forms.TextBox TbRes;
        private System.Windows.Forms.Label LbRes;
    }
}

