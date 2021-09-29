using IssuesBusinessLogic;
using IssuesBusinessLogic.Entities;
using IssueTrackerInfrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssuesTrackerApp
{
    public partial class frmIssueTracker : Form
    {
        private IssueBizContract _issueBiz; //IssueBusinessLogic Object
        private LogHelper _logHelper;   //LogHelper Object
        private IssueBase issueToSave;   //IssueBase Object, it can point to OperationIssue, EngineeringIssue or ServiceIssue(Abstraction and Polymorphism)
        public frmIssueTracker()
        {
            InitializeComponent();
            //Initializing dependencies
            _logHelper = new LogHelper();
            _issueBiz = new IssuesBiz(_logHelper);
            _logHelper.LogUpdated += _logHelper_LogUpdated;
        }


        /// <summary>
        /// Event handler for LogUpdated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _logHelper_LogUpdated(object sender, List<LogDetail> e)
        {
            lstLogs.DataSource = null;
            lstLogs.DataSource = e;
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIssueTracker_Load(object sender, EventArgs e)
        {
            cbPriority.DataSource = _issueBiz.GetAllPriority(); //Binding Priorities Combo Box
            cbStatus.DataSource = _issueBiz.GetAllStatus(); //Binding Status Combo Box
            cbType.DataSource = _issueBiz.GetAllIssueTypes();   //Binding Issue Types Combo Box
            btnResolve.Enabled = false; //Disabling Resolve Button
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbIssueDetails_Enter(object sender, EventArgs e)
        {

        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
               

        private void btnNew_Click(object sender, EventArgs e)
        {
            issueToSave = null;
            tbIssueID.Text = string.Empty;
            tbIssueTitle.Text = string.Empty;
            tbissueDesc.Text = string.Empty;
            cbPriority.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            dgrdIssues.ClearSelection();
            cbType.Enabled = true;
            btnResolve.Enabled = false;
        }

        private void dgrdIssues_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgrdIssues.SelectedRows.Count > 0)
                {
                    int selectedIssueID;
                    int.TryParse(dgrdIssues.SelectedRows[0].Cells[0].Value.ToString(), out selectedIssueID);

                    //---- Get the Actual Issue object from All Issue List
                    List<IssueBase> allIssues = _issueBiz.GetAllIssues();
                    foreach(var issue in allIssues)
                    {
                        if(issue.IssueID == selectedIssueID)
                        {
                            issueToSave = issue;
                            break;
                        }
                    }

                    //IssueSave is now pointing to IssueBase object to update.

                    tbIssueID.Text = issueToSave.IssueID.ToString();
                    tbIssueTitle.Text = issueToSave.IssueTitle.ToString();
                    tbissueDesc.Text = issueToSave.IssueDescription.ToString();
                    cbPriority.SelectedItem = issueToSave.IssuePriority;
                    cbStatus.SelectedItem = issueToSave.IssueStatus;
                    cbType.SelectedItem = _issueBiz.GetIssueTypes(issueToSave);
                    cbType.Enabled = true;
                    btnResolve.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                _logHelper.LogInfo("Error occurred.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool newIssue = false;
            string type = cbType.SelectedItem.ToString();

            if(issueToSave == null)  //IssueToSave null means, we are creating a new Issue object.
            {
                newIssue = true;
                switch(type)
                {
                    case "Operational":
                        issueToSave = new OperationalIssue();
                        break;
                    case "Service":
                        issueToSave = new ServiceIssue();
                        break;
                    case "Engineering":
                        issueToSave = new EngineeringIssue();
                        break;
                    default:
                        break;
                }
            }

            int issueId;
            int.TryParse(tbIssueID.Text, out issueId);

            issueToSave.IssueID = issueId;
            issueToSave.IssueTitle = tbIssueTitle.Text;
            issueToSave.IssueDescription = tbissueDesc.Text;

            Priority issuePriority;
            Enum.TryParse(cbPriority.SelectedItem.ToString(), out issuePriority);
            issueToSave.IssuePriority = issuePriority;

            Status issueStatus;
            Enum.TryParse(cbStatus.SelectedItem.ToString(), out issueStatus);
            issueToSave.IssueStatus = issueStatus;

            if(newIssue)
            {
                _issueBiz.AddIssue(issueToSave);
            }
            else
            {
                _issueBiz.UpdateIssue(issueToSave);
            }
            LoadIssues();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadIssues();
        }

        /// <summary>
        /// Private method, loads all issues and refresh the DataGridView
        /// </summary>
        private void LoadIssues()
        {
            BindingSource source = new BindingSource();
            source.DataSource = _issueBiz.GetAllIssues();
            dgrdIssues.DataSource = source; //Binding DataGridView
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            //Important: Every Issue has a ResolveIssue method, but we cannot call it because it is marked as internal.
            //We have to access it through the Business Logic Class.

            _issueBiz.ResolveIssue(issueToSave);
        }
    }
}
