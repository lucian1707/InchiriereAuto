namespace InchiriereAuto
{
    partial class Masina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DisponibilCb = new System.Windows.Forms.ComboBox();
            this.PretTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MasinaDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ModelTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MarcaTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InmatriculareNrTb = new System.Windows.Forms.TextBox();
            this.CautareCb = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasinaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(773, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 34);
            this.button7.TabIndex = 12;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrare Masina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(248, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEM ÎNCHIRIERE AUTO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 24);
            this.panel2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(45, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Disponibil";
            // 
            // DisponibilCb
            // 
            this.DisponibilCb.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.DisponibilCb.FormattingEnabled = true;
            this.DisponibilCb.Items.AddRange(new object[] {
            "DA",
            "NU"});
            this.DisponibilCb.Location = new System.Drawing.Point(130, 267);
            this.DisponibilCb.Name = "DisponibilCb";
            this.DisponibilCb.Size = new System.Drawing.Size(137, 26);
            this.DisponibilCb.TabIndex = 45;
            // 
            // PretTb
            // 
            this.PretTb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PretTb.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold);
            this.PretTb.ForeColor = System.Drawing.Color.Black;
            this.PretTb.Location = new System.Drawing.Point(130, 226);
            this.PretTb.Name = "PretTb";
            this.PretTb.Size = new System.Drawing.Size(137, 26);
            this.PretTb.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(45, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(476, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Lista masini";
            // 
            // MasinaDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MasinaDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MasinaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MasinaDGV.BackgroundColor = System.Drawing.Color.White;
            this.MasinaDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MasinaDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MasinaDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasinaDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MasinaDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MasinaDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.MasinaDGV.EnableHeadersVisualStyles = false;
            this.MasinaDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MasinaDGV.Location = new System.Drawing.Point(337, 130);
            this.MasinaDGV.Name = "MasinaDGV";
            this.MasinaDGV.RowHeadersVisible = false;
            this.MasinaDGV.RowTemplate.Height = 25;
            this.MasinaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MasinaDGV.Size = new System.Drawing.Size(431, 271);
            this.MasinaDGV.TabIndex = 41;
            this.MasinaDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MasinaDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MasinaDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MasinaDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MasinaDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MasinaDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MasinaDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MasinaDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange;
            this.MasinaDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MasinaDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasinaDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MasinaDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MasinaDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.MasinaDGV.ThemeStyle.ReadOnly = false;
            this.MasinaDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.MasinaDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MasinaDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasinaDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MasinaDGV.ThemeStyle.RowsStyle.Height = 25;
            this.MasinaDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MasinaDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MasinaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MasinaDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(130, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 29);
            this.button4.TabIndex = 40;
            this.button4.Text = "Înapoi";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(201, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 29);
            this.button3.TabIndex = 39;
            this.button3.Text = "Șterge";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(130, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 29);
            this.button2.TabIndex = 38;
            this.button2.Text = "Editare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(57, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "Adaugă";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModelTb
            // 
            this.ModelTb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ModelTb.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold);
            this.ModelTb.ForeColor = System.Drawing.Color.Black;
            this.ModelTb.Location = new System.Drawing.Point(130, 194);
            this.ModelTb.Name = "ModelTb";
            this.ModelTb.Size = new System.Drawing.Size(137, 26);
            this.ModelTb.TabIndex = 36;
            this.ModelTb.TextChanged += new System.EventHandler(this.ModelTb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Model";
            // 
            // MarcaTb
            // 
            this.MarcaTb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MarcaTb.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold);
            this.MarcaTb.ForeColor = System.Drawing.Color.Black;
            this.MarcaTb.Location = new System.Drawing.Point(130, 162);
            this.MarcaTb.Name = "MarcaTb";
            this.MarcaTb.Size = new System.Drawing.Size(137, 26);
            this.MarcaTb.TabIndex = 34;
            this.MarcaTb.TextChanged += new System.EventHandler(this.MarcaTb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(45, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nr Masina";
            // 
            // InmatriculareNrTb
            // 
            this.InmatriculareNrTb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InmatriculareNrTb.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InmatriculareNrTb.ForeColor = System.Drawing.Color.Black;
            this.InmatriculareNrTb.Location = new System.Drawing.Point(130, 130);
            this.InmatriculareNrTb.Name = "InmatriculareNrTb";
            this.InmatriculareNrTb.Size = new System.Drawing.Size(137, 26);
            this.InmatriculareNrTb.TabIndex = 47;
            this.InmatriculareNrTb.TextChanged += new System.EventHandler(this.InmatriculareNrTb_TextChanged);
            // 
            // CautareCb
            // 
            this.CautareCb.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.CautareCb.FormattingEnabled = true;
            this.CautareCb.Items.AddRange(new object[] {
            "Disponibil\t",
            "Închiriat"});
            this.CautareCb.Location = new System.Drawing.Point(440, 89);
            this.CautareCb.Name = "CautareCb";
            this.CautareCb.Size = new System.Drawing.Size(137, 26);
            this.CautareCb.TabIndex = 48;
            this.CautareCb.SelectedIndexChanged += new System.EventHandler(this.CautareCb_SelectedIndexChanged);
            this.CautareCb.SelectionChangeCommitted += new System.EventHandler(this.CautareCb_SelectionChangeCommitted);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(576, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 26);
            this.button5.TabIndex = 49;
            this.button5.Text = "Refreș";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Masina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CautareCb);
            this.Controls.Add(this.InmatriculareNrTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DisponibilCb);
            this.Controls.Add(this.PretTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MasinaDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModelTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarcaTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Masina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masina";
            this.Load += new System.EventHandler(this.Masina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasinaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox DisponibilCb;
        private System.Windows.Forms.TextBox PretTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView MasinaDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ModelTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MarcaTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InmatriculareNrTb;
        private System.Windows.Forms.ComboBox CautareCb;
        private System.Windows.Forms.Button button5;
    }
}