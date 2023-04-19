namespace calculator
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Equals = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Equals, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.Substract, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.Add, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Multiply, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.Three, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Two, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.One, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Divide, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Six, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Five, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Four, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Clear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Nine, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Eight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Seven, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Zero, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 111);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 427);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Equals
            // 
            this.Equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equals.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Equals.Location = new System.Drawing.Point(285, 321);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(90, 103);
            this.Equals.TabIndex = 15;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Substract
            // 
            this.Substract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Substract.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Substract.Location = new System.Drawing.Point(191, 321);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(88, 103);
            this.Substract.TabIndex = 14;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Add.Location = new System.Drawing.Point(3, 321);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(88, 103);
            this.Add.TabIndex = 13;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Multiply
            // 
            this.Multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Multiply.Location = new System.Drawing.Point(285, 215);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(90, 100);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Three
            // 
            this.Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Three.Location = new System.Drawing.Point(191, 215);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(88, 100);
            this.Three.TabIndex = 11;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Two
            // 
            this.Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Two.Location = new System.Drawing.Point(97, 215);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(88, 100);
            this.Two.TabIndex = 10;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Btn_Click);
            // 
            // One
            // 
            this.One.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.One.Location = new System.Drawing.Point(3, 215);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(88, 100);
            this.One.TabIndex = 9;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Divide
            // 
            this.Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Divide.Location = new System.Drawing.Point(285, 109);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(90, 100);
            this.Divide.TabIndex = 8;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Six
            // 
            this.Six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Six.Location = new System.Drawing.Point(191, 109);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(88, 100);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Five
            // 
            this.Five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Five.Location = new System.Drawing.Point(97, 109);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(88, 100);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Four
            // 
            this.Four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Four.Location = new System.Drawing.Point(3, 109);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(88, 100);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Clear
            // 
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Clear.Location = new System.Drawing.Point(285, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(90, 100);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "CLR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Nine
            // 
            this.Nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Nine.Location = new System.Drawing.Point(191, 3);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(88, 100);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Eight
            // 
            this.Eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Eight.Location = new System.Drawing.Point(97, 3);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(88, 100);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Seven
            // 
            this.Seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Seven.Location = new System.Drawing.Point(3, 3);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(88, 100);
            this.Seven.TabIndex = 1;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Zero
            // 
            this.Zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Zero.Location = new System.Drawing.Point(97, 321);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(88, 103);
            this.Zero.TabIndex = 0;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(378, 108);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Label label1;
    }
}

