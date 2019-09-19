namespace PDI_Photoshop.Interfaces
{
    partial class FormEsteganografia
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
            this.aplEsteq = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstegR = new System.Windows.Forms.TextBox();
            this.txtEstegG = new System.Windows.Forms.TextBox();
            this.txtEstegB = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.aplEsteq);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // aplEsteq
            // 
            this.aplEsteq.AutoSize = true;
            this.aplEsteq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aplEsteq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aplEsteq.Location = new System.Drawing.Point(0, 0);
            this.aplEsteq.Margin = new System.Windows.Forms.Padding(10);
            this.aplEsteq.MinimumSize = new System.Drawing.Size(0, 30);
            this.aplEsteq.Name = "aplEsteq";
            this.aplEsteq.Size = new System.Drawing.Size(800, 30);
            this.aplEsteq.TabIndex = 0;
            this.aplEsteq.Text = "Aplicar Esteganografia";
            this.aplEsteq.UseVisualStyleBackColor = true;
            this.aplEsteq.Click += new System.EventHandler(this.AplEsteq_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 600);
            this.panel2.TabIndex = 1;
            // 
            // txtEstegR
            // 
            this.txtEstegR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstegR.ForeColor = System.Drawing.Color.Maroon;
            this.txtEstegR.Location = new System.Drawing.Point(0, 20);
            this.txtEstegR.Multiline = true;
            this.txtEstegR.Name = "txtEstegR";
            this.txtEstegR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstegR.Size = new System.Drawing.Size(800, 180);
            this.txtEstegR.TabIndex = 0;
            // 
            // txtEstegG
            // 
            this.txtEstegG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstegG.ForeColor = System.Drawing.Color.Green;
            this.txtEstegG.Location = new System.Drawing.Point(0, 20);
            this.txtEstegG.Multiline = true;
            this.txtEstegG.Name = "txtEstegG";
            this.txtEstegG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstegG.Size = new System.Drawing.Size(800, 180);
            this.txtEstegG.TabIndex = 0;
            // 
            // txtEstegB
            // 
            this.txtEstegB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEstegB.ForeColor = System.Drawing.Color.Navy;
            this.txtEstegB.Location = new System.Drawing.Point(0, 20);
            this.txtEstegB.Multiline = true;
            this.txtEstegB.Name = "txtEstegB";
            this.txtEstegB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEstegB.Size = new System.Drawing.Size(800, 178);
            this.txtEstegB.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtEstegR);
            this.splitContainer1.Panel1.Controls.Add(this.lblRed);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 600);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtEstegG);
            this.splitContainer2.Panel1.Controls.Add(this.lblGreen);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtEstegB);
            this.splitContainer2.Panel2.Controls.Add(this.lblBlue);
            this.splitContainer2.Size = new System.Drawing.Size(800, 399);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblRed
            // 
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(0, 0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(800, 20);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "Esteganografia do Vermelho";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(0, 0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(800, 20);
            this.lblGreen.TabIndex = 3;
            this.lblGreen.Text = "Esteganografia do Verde";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(0, 0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(800, 20);
            this.lblBlue.TabIndex = 4;
            this.lblBlue.Text = "Esteganografia do Azul";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEsteganografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEsteganografia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEsteganografia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aplEsteq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEstegB;
        private System.Windows.Forms.TextBox txtEstegG;
        private System.Windows.Forms.TextBox txtEstegR;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
    }
}