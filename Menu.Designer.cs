using System;
using System.Reflection;
namespace EnglishTest
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start_test = new System.Windows.Forms.Button();
            this.btn_edit_words = new System.Windows.Forms.Button();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Test";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_start_test
            // 
            this.btn_start_test.AutoSize = true;
            this.btn_start_test.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_start_test.Location = new System.Drawing.Point(3, 136);
            this.btn_start_test.Margin = new System.Windows.Forms.Padding(20);
            this.btn_start_test.Name = "btn_start_test";
            this.btn_start_test.Size = new System.Drawing.Size(528, 60);
            this.btn_start_test.TabIndex = 0;
            this.btn_start_test.Text = "התחל מבחן";
            this.btn_start_test.UseVisualStyleBackColor = true;
            this.btn_start_test.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_edit_words
            // 
            this.btn_edit_words.AutoSize = true;
            this.btn_edit_words.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edit_words.Location = new System.Drawing.Point(3, 76);
            this.btn_edit_words.Margin = new System.Windows.Forms.Padding(20);
            this.btn_edit_words.Name = "btn_edit_words";
            this.btn_edit_words.Size = new System.Drawing.Size(528, 60);
            this.btn_edit_words.TabIndex = 1;
            this.btn_edit_words.Text = "ערוך מילים";
            this.btn_edit_words.UseVisualStyleBackColor = true;
            this.btn_edit_words.Click += new System.EventHandler(this.btn_edit_words_Click);
            // 
            // btn_statistics
            // 
            this.btn_statistics.AutoSize = true;
            this.btn_statistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_statistics.Location = new System.Drawing.Point(3, 16);
            this.btn_statistics.Margin = new System.Windows.Forms.Padding(20);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(528, 60);
            this.btn_statistics.TabIndex = 2;
            this.btn_statistics.Text = "הצג סטטיטיקות";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 378);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_about);
            this.groupBox1.Controls.Add(this.btn_start_test);
            this.groupBox1.Controls.Add(this.btn_edit_words);
            this.groupBox1.Controls.Add(this.btn_statistics);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(534, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "תפריט";
            // 
            // btn_about
            // 
            this.btn_about.AutoSize = true;
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.Location = new System.Drawing.Point(3, 196);
            this.btn_about.Margin = new System.Windows.Forms.Padding(20);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(528, 60);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "אודות";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(534, 378);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(340, 370);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Test [By Yakir Avidan V1.8.0.0 ©]";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start_test;
        private System.Windows.Forms.Button btn_edit_words;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_about;
    }
}

