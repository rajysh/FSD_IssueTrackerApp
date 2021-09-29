
namespace IssuesTrackerApp
{
    partial class frmIssueTracker
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
            this.gbIssueDetails = new System.Windows.Forms.GroupBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.tbissueDesc = new System.Windows.Forms.TextBox();
            this.lblIssueDesc = new System.Windows.Forms.Label();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.tbIssueTitle = new System.Windows.Forms.TextBox();
            this.tbIssueID = new System.Windows.Forms.TextBox();
            this.lblIssueId = new System.Windows.Forms.Label();
            this.gbLogDetail = new System.Windows.Forms.GroupBox();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgrdIssues = new System.Windows.Forms.DataGridView();
            this.IssueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuePriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIssueDetails.SuspendLayout();
            this.gbLogDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIssueDetails
            // 
            this.gbIssueDetails.Controls.Add(this.btnResolve);
            this.gbIssueDetails.Controls.Add(this.btnSave);
            this.gbIssueDetails.Controls.Add(this.btnNew);
            this.gbIssueDetails.Controls.Add(this.lblType);
            this.gbIssueDetails.Controls.Add(this.cbType);
            this.gbIssueDetails.Controls.Add(this.cbStatus);
            this.gbIssueDetails.Controls.Add(this.lblStatus);
            this.gbIssueDetails.Controls.Add(this.cbPriority);
            this.gbIssueDetails.Controls.Add(this.lblPriority);
            this.gbIssueDetails.Controls.Add(this.tbissueDesc);
            this.gbIssueDetails.Controls.Add(this.lblIssueDesc);
            this.gbIssueDetails.Controls.Add(this.lblIssueTitle);
            this.gbIssueDetails.Controls.Add(this.tbIssueTitle);
            this.gbIssueDetails.Controls.Add(this.tbIssueID);
            this.gbIssueDetails.Controls.Add(this.lblIssueId);
            this.gbIssueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIssueDetails.Location = new System.Drawing.Point(12, 12);
            this.gbIssueDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIssueDetails.Name = "gbIssueDetails";
            this.gbIssueDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIssueDetails.Size = new System.Drawing.Size(584, 388);
            this.gbIssueDetails.TabIndex = 0;
            this.gbIssueDetails.TabStop = false;
            this.gbIssueDetails.Text = "Add/Edit Issue";
            this.gbIssueDetails.Enter += new System.EventHandler(this.gbIssueDetails_Enter);
            // 
            // btnResolve
            // 
            this.btnResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(371, 319);
            this.btnResolve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(95, 30);
            this.btnResolve.TabIndex = 14;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(264, 319);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(156, 319);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 30);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(87, 283);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(165, 286);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(149, 26);
            this.cbType.TabIndex = 10;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(165, 245);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(149, 26);
            this.cbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(87, 249);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // cbPriority
            // 
            this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(164, 206);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(149, 26);
            this.cbPriority.TabIndex = 7;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(85, 215);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(58, 18);
            this.lblPriority.TabIndex = 6;
            this.lblPriority.Text = "Priority:";
            // 
            // tbissueDesc
            // 
            this.tbissueDesc.Location = new System.Drawing.Point(165, 81);
            this.tbissueDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbissueDesc.Multiline = true;
            this.tbissueDesc.Name = "tbissueDesc";
            this.tbissueDesc.Size = new System.Drawing.Size(385, 118);
            this.tbissueDesc.TabIndex = 5;
            // 
            // lblIssueDesc
            // 
            this.lblIssueDesc.AutoSize = true;
            this.lblIssueDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDesc.Location = new System.Drawing.Point(21, 111);
            this.lblIssueDesc.Name = "lblIssueDesc";
            this.lblIssueDesc.Size = new System.Drawing.Size(126, 18);
            this.lblIssueDesc.TabIndex = 4;
            this.lblIssueDesc.Text = "Issue Description:";
            // 
            // lblIssueTitle
            // 
            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueTitle.Location = new System.Drawing.Point(67, 62);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(78, 18);
            this.lblIssueTitle.TabIndex = 3;
            this.lblIssueTitle.Text = "Issue Title:";
            // 
            // tbIssueTitle
            // 
            this.tbIssueTitle.Location = new System.Drawing.Point(165, 49);
            this.tbIssueTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIssueTitle.Name = "tbIssueTitle";
            this.tbIssueTitle.Size = new System.Drawing.Size(385, 24);
            this.tbIssueTitle.TabIndex = 2;
            // 
            // tbIssueID
            // 
            this.tbIssueID.Location = new System.Drawing.Point(165, 18);
            this.tbIssueID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbIssueID.Name = "tbIssueID";
            this.tbIssueID.Size = new System.Drawing.Size(385, 24);
            this.tbIssueID.TabIndex = 1;
            // 
            // lblIssueId
            // 
            this.lblIssueId.AutoSize = true;
            this.lblIssueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueId.Location = new System.Drawing.Point(80, 22);
            this.lblIssueId.Name = "lblIssueId";
            this.lblIssueId.Size = new System.Drawing.Size(65, 18);
            this.lblIssueId.TabIndex = 0;
            this.lblIssueId.Text = "Issue ID:";
            // 
            // gbLogDetail
            // 
            this.gbLogDetail.Controls.Add(this.lstLogs);
            this.gbLogDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogDetail.Location = new System.Drawing.Point(625, 18);
            this.gbLogDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLogDetail.Name = "gbLogDetail";
            this.gbLogDetail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLogDetail.Size = new System.Drawing.Size(363, 382);
            this.gbLogDetail.TabIndex = 1;
            this.gbLogDetail.TabStop = false;
            this.gbLogDetail.Text = "Log Detail";
            // 
            // lstLogs
            // 
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.ItemHeight = 18;
            this.lstLogs.Location = new System.Drawing.Point(8, 25);
            this.lstLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(345, 346);
            this.lstLogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 420);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "All Issues:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(879, 420);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 30);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgrdIssues
            // 
            this.dgrdIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueID,
            this.IssueTitle,
            this.IssueDescription,
            this.IssuePriority,
            this.IssueStatus});
            this.dgrdIssues.Location = new System.Drawing.Point(16, 455);
            this.dgrdIssues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgrdIssues.Name = "dgrdIssues";
            this.dgrdIssues.ReadOnly = true;
            this.dgrdIssues.RowHeadersWidth = 51;
            this.dgrdIssues.Size = new System.Drawing.Size(968, 212);
            this.dgrdIssues.TabIndex = 16;
            this.dgrdIssues.SelectionChanged += new System.EventHandler(this.dgrdIssues_SelectionChanged);
            // 
            // IssueID
            // 
            this.IssueID.DataPropertyName = "IssueID";
            this.IssueID.HeaderText = "Issue ID";
            this.IssueID.MinimumWidth = 6;
            this.IssueID.Name = "IssueID";
            this.IssueID.ReadOnly = true;
            this.IssueID.Width = 125;
            // 
            // IssueTitle
            // 
            this.IssueTitle.DataPropertyName = "IssueTitle";
            this.IssueTitle.HeaderText = "Title";
            this.IssueTitle.MinimumWidth = 6;
            this.IssueTitle.Name = "IssueTitle";
            this.IssueTitle.ReadOnly = true;
            this.IssueTitle.Width = 125;
            // 
            // IssueDescription
            // 
            this.IssueDescription.DataPropertyName = "IssueDescription";
            this.IssueDescription.HeaderText = "Description";
            this.IssueDescription.MinimumWidth = 10;
            this.IssueDescription.Name = "IssueDescription";
            this.IssueDescription.ReadOnly = true;
            this.IssueDescription.Width = 250;
            // 
            // IssuePriority
            // 
            this.IssuePriority.DataPropertyName = "IssuePriority";
            this.IssuePriority.HeaderText = "Priority";
            this.IssuePriority.MinimumWidth = 6;
            this.IssuePriority.Name = "IssuePriority";
            this.IssuePriority.ReadOnly = true;
            this.IssuePriority.Width = 125;
            // 
            // IssueStatus
            // 
            this.IssueStatus.DataPropertyName = "IssueStatus";
            this.IssueStatus.HeaderText = "Status";
            this.IssueStatus.MinimumWidth = 6;
            this.IssueStatus.Name = "IssueStatus";
            this.IssueStatus.ReadOnly = true;
            this.IssueStatus.Width = 125;
            // 
            // frmIssueTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 784);
            this.Controls.Add(this.dgrdIssues);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLogDetail);
            this.Controls.Add(this.gbIssueDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIssueTracker";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmIssueTracker_Load);
            this.gbIssueDetails.ResumeLayout(false);
            this.gbIssueDetails.PerformLayout();
            this.gbLogDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIssueDetails;
        private System.Windows.Forms.Label lblIssueId;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.TextBox tbIssueTitle;
        private System.Windows.Forms.TextBox tbIssueID;
        private System.Windows.Forms.TextBox tbissueDesc;
        private System.Windows.Forms.Label lblIssueDesc;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbLogDetail;
        private System.Windows.Forms.ListBox lstLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgrdIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuePriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueStatus;
    }
}

