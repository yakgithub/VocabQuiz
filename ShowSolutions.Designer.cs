namespace EnglishTest
{
    partial class ShowSolutions
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.score_text = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_replay = new System.Windows.Forms.Button();
            this.solutions_t = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutions_t)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.solutions_t);
            this.splitContainer1.Size = new System.Drawing.Size(544, 391);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(259, 391);
            this.splitContainer2.SplitterDistance = 271;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.score_text, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 271);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(68, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = ":הציון שלך";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // score_text
            // 
            this.score_text.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.score_text.AutoSize = true;
            this.score_text.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.score_text.Location = new System.Drawing.Point(115, 108);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(29, 33);
            this.score_text.TabIndex = 1;
            this.score_text.Text = "0";
            this.score_text.Click += new System.EventHandler(this.label2_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btn_back);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_replay);
            this.splitContainer3.Size = new System.Drawing.Size(259, 116);
            this.splitContainer3.SplitterDistance = 57;
            this.splitContainer3.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(259, 57);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "חזור לתפריט ראשי";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_replay
            // 
            this.btn_replay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_replay.Location = new System.Drawing.Point(0, 0);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(259, 55);
            this.btn_replay.TabIndex = 0;
            this.btn_replay.Text = "מבחן חזרה על טעויות";
            this.btn_replay.UseVisualStyleBackColor = true;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // solutions_t
            // 
            this.solutions_t.AllowUserToAddRows = false;
            this.solutions_t.AllowUserToDeleteRows = false;
            this.solutions_t.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.solutions_t.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.solutions_t.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutions_t.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.solutions_t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutions_t.Location = new System.Drawing.Point(0, 0);
            this.solutions_t.MultiSelect = false;
            this.solutions_t.Name = "solutions_t";
            this.solutions_t.ReadOnly = true;
            this.solutions_t.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.solutions_t.Size = new System.Drawing.Size(281, 391);
            this.solutions_t.TabIndex = 0;
            // 
            // Column1
            // 
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
            // ShowSolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(544, 391);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ShowSolutions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowSolutions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowSolutions_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.solutions_t)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView solutions_t;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_text;


    }
}