using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private List<IssueStatus> IssueStatuses;

        public void Add(int Id, string value)
        {

        }
        /*
        public List<IssueStatus> GetAll()
        {

        }
        public int GetIdByStatus(string value)
        {

        }
        public string GetValueById(int Id)
        {

        }
        */
    }
}
