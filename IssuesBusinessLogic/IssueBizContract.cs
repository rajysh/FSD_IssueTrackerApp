using IssuesBusinessLogic.Entities;
using System.Collections.Generic;

namespace IssuesBusinessLogic
{
    public interface IssueBizContract
    {
        List<IssueBase> GetAllIssues();
        List<string> GetAllIssueTypes();
        string GetIssueTypes(IssueBase issue);
        List<Status> GetAllStatus();
        List<Priority> GetAllPriority();
        int AddIssue(IssueBase issue);
        int UpdateIssue(IssueBase issue);
        void ResolveIssue(IssueBase issue);
    }
}
