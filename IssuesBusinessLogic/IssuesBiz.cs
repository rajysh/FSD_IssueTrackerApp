using IssuesBusinessLogic.Entities;
using IssueTrackerInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesBusinessLogic
{
    public class IssuesBiz : IssueBizContract
    {

        //Initital Data
        List<IssueBase> allIssues = new List<IssueBase>() {
            new EngineeringIssue {IssueID=101, IssueTitle = "Browser Issue for WEb portal",
                IssueDescription="User is unable to load web site on IE.", IssuePriority = Priority.Medium,
                IssueStatus=Status.Open
            },
            new ServiceIssue {IssueID=102, IssueTitle = "Need Customer Service Email",
                IssueDescription="User needs email IT support as the call waiting is quite long.", IssuePriority = Priority.High,
                IssueStatus=Status.Open
            },
            new OperationalIssue {IssueID=103, IssueTitle = "Shipping services not available on weekends",
                IssueDescription="Need to have some arrangements for shippig nover weekends for runnig business 24X7",
                IssuePriority = Priority.High,
                IssueStatus=Status.InProgress
            }
        };

        private LogHelper _objLogHelper;

        public IssuesBiz(LogHelper logHelper)
        {
            _objLogHelper = logHelper;
        }

        /// <summary>
        /// method to add new issue
        /// </summary>
        /// <param name="issue"></param>
        /// <returns></returns>
        public int AddIssue(IssueBase issue)
        {
            allIssues.Add(issue);

            //Log this information
            if (issue.IssueTitle.Length > 15)
            {
                _objLogHelper.LogInfo($"{issue.IssueTitle.Substring(0, 15)} ... Added.");
                
            }
            else
            {
                _objLogHelper.LogInfo($"{issue.IssueTitle} ... Added.");

            }
            return issue.IssueID;
        }

        /// <summary>
        /// Method to get all issues
        /// </summary>
        /// <returns></returns>
        public List<IssueBase> GetAllIssues()
        {
            return allIssues;
        }

        /// <summary>
        /// method to Get All Issue Types
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllIssueTypes()
        {
            List<string> allIssueTypes = new List<string>()
            {
                "Operational",
                "Service",
                "Engineering"
            };

            return allIssueTypes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Priority> GetAllPriority()
        {
            List<Priority> allPriorities = new List<Priority>()
            {
                Priority.Low,
                Priority.High,
                Priority.Medium
            };

            return allPriorities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Status> GetAllStatus()
        {
            List<Status> allStatus = new List<Status>()
            {
                Status.Open,
                Status.InProgress,
                Status.Closed
            };

            return allStatus;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="issue"></param>
        /// <returns></returns>
        public string GetIssueTypes(IssueBase issue)
        {
            string type = issue.GetType().Name;
            string result = "";
            
            switch(type)
            {
                case "EngineeringIssue":
                    result = "Engineering";
                    break;
                case "OperationalIssue":
                    result = "Operational";
                    break;
                case "ServiceIssue":
                    result = "Service";
                    break;
                default:
                    break;
            }

            return result;
        }

        /// <summary>
        /// Method to Resolve Issue
        /// </summary>
        /// <returns></returns>
        public void ResolveIssue(IssueBase issue)
        {
            string message = issue.ResolveIssue();
            _objLogHelper.LogInfo(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updatedIssue"></param>
        /// <returns></returns>
        public int UpdateIssue(IssueBase updatedIssue)
        {
            //Find the issue from the list , remove it and add the updated issue again to the list.
            foreach(var issue in allIssues)
            {
                if(issue.IssueID == updatedIssue.IssueID)
                {
                    allIssues.Remove(issue); //Remove Item from the list
                    break;
                }
            }

            allIssues.Add(updatedIssue);

            //Log this information
            if(updatedIssue.IssueTitle.Length>15)
            {
                _objLogHelper.LogInfo($"{updatedIssue.IssueTitle.Substring(0, 15)} ... updated.");

            }
            else
            {
                _objLogHelper.LogInfo($"{updatedIssue.IssueTitle} ... updated.");
            }

            return updatedIssue.IssueID;
        }
    }
}
