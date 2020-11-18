using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        
        private static List<Issue> _Issues = new List<Issue>();

        public FakeIssueRepository()
        {
            if(_Issues.Count == 0)
            {
                
            }
        }
        /*
        public string Add(Issue issue)
        {

        }
        */
        public List<Issue> GetAll(int ProjectId)
        {
            return _Issues;
        }
        /*
        public bool Remove(Issue issue)
        {

        }

        public string Modify(Issue issue)
        {

        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {

        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {

        }

        private string ValidateIssue(Issue issue)
        {
            
        }

        private bool IsDuplicate(string title)
        {

        }
        */
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int count = 0;
            foreach (Issue x in _Issues)
            {
                if (x.ProjectId == ProjectId)
                    count++;
            }
            return count;
        }
        /*
        public Issue GetIssueById(int Id)
        {

        }
        */
    }
}
