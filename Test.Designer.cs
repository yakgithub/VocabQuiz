namespace EnglishTest
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.q_text = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ans_1 = new System.Windows.Forms.Button();
            this.ans_4 = new System.Windows.Forms.Button();
            this.ans_3 = new System.Windows.Forms.Button();
            this.ans_2 = new System.Windows.Forms.Button();
            this.q_num_label = new System.Windows.Forms.Label();
            this.btn_end = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // q_text
            // 
            this.q_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.q_text.AutoSize = true;
            this.q_text.Font = new System.Drawing.Font("Cooper Std Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_text.Location = new System.Drawing.Point(134, 16);
            this.q_text.Name = "q_text";
            this.q_text.Size = new System.Drawing.Size(248, 42);
            this.q_text.TabIndex = 1;
            this.q_text.Text = "English Test";
            this.q_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ans_1);
            this.groupBox1.Controls.Add(this.ans_4);
            this.groupBox1.Controls.Add(this.ans_3);
            this.groupBox1.Controls.Add(this.ans_2);
            this.groupBox1.Location = new System.Drawing.Point(40, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ans_1
            // 
            this.ans_1.Location = new System.Drawing.Point(53, 42);
            this.ans_1.Name = "ans_1";
            this.ans_1.Size = new System.Drawing.Size(176, 55);
            this.ans_1.TabIndex = 4;
            this.ans_1.Text = "button1";
            this.ans_1.UseVisualStyleBackColor = true;
            this.ans_1.Click += new System.EventHandler(this.ans_1_Click);
            // 
            // ans_4
            // 
            this.ans_4.Location = new System.Drawing.Point(306, 139);
            this.ans_4.Name = "ans_4";
            this.ans_4.Size = new System.Drawing.Size(176, 55);
            this.ans_4.TabIndex = 3;
            this.ans_4.Text = "button4";
            this.ans_4.UseVisualStyleBackColor = true;
            this.ans_4.Click += new System.EventHandler(this.ans_4_Click);
            // 
            // ans_3
            // 
            this.ans_3.Location = new System.Drawing.Point(53, 139);
            this.ans_3.Name = "ans_3";
            this.ans_3.Size = new System.Drawing.Size(176, 55);
            this.ans_3.TabIndex = 2;
            this.ans_3.Text = "button3";
            this.ans_3.UseVisualStyleBackColor = true;
            this.ans_3.Click += new System.EventHandler(this.ans_3_Click);
            // 
            // ans_2
            // 
            this.ans_2.Location = new System.Drawing.Point(306, 42);
            this.ans_2.Name = "ans_2";
            this.ans_2.Size = new System.Drawing.Size(176, 55);
            this.ans_2.TabIndex = 1;
            this.ans_2.Text = "button2";
            this.ans_2.UseVisualStyleBackColor = true;
            this.ans_2.Click += new System.EventHandler(this.ans_2_Click);
            // 
            // q_num_label
            // 
            this.q_num_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.q_num_label.AutoSize = true;
            this.q_num_label.Location = new System.Drawing.Point(34, 10);
            this.q_num_label.Name = "q_num_label";
            this.q_num_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.q_num_label.Size = new System.Drawing.Size(13, 13);
            this.q_num_label.TabIndex = 3;
            this.q_num_label.Text = "0";
            // 
            // btn_end
            // 
            this.btn_end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_end.Location = new System.Drawing.Point(3, 39);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "סיום מבחן";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 381);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.q_text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 74);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EnglishTest.Properties.Resources.Loudspeaker_GoodNeighbours;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_end, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.q_num_label, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(455, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(72, 68);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 420);
            this.MinimumSize = new System.Drawing.Size(620, 420);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test_FormClosing);
            this.Load += new System.EventHandler(this.Test_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ans_1;
        private System.Windows.Forms.Button ans_4;
        private System.Windows.Forms.Button ans_3;
        private System.Windows.Forms.Button ans_2;
        private System.Windows.Forms.Label q_num_label;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}