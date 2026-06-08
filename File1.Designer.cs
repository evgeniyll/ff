namespace WinFormsApp3
{
    partial class File1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        internal System.Windows.Forms.TextBox txtFolderLeft;
        internal System.Windows.Forms.Button btnBrowseLeft;
        internal System.Windows.Forms.TextBox txtFolderRight;
        internal System.Windows.Forms.Button btnBrowseRight;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnCompare;
        internal System.Windows.Forms.Button btnHistory;
        internal System.Windows.Forms.Button btnSaveState;
        internal System.Windows.Forms.DataGridView gridFiles;
        internal System.Windows.Forms.Label lblInfo;
        internal System.ComponentModel.BindingList<FilePairRow> rows;

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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtFolderLeft = new System.Windows.Forms.TextBox();
            btnBrowseLeft = new System.Windows.Forms.Button();
            txtFolderRight = new System.Windows.Forms.TextBox();
            btnBrowseRight = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnCompare = new System.Windows.Forms.Button();
            btnHistory = new System.Windows.Forms.Button();
            btnSaveState = new System.Windows.Forms.Button();
            gridFiles = new System.Windows.Forms.DataGridView();
            lblInfo = new System.Windows.Forms.Label();
            rows = new System.ComponentModel.BindingList<FilePairRow>();
            tableTop = new System.Windows.Forms.TableLayoutPanel();
            lblLeft = new System.Windows.Forms.Label();
            lblRight = new System.Windows.Forms.Label();
            panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)gridFiles).BeginInit();
            tableTop.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // txtFolderLeft
            // 
            txtFolderLeft.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFolderLeft.Location = new System.Drawing.Point(73, 6);
            txtFolderLeft.Name = "txtFolderLeft";
            txtFolderLeft.Size = new System.Drawing.Size(423, 23);
            txtFolderLeft.TabIndex = 0;
            // 
            // btnBrowseLeft
            // 
            btnBrowseLeft.Location = new System.Drawing.Point(502, 6);
            btnBrowseLeft.Name = "btnBrowseLeft";
            btnBrowseLeft.Size = new System.Drawing.Size(94, 23);
            btnBrowseLeft.TabIndex = 1;
            btnBrowseLeft.Text = "Папка 1...";
            btnBrowseLeft.UseVisualStyleBackColor = true;
            // 
            // txtFolderRight
            // 
            txtFolderRight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFolderRight.Location = new System.Drawing.Point(673, 6);
            txtFolderRight.Name = "txtFolderRight";
            txtFolderRight.Size = new System.Drawing.Size(423, 23);
            txtFolderRight.TabIndex = 2;
            // 
            // btnBrowseRight
            // 
            btnBrowseRight.Location = new System.Drawing.Point(1102, 6);
            btnBrowseRight.Name = "btnBrowseRight";
            btnBrowseRight.Size = new System.Drawing.Size(94, 23);
            btnBrowseRight.TabIndex = 3;
            btnBrowseRight.Text = "Папка 2...";
            btnBrowseRight.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(3, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(90, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCompare
            // 
            btnCompare.Location = new System.Drawing.Point(99, 3);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new System.Drawing.Size(220, 23);
            btnCompare.TabIndex = 5;
            btnCompare.Text = "Сравнить выбранные файлы";
            btnCompare.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            btnHistory.Location = new System.Drawing.Point(325, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new System.Drawing.Size(140, 23);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "История сравнений";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnSaveState
            // 
            btnSaveState.Location = new System.Drawing.Point(471, 3);
            btnSaveState.Name = "btnSaveState";
            btnSaveState.Size = new System.Drawing.Size(150, 23);
            btnSaveState.TabIndex = 7;
            btnSaveState.Text = "Сохранить настройки";
            btnSaveState.UseVisualStyleBackColor = true;
            // 
            // gridFiles
            // 
            gridFiles.AllowUserToAddRows = false;
            gridFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridFiles.AutoGenerateColumns = true;
            gridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFiles.Location = new System.Drawing.Point(12, 116);
            gridFiles.MultiSelect = false;
            gridFiles.Name = "gridFiles";
            gridFiles.ReadOnly = true;
            gridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            gridFiles.Size = new System.Drawing.Size(1184, 432);
            gridFiles.TabIndex = 8;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblInfo.Location = new System.Drawing.Point(12, 555);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new System.Windows.Forms.Padding(8);
            lblInfo.Size = new System.Drawing.Size(1184, 62);
            lblInfo.TabIndex = 9;
            lblInfo.Text = " ";
            // 
            // tableTop
            // 
            tableTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableTop.ColumnCount = 6;
            tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableTop.Controls.Add(lblLeft, 0, 0);
            tableTop.Controls.Add(txtFolderLeft, 1, 0);
            tableTop.Controls.Add(btnBrowseLeft, 2, 0);
            tableTop.Controls.Add(lblRight, 3, 0);
            tableTop.Controls.Add(txtFolderRight, 4, 0);
            tableTop.Controls.Add(btnBrowseRight, 5, 0);
            tableTop.Location = new System.Drawing.Point(12, 12);
            tableTop.Name = "tableTop";
            tableTop.RowCount = 1;
            tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableTop.Size = new System.Drawing.Size(1184, 35);
            tableTop.TabIndex = 10;
            // 
            // lblLeft
            // 
            lblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLeft.Location = new System.Drawing.Point(3, 0);
            lblLeft.Name = "lblLeft";
            lblLeft.Size = new System.Drawing.Size(64, 35);
            lblLeft.TabIndex = 11;
            lblLeft.Text = "Папка 1:";
            lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRight
            // 
            lblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            lblRight.Location = new System.Drawing.Point(603, 0);
            lblRight.Name = "lblRight";
            lblRight.Size = new System.Drawing.Size(64, 35);
            lblRight.TabIndex = 12;
            lblRight.Text = "Папка 2:";
            lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelButtons
            // 
            panelButtons.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtons.Controls.Add(btnRefresh);
            panelButtons.Controls.Add(btnCompare);
            panelButtons.Controls.Add(btnHistory);
            panelButtons.Controls.Add(btnSaveState);
            panelButtons.Location = new System.Drawing.Point(12, 53);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(1184, 57);
            panelButtons.TabIndex = 13;
            // 
            // File1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1208, 629);
            Controls.Add(panelButtons);
            Controls.Add(tableTop);
            Controls.Add(lblInfo);
            Controls.Add(gridFiles);
            Name = "File1";
            Text = "File1";
            ((System.ComponentModel.ISupportInitialize)gridFiles).EndInit();
            tableTop.ResumeLayout(false);
            tableTop.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTop;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
    }
}

