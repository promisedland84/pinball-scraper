namespace Pinside
{
    partial class PinsideSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinsideSearch));
            this.lblGame = new System.Windows.Forms.Label();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.radioMarket = new System.Windows.Forms.RadioButton();
            this.radioForum = new System.Windows.Forms.RadioButton();
            this.dvGameResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.selectF14 = new System.Windows.Forms.PictureBox();
            this.selectSS = new System.Windows.Forms.PictureBox();
            this.selectPB = new System.Windows.Forms.PictureBox();
            this.selectRB = new System.Windows.Forms.PictureBox();
            this.selectBW = new System.Windows.Forms.PictureBox();
            this.selectTSPP = new System.Windows.Forms.PictureBox();
            this.selectEATPM = new System.Windows.Forms.PictureBox();
            this.picTSPP = new System.Windows.Forms.PictureBox();
            this.picPB = new System.Windows.Forms.PictureBox();
            this.picBW = new System.Windows.Forms.PictureBox();
            this.picF14 = new System.Windows.Forms.PictureBox();
            this.picRB = new System.Windows.Forms.PictureBox();
            this.picSS = new System.Windows.Forms.PictureBox();
            this.picEATPM = new System.Windows.Forms.PictureBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.listResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvGameResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectF14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTSPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEATPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTSPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picF14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEATPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(12, 25);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(209, 36);
            this.lblGame.TabIndex = 7;
            this.lblGame.Text = "Select a game:";
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchType.Location = new System.Drawing.Point(5, 289);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(345, 36);
            this.lblSearchType.TabIndex = 8;
            this.lblSearchType.Text = "Choose where to search:";
            // 
            // radioMarket
            // 
            this.radioMarket.AutoSize = true;
            this.radioMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMarket.Location = new System.Drawing.Point(521, 301);
            this.radioMarket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMarket.Name = "radioMarket";
            this.radioMarket.Size = new System.Drawing.Size(75, 22);
            this.radioMarket.TabIndex = 9;
            this.radioMarket.Text = "Market";
            this.radioMarket.UseVisualStyleBackColor = true;
            // 
            // radioForum
            // 
            this.radioForum.AutoSize = true;
            this.radioForum.Checked = true;
            this.radioForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioForum.Location = new System.Drawing.Point(429, 301);
            this.radioForum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioForum.Name = "radioForum";
            this.radioForum.Size = new System.Drawing.Size(73, 22);
            this.radioForum.TabIndex = 10;
            this.radioForum.TabStop = true;
            this.radioForum.Text = "Forum";
            this.radioForum.UseVisualStyleBackColor = true;
            // 
            // dvGameResults
            // 
            this.dvGameResults.AutoGenerateColumns = false;
            this.dvGameResults.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dvGameResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGameResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.gameDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn});
            this.dvGameResults.DataSource = this.listResultsBindingSource;
            this.dvGameResults.Location = new System.Drawing.Point(12, 357);
            this.dvGameResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvGameResults.Name = "dvGameResults";
            this.dvGameResults.RowTemplate.Height = 24;
            this.dvGameResults.Size = new System.Drawing.Size(1457, 344);
            this.dvGameResults.TabIndex = 11;
            this.dvGameResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvGameResults_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1120, 741);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 43);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(1256, 741);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 43);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // selectF14
            // 
            this.selectF14.BackColor = System.Drawing.Color.Transparent;
            this.selectF14.Enabled = false;
            this.selectF14.Image = global::Pinside.Properties.Resources.Check;
            this.selectF14.Location = new System.Drawing.Point(1267, -12);
            this.selectF14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectF14.Name = "selectF14";
            this.selectF14.Size = new System.Drawing.Size(150, 150);
            this.selectF14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectF14.TabIndex = 19;
            this.selectF14.TabStop = false;
            this.selectF14.Visible = false;
            this.selectF14.Click += new System.EventHandler(this.selectF14_Click);
            // 
            // selectSS
            // 
            this.selectSS.BackColor = System.Drawing.Color.Transparent;
            this.selectSS.Enabled = false;
            this.selectSS.Image = global::Pinside.Properties.Resources.Check;
            this.selectSS.Location = new System.Drawing.Point(1057, -12);
            this.selectSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectSS.Name = "selectSS";
            this.selectSS.Size = new System.Drawing.Size(150, 150);
            this.selectSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectSS.TabIndex = 18;
            this.selectSS.TabStop = false;
            this.selectSS.Visible = false;
            this.selectSS.Click += new System.EventHandler(this.selectSS_Click);
            // 
            // selectPB
            // 
            this.selectPB.BackColor = System.Drawing.Color.Transparent;
            this.selectPB.Enabled = false;
            this.selectPB.Image = global::Pinside.Properties.Resources.Check;
            this.selectPB.Location = new System.Drawing.Point(848, -12);
            this.selectPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectPB.Name = "selectPB";
            this.selectPB.Size = new System.Drawing.Size(150, 150);
            this.selectPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectPB.TabIndex = 17;
            this.selectPB.TabStop = false;
            this.selectPB.Visible = false;
            this.selectPB.Click += new System.EventHandler(this.selectPB_Click);
            // 
            // selectRB
            // 
            this.selectRB.BackColor = System.Drawing.Color.Transparent;
            this.selectRB.Enabled = false;
            this.selectRB.Image = global::Pinside.Properties.Resources.Check;
            this.selectRB.Location = new System.Drawing.Point(639, -12);
            this.selectRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectRB.Name = "selectRB";
            this.selectRB.Size = new System.Drawing.Size(150, 150);
            this.selectRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectRB.TabIndex = 16;
            this.selectRB.TabStop = false;
            this.selectRB.Visible = false;
            this.selectRB.Click += new System.EventHandler(this.selectRB_Click);
            // 
            // selectBW
            // 
            this.selectBW.BackColor = System.Drawing.Color.Transparent;
            this.selectBW.Enabled = false;
            this.selectBW.Image = global::Pinside.Properties.Resources.Check;
            this.selectBW.Location = new System.Drawing.Point(429, -12);
            this.selectBW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectBW.Name = "selectBW";
            this.selectBW.Size = new System.Drawing.Size(150, 150);
            this.selectBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectBW.TabIndex = 15;
            this.selectBW.TabStop = false;
            this.selectBW.Visible = false;
            this.selectBW.Click += new System.EventHandler(this.selectBW_Click);
            // 
            // selectTSPP
            // 
            this.selectTSPP.BackColor = System.Drawing.Color.Transparent;
            this.selectTSPP.Enabled = false;
            this.selectTSPP.Image = global::Pinside.Properties.Resources.Check;
            this.selectTSPP.Location = new System.Drawing.Point(221, -12);
            this.selectTSPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTSPP.Name = "selectTSPP";
            this.selectTSPP.Size = new System.Drawing.Size(150, 150);
            this.selectTSPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectTSPP.TabIndex = 14;
            this.selectTSPP.TabStop = false;
            this.selectTSPP.Visible = false;
            this.selectTSPP.Click += new System.EventHandler(this.selectTSPP_Click);
            // 
            // selectEATPM
            // 
            this.selectEATPM.BackColor = System.Drawing.Color.Transparent;
            this.selectEATPM.Enabled = false;
            this.selectEATPM.Image = global::Pinside.Properties.Resources.Check1;
            this.selectEATPM.Location = new System.Drawing.Point(12, -12);
            this.selectEATPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectEATPM.Name = "selectEATPM";
            this.selectEATPM.Size = new System.Drawing.Size(150, 150);
            this.selectEATPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selectEATPM.TabIndex = 13;
            this.selectEATPM.TabStop = false;
            this.selectEATPM.Visible = false;
            this.selectEATPM.Click += new System.EventHandler(this.selectEATPM_Click);
            // 
            // picTSPP
            // 
            this.picTSPP.Image = global::Pinside.Properties.Resources.TSPP;
            this.picTSPP.Location = new System.Drawing.Point(221, 64);
            this.picTSPP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTSPP.Name = "picTSPP";
            this.picTSPP.Size = new System.Drawing.Size(203, 203);
            this.picTSPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTSPP.TabIndex = 6;
            this.picTSPP.TabStop = false;
            this.picTSPP.Click += new System.EventHandler(this.picTSPP_Click);
            // 
            // picPB
            // 
            this.picPB.Image = global::Pinside.Properties.Resources.PB;
            this.picPB.Location = new System.Drawing.Point(848, 64);
            this.picPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPB.Name = "picPB";
            this.picPB.Size = new System.Drawing.Size(203, 206);
            this.picPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPB.TabIndex = 5;
            this.picPB.TabStop = false;
            this.picPB.Click += new System.EventHandler(this.picPB_Click);
            // 
            // picBW
            // 
            this.picBW.Image = global::Pinside.Properties.Resources.BW;
            this.picBW.Location = new System.Drawing.Point(429, 64);
            this.picBW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBW.Name = "picBW";
            this.picBW.Size = new System.Drawing.Size(203, 206);
            this.picBW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBW.TabIndex = 4;
            this.picBW.TabStop = false;
            this.picBW.Click += new System.EventHandler(this.picBW_Click);
            // 
            // picF14
            // 
            this.picF14.Image = global::Pinside.Properties.Resources.F14;
            this.picF14.Location = new System.Drawing.Point(1267, 64);
            this.picF14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picF14.Name = "picF14";
            this.picF14.Size = new System.Drawing.Size(203, 206);
            this.picF14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picF14.TabIndex = 3;
            this.picF14.TabStop = false;
            this.picF14.Click += new System.EventHandler(this.picF14_Click);
            // 
            // picRB
            // 
            this.picRB.Image = global::Pinside.Properties.Resources.R_B;
            this.picRB.Location = new System.Drawing.Point(639, 64);
            this.picRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRB.Name = "picRB";
            this.picRB.Size = new System.Drawing.Size(203, 206);
            this.picRB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRB.TabIndex = 2;
            this.picRB.TabStop = false;
            this.picRB.Click += new System.EventHandler(this.picRB_Click);
            // 
            // picSS
            // 
            this.picSS.Image = global::Pinside.Properties.Resources.SS;
            this.picSS.Location = new System.Drawing.Point(1057, 64);
            this.picSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSS.Name = "picSS";
            this.picSS.Size = new System.Drawing.Size(203, 206);
            this.picSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSS.TabIndex = 1;
            this.picSS.TabStop = false;
            this.picSS.Click += new System.EventHandler(this.picSS_Click);
            // 
            // picEATPM
            // 
            this.picEATPM.Image = global::Pinside.Properties.Resources.EATPM;
            this.picEATPM.Location = new System.Drawing.Point(12, 64);
            this.picEATPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picEATPM.Name = "picEATPM";
            this.picEATPM.Size = new System.Drawing.Size(203, 203);
            this.picEATPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEATPM.TabIndex = 0;
            this.picEATPM.TabStop = false;
            this.picEATPM.Click += new System.EventHandler(this.picEATPM_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 64;
            // 
            // gameDataGridViewTextBoxColumn
            // 
            this.gameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gameDataGridViewTextBoxColumn.DataPropertyName = "Game";
            this.gameDataGridViewTextBoxColumn.HeaderText = "Game";
            this.gameDataGridViewTextBoxColumn.Name = "gameDataGridViewTextBoxColumn";
            this.gameDataGridViewTextBoxColumn.Width = 75;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linkDataGridViewTextBoxColumn.Width = 63;
            // 
            // listResultsBindingSource
            // 
            this.listResultsBindingSource.DataSource = typeof(Pinside.listResults);
            // 
            // PinsideSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1479, 797);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.selectF14);
            this.Controls.Add(this.selectSS);
            this.Controls.Add(this.selectPB);
            this.Controls.Add(this.selectRB);
            this.Controls.Add(this.selectBW);
            this.Controls.Add(this.selectTSPP);
            this.Controls.Add(this.selectEATPM);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dvGameResults);
            this.Controls.Add(this.radioForum);
            this.Controls.Add(this.radioMarket);
            this.Controls.Add(this.lblSearchType);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.picTSPP);
            this.Controls.Add(this.picPB);
            this.Controls.Add(this.picBW);
            this.Controls.Add(this.picF14);
            this.Controls.Add(this.picRB);
            this.Controls.Add(this.picSS);
            this.Controls.Add(this.picEATPM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PinsideSearch";
            this.Text = "PinSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dvGameResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectF14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectBW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTSPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectEATPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTSPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picF14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEATPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listResultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEATPM;
        private System.Windows.Forms.PictureBox picSS;
        private System.Windows.Forms.PictureBox picRB;
        private System.Windows.Forms.PictureBox picF14;
        private System.Windows.Forms.PictureBox picBW;
        private System.Windows.Forms.PictureBox picPB;
        private System.Windows.Forms.PictureBox picTSPP;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.RadioButton radioMarket;
        private System.Windows.Forms.RadioButton radioForum;
        public System.Windows.Forms.DataGridView dvGameResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox selectEATPM;
        private System.Windows.Forms.PictureBox selectTSPP;
        private System.Windows.Forms.PictureBox selectBW;
        private System.Windows.Forms.PictureBox selectRB;
        private System.Windows.Forms.PictureBox selectPB;
        private System.Windows.Forms.PictureBox selectSS;
        private System.Windows.Forms.PictureBox selectF14;
        private System.Windows.Forms.BindingSource listResultsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClear;
    }
}

