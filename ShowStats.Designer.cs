namespace EnglishTest
{
    partial class ShowStats
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
            this.stats_table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rep_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stats_table)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stats_table
            // 
            this.stats_table.AllowUserToAddRows = false;
            this.stats_table.AllowUserToDeleteRows = false;
            this.stats_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stats_table.BackgroundColor = System.Drawing.Color.Lavender;
            this.stats_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stats_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4});
            this.stats_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stats_table.GridColor = System.Drawing.SystemColors.ControlLight;
            this.stats_table.Location = new System.Drawing.Point(3, 30);
            this.stats_table.MultiSelect = false;
            this.stats_table.Name = "stats_table";
            this.stats_table.ReadOnly = true;
            this.stats_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stats_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.stats_table.Size = new System.Drawing.Size(642, 358);
            this.stats_table.TabIndex = 0;
            this.stats_table.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stats_table_KeyDown);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "מילה";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "פירוש";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "תשובות נכונות";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "תשובות שגויות";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "אחוזי הצלחה";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "הצלחות ברצף";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.stats_table, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rep_box, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.905371F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.09463F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 391);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.rep_box.Size = new System.Drawing.Size(642, 24);
            this.rep_box.TabIndex = 1;
            this.rep_box.SelectedIndexChanged += new System.EventHandler(this.rep_box_SelectedIndexChanged);
            // 
            // ShowStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "סטטיסטיקות";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowStats_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.stats_table)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stats_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox rep_box;


    }
}