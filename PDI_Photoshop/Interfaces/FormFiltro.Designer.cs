namespace PDI_Photoshop.Interfaces
{
    partial class FormFiltro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbMediana = new System.Windows.Forms.RadioButton();
            this.rdbHighBoost = new System.Windows.Forms.RadioButton();
            this.rdbLaplaciano = new System.Windows.Forms.RadioButton();
            this.rdbGaussiano = new System.Windows.Forms.RadioButton();
            this.rdbMedia = new System.Windows.Forms.RadioButton();
            this.rdbGenerico = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAplFiltro = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdb9);
            this.panel3.Controls.Add(this.rdb7);
            this.panel3.Controls.Add(this.rdb5);
            this.panel3.Controls.Add(this.rdb3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 50);
            this.panel3.TabIndex = 1;
            // 
            // rdb9
            // 
            this.rdb9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb9.AutoSize = true;
            this.rdb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb9.Location = new System.Drawing.Point(548, 15);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(46, 20);
            this.rdb9.TabIndex = 0;
            this.rdb9.TabStop = true;
            this.rdb9.Text = "9x9";
            this.rdb9.UseVisualStyleBackColor = true;
            this.rdb9.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdb7
            // 
            this.rdb7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb7.AutoSize = true;
            this.rdb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb7.Location = new System.Drawing.Point(436, 15);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(46, 20);
            this.rdb7.TabIndex = 0;
            this.rdb7.TabStop = true;
            this.rdb7.Text = "7x7";
            this.rdb7.UseVisualStyleBackColor = true;
            this.rdb7.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdb5
            // 
            this.rdb5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb5.AutoSize = true;
            this.rdb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb5.Location = new System.Drawing.Point(324, 15);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(46, 20);
            this.rdb5.TabIndex = 0;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5x5";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.Location = new System.Drawing.Point(212, 15);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(46, 20);
            this.rdb3.TabIndex = 0;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3x3";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbMediana);
            this.panel2.Controls.Add(this.rdbHighBoost);
            this.panel2.Controls.Add(this.rdbLaplaciano);
            this.panel2.Controls.Add(this.rdbGaussiano);
            this.panel2.Controls.Add(this.rdbMedia);
            this.panel2.Controls.Add(this.rdbGenerico);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 50);
            this.panel2.TabIndex = 0;
            // 
            // rdbMediana
            // 
            this.rdbMediana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbMediana.AutoSize = true;
            this.rdbMediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMediana.Location = new System.Drawing.Point(601, 15);
            this.rdbMediana.Name = "rdbMediana";
            this.rdbMediana.Size = new System.Drawing.Size(79, 20);
            this.rdbMediana.TabIndex = 0;
            this.rdbMediana.TabStop = true;
            this.rdbMediana.Text = "Mediana";
            this.rdbMediana.UseVisualStyleBackColor = true;
            this.rdbMediana.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdbHighBoost
            // 
            this.rdbHighBoost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbHighBoost.AutoSize = true;
            this.rdbHighBoost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHighBoost.Location = new System.Drawing.Point(500, 15);
            this.rdbHighBoost.Name = "rdbHighBoost";
            this.rdbHighBoost.Size = new System.Drawing.Size(89, 20);
            this.rdbHighBoost.TabIndex = 0;
            this.rdbHighBoost.TabStop = true;
            this.rdbHighBoost.Text = "HighBoost";
            this.rdbHighBoost.UseVisualStyleBackColor = true;
            this.rdbHighBoost.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdbLaplaciano
            // 
            this.rdbLaplaciano.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbLaplaciano.AutoSize = true;
            this.rdbLaplaciano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLaplaciano.Location = new System.Drawing.Point(395, 15);
            this.rdbLaplaciano.Name = "rdbLaplaciano";
            this.rdbLaplaciano.Size = new System.Drawing.Size(93, 20);
            this.rdbLaplaciano.TabIndex = 0;
            this.rdbLaplaciano.TabStop = true;
            this.rdbLaplaciano.Text = "Laplaciano";
            this.rdbLaplaciano.UseVisualStyleBackColor = true;
            this.rdbLaplaciano.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdbGaussiano
            // 
            this.rdbGaussiano.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbGaussiano.AutoSize = true;
            this.rdbGaussiano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGaussiano.Location = new System.Drawing.Point(292, 15);
            this.rdbGaussiano.Name = "rdbGaussiano";
            this.rdbGaussiano.Size = new System.Drawing.Size(91, 20);
            this.rdbGaussiano.TabIndex = 0;
            this.rdbGaussiano.TabStop = true;
            this.rdbGaussiano.Text = "Gaussiano";
            this.rdbGaussiano.UseVisualStyleBackColor = true;
            this.rdbGaussiano.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdbMedia
            // 
            this.rdbMedia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbMedia.AutoSize = true;
            this.rdbMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedia.Location = new System.Drawing.Point(216, 15);
            this.rdbMedia.Name = "rdbMedia";
            this.rdbMedia.Size = new System.Drawing.Size(64, 20);
            this.rdbMedia.TabIndex = 0;
            this.rdbMedia.TabStop = true;
            this.rdbMedia.Text = "Média";
            this.rdbMedia.UseVisualStyleBackColor = true;
            this.rdbMedia.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // rdbGenerico
            // 
            this.rdbGenerico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbGenerico.AutoSize = true;
            this.rdbGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGenerico.Location = new System.Drawing.Point(126, 15);
            this.rdbGenerico.Name = "rdbGenerico";
            this.rdbGenerico.Size = new System.Drawing.Size(78, 20);
            this.rdbGenerico.TabIndex = 0;
            this.rdbGenerico.TabStop = true;
            this.rdbGenerico.Text = "Gerérico";
            this.rdbGenerico.UseVisualStyleBackColor = true;
            this.rdbGenerico.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAplFiltro);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 50);
            this.panel4.TabIndex = 1;
            // 
            // btnAplFiltro
            // 
            this.btnAplFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAplFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplFiltro.Location = new System.Drawing.Point(0, 0);
            this.btnAplFiltro.Name = "btnAplFiltro";
            this.btnAplFiltro.Size = new System.Drawing.Size(807, 50);
            this.btnAplFiltro.TabIndex = 0;
            this.btnAplFiltro.Text = "Aplicar Filtro";
            this.btnAplFiltro.UseVisualStyleBackColor = true;
            this.btnAplFiltro.Click += new System.EventHandler(this.BtnAplFiltro_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(935, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(807, 238);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // FormFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(807, 388);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFiltro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aplicar Filtro";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbMediana;
        private System.Windows.Forms.RadioButton rdbHighBoost;
        private System.Windows.Forms.RadioButton rdbLaplaciano;
        private System.Windows.Forms.RadioButton rdbGaussiano;
        private System.Windows.Forms.RadioButton rdbMedia;
        private System.Windows.Forms.RadioButton rdbGenerico;
        private System.Windows.Forms.RadioButton rdb9;
        private System.Windows.Forms.RadioButton rdb7;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAplFiltro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}