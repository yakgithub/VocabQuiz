namespace EnglishTest
{
    partial class WordsEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.words_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.new_rep_btn = new System.Windows.Forms.Button();
            this.delete_rep_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rep_box = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.words_num = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.words_table)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.splitContainer1.Size = new System.Drawing.Size(758, 374);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.words_table, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32076F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.67924F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 318);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // words_table
            // 
            this.words_table.AllowUserToAddRows = false;
            this.words_table.AllowUserToDeleteRows = false;
            this.words_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.words_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.words_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.words_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.words_table.Location = new System.Drawing.Point(3, 39);
            this.words_table.MultiSelect = false;
            this.words_table.Name = "words_table";
            this.words_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.words_table.Size = new System.Drawing.Size(752, 276);
            this.words_table.TabIndex = 0;
            this.words_table.KeyDown += new System.Windows.Forms.KeyEventHandler(this.words_table_KeyDown);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 100.1653F;
            this.Column1.HeaderText = "מילה";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.83472F;
            this.Column2.HeaderText = "פירוש";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(758, 36);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.new_rep_btn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.delete_rep_btn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(373, 30);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // new_rep_btn
            // 
            this.new_rep_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.new_rep_btn.Location = new System.Drawing.Point(3, 3);
            this.new_rep_btn.Name = "new_rep_btn";
            this.new_rep_btn.Size = new System.Drawing.Size(180, 24);
            this.new_rep_btn.TabIndex = 0;
            this.new_rep_btn.Text = "צור מאגר חדש";
            this.new_rep_btn.UseVisualStyleBackColor = true;
            this.new_rep_btn.Click += new System.EventHandler(this.new_rep_btn_Click);
            // 
            // delete_rep_btn
            // 
            this.delete_rep_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_rep_btn.Enabled = false;
            this.delete_rep_btn.Location = new System.Drawing.Point(189, 3);
            this.delete_rep_btn.Name = "delete_rep_btn";
            this.delete_rep_btn.Size = new System.Drawing.Size(181, 24);
            this.delete_rep_btn.TabIndex = 2;
            this.delete_rep_btn.Text = "מחק מאגר";
            this.delete_rep_btn.UseVisualStyleBackColor = true;
            this.delete_rep_btn.Click += new System.EventHandler(this.delete_rep_btn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.2118F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.7882F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.rep_box, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(382, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(373, 30);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ":מאגר";
            // 
            // rep_box
            // 
            this.rep_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rep_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rep_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rep_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rep_box.FormattingEnabled = true;
            this.rep_box.Location = new System.Drawing.Point(3, 3);
            this.rep_box.Name = "rep_box";
            this.rep_box.Size = new System.Drawing.Size(282, 24);
            this.rep_box.Sorted = true;
            this.rep_box.TabIndex = 1;
            this.rep_box.SelectedIndexChanged += new System.EventHandler(this.rep_box_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.add_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.delete_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.save_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.words_num, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_btn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_btn.Enabled = false;
            this.add_btn.Location = new System.Drawing.Point(381, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 36);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "הוספת מילה";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click_1);
            // 
            // delete_btn
            // 
            this.delete_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(255, 3);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 36);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "מחיקת שורה מסומנת";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_btn.Enabled = false;
            this.save_btn.Location = new System.Drawing.Point(129, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(120, 36);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "שמירה";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel_btn.Enabled = false;
            this.cancel_btn.Location = new System.Drawing.Point(3, 3);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(120, 36);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "ביטול";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click_1);
            // 
            // words_num
            // 
            this.words_num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.words_num.AutoSize = true;
            this.words_num.Location = new System.Drawing.Point(655, 14);
            this.words_num.Name = "words_num";
            this.words_num.Size = new System.Drawing.Size(78, 13);
            this.words_num.TabIndex = 0;
            this.words_num.Text = ":מילים במאגר";
            // 
            // search_btn
            // 
            this.search_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_btn.Enabled = false;
            this.search_btn.Location = new System.Drawing.Point(507, 3);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(120, 36);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "חפש מילה";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // WordsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 374);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "WordsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordsEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordsEditor_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.words_table)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView words_table;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label words_num;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rep_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button new_rep_btn;
        private System.Windows.Forms.Button delete_rep_btn;



    }
}