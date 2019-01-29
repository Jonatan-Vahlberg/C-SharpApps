namespace fAD
{
    partial class fAD
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
            this.uiText = new System.Windows.Forms.TextBox();
            this.calcText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equals = new System.Windows.Forms.Button();
            this.bu0 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.bu3 = new System.Windows.Forms.Button();
            this.bu2 = new System.Windows.Forms.Button();
            this.bu1 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.bu6 = new System.Windows.Forms.Button();
            this.bu5 = new System.Windows.Forms.Button();
            this.bu4 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.bu9 = new System.Windows.Forms.Button();
            this.bu8 = new System.Windows.Forms.Button();
            this.bu7 = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.erease = new System.Windows.Forms.Button();
            this.cc = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiText
            // 
            this.uiText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiText.Location = new System.Drawing.Point(15, 29);
            this.uiText.Name = "uiText";
            this.uiText.Size = new System.Drawing.Size(386, 20);
            this.uiText.TabIndex = 0;
            // 
            // calcText
            // 
            this.calcText.Location = new System.Drawing.Point(15, 74);
            this.calcText.Name = "calcText";
            this.calcText.Size = new System.Drawing.Size(386, 48);
            this.calcText.TabIndex = 1;
            this.calcText.Text = "Please enter equation and then press =";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.equals, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bu0, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dot, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.add, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.bu3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bu2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bu1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bu6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bu5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bu4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mult, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bu9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bu8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bu7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.divide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.erease, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ce, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.13423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.13423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.13423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.13423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.46309F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 346);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // equals
            // 
            this.equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equals.Location = new System.Drawing.Point(3, 279);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(89, 64);
            this.equals.TabIndex = 20;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // bu0
            // 
            this.bu0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu0.Location = new System.Drawing.Point(98, 279);
            this.bu0.Name = "bu0";
            this.bu0.Size = new System.Drawing.Size(89, 64);
            this.bu0.TabIndex = 17;
            this.bu0.Text = "0";
            this.bu0.UseVisualStyleBackColor = true;
            this.bu0.Click += new System.EventHandler(this.num_Click);
            // 
            // dot
            // 
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Location = new System.Drawing.Point(193, 279);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(89, 64);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.num_Click);
            // 
            // add
            // 
            this.add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add.Location = new System.Drawing.Point(288, 210);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 63);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.num_Click);
            // 
            // bu3
            // 
            this.bu3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu3.Location = new System.Drawing.Point(193, 210);
            this.bu3.Name = "bu3";
            this.bu3.Size = new System.Drawing.Size(89, 63);
            this.bu3.TabIndex = 14;
            this.bu3.Text = "3";
            this.bu3.UseVisualStyleBackColor = true;
            this.bu3.Click += new System.EventHandler(this.num_Click);
            // 
            // bu2
            // 
            this.bu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu2.Location = new System.Drawing.Point(98, 210);
            this.bu2.Name = "bu2";
            this.bu2.Size = new System.Drawing.Size(89, 63);
            this.bu2.TabIndex = 13;
            this.bu2.Text = "2";
            this.bu2.UseVisualStyleBackColor = true;
            this.bu2.Click += new System.EventHandler(this.num_Click);
            // 
            // bu1
            // 
            this.bu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu1.Location = new System.Drawing.Point(3, 210);
            this.bu1.Name = "bu1";
            this.bu1.Size = new System.Drawing.Size(89, 63);
            this.bu1.TabIndex = 12;
            this.bu1.Text = "1";
            this.bu1.UseVisualStyleBackColor = true;
            this.bu1.Click += new System.EventHandler(this.num_Click);
            // 
            // sub
            // 
            this.sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub.Location = new System.Drawing.Point(288, 141);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(90, 63);
            this.sub.TabIndex = 11;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.num_Click);
            // 
            // bu6
            // 
            this.bu6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu6.Location = new System.Drawing.Point(193, 141);
            this.bu6.Name = "bu6";
            this.bu6.Size = new System.Drawing.Size(89, 63);
            this.bu6.TabIndex = 10;
            this.bu6.Text = "6";
            this.bu6.UseVisualStyleBackColor = true;
            this.bu6.Click += new System.EventHandler(this.num_Click);
            // 
            // bu5
            // 
            this.bu5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu5.Location = new System.Drawing.Point(98, 141);
            this.bu5.Name = "bu5";
            this.bu5.Size = new System.Drawing.Size(89, 63);
            this.bu5.TabIndex = 9;
            this.bu5.Text = "5";
            this.bu5.UseVisualStyleBackColor = true;
            this.bu5.Click += new System.EventHandler(this.num_Click);
            // 
            // bu4
            // 
            this.bu4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu4.Location = new System.Drawing.Point(3, 141);
            this.bu4.Name = "bu4";
            this.bu4.Size = new System.Drawing.Size(89, 63);
            this.bu4.TabIndex = 8;
            this.bu4.Text = "4";
            this.bu4.UseVisualStyleBackColor = true;
            this.bu4.Click += new System.EventHandler(this.num_Click);
            // 
            // mult
            // 
            this.mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mult.Location = new System.Drawing.Point(288, 72);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(90, 63);
            this.mult.TabIndex = 7;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.num_Click);
            // 
            // bu9
            // 
            this.bu9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu9.Location = new System.Drawing.Point(193, 72);
            this.bu9.Name = "bu9";
            this.bu9.Size = new System.Drawing.Size(89, 63);
            this.bu9.TabIndex = 6;
            this.bu9.Text = "9";
            this.bu9.UseVisualStyleBackColor = true;
            this.bu9.Click += new System.EventHandler(this.num_Click);
            // 
            // bu8
            // 
            this.bu8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu8.Location = new System.Drawing.Point(98, 72);
            this.bu8.Name = "bu8";
            this.bu8.Size = new System.Drawing.Size(89, 63);
            this.bu8.TabIndex = 5;
            this.bu8.Text = "8";
            this.bu8.UseVisualStyleBackColor = true;
            this.bu8.Click += new System.EventHandler(this.num_Click);
            // 
            // bu7
            // 
            this.bu7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bu7.Location = new System.Drawing.Point(3, 72);
            this.bu7.Name = "bu7";
            this.bu7.Size = new System.Drawing.Size(89, 63);
            this.bu7.TabIndex = 4;
            this.bu7.Text = "7";
            this.bu7.UseVisualStyleBackColor = true;
            this.bu7.Click += new System.EventHandler(this.num_Click);
            // 
            // divide
            // 
            this.divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divide.Location = new System.Drawing.Point(288, 3);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(90, 63);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.num_Click);
            // 
            // erease
            // 
            this.erease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erease.Location = new System.Drawing.Point(193, 3);
            this.erease.Name = "erease";
            this.erease.Size = new System.Drawing.Size(89, 63);
            this.erease.TabIndex = 2;
            this.erease.Text = "<=";
            this.erease.UseVisualStyleBackColor = true;
            this.erease.Click += new System.EventHandler(this.erease_Click);
            // 
            // cc
            // 
            this.cc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cc.Location = new System.Drawing.Point(98, 3);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(89, 63);
            this.cc.TabIndex = 1;
            this.cc.Text = "C";
            this.cc.UseVisualStyleBackColor = true;
            this.cc.Click += new System.EventHandler(this.ce_Click);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ce.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ce.Location = new System.Drawing.Point(3, 3);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(89, 63);
            this.ce.TabIndex = 0;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // fAD
            // 
            this.AcceptButton = this.equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ce;
            this.ClientSize = new System.Drawing.Size(410, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.calcText);
            this.Controls.Add(this.uiText);
            this.Name = "fAD";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiText;
        private System.Windows.Forms.Label calcText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button bu3;
        private System.Windows.Forms.Button bu2;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button bu6;
        private System.Windows.Forms.Button bu5;
        private System.Windows.Forms.Button bu4;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button bu9;
        private System.Windows.Forms.Button bu8;
        private System.Windows.Forms.Button bu7;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button erease;
        private System.Windows.Forms.Button cc;
        private System.Windows.Forms.Button bu1;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button bu0;
        private System.Windows.Forms.Button dot;
    }
}

