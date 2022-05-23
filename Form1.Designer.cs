namespace InchiriereAuto
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.masinaMea = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.progres = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // masinaMea
            // 
            this.masinaMea.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.masinaMea.Image = ((System.Drawing.Image)(resources.GetObject("masinaMea.Image")));
            this.masinaMea.ImageOffset = new System.Drawing.Point(0, 0);
            this.masinaMea.ImageRotate = 0F;
            this.masinaMea.ImageSize = new System.Drawing.Size(100, 100);
            this.masinaMea.Location = new System.Drawing.Point(51, 51);
            this.masinaMea.Name = "masinaMea";
            this.masinaMea.Size = new System.Drawing.Size(95, 98);
            this.masinaMea.TabIndex = 0;
            this.masinaMea.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged_1);
            // 
            // progres
            // 
            this.progres.BackColor = System.Drawing.Color.Red;
            this.progres.Controls.Add(this.masinaMea);
            this.progres.FillColor = System.Drawing.Color.Red;
            this.progres.FillOffset = 8;
            this.progres.FillThickness = 5;
            this.progres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progres.ForeColor = System.Drawing.Color.White;
            this.progres.Location = new System.Drawing.Point(312, 81);
            this.progres.Minimum = 0;
            this.progres.Name = "progres";
            this.progres.ProgressColor = System.Drawing.Color.Black;
            this.progres.ProgressColor2 = System.Drawing.Color.Black;
            this.progres.ProgressOffset = 10;
            this.progres.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progres.Size = new System.Drawing.Size(200, 200);
            this.progres.TabIndex = 1;
            this.progres.Text = "guna2CircleProgressBar1";
            this.progres.ValueChanged += new System.EventHandler(this.progres_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(248, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEM ÎNCHIRIERE AUTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "LUCIK CAR RENTAL";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progres);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.progres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox masinaMea;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

