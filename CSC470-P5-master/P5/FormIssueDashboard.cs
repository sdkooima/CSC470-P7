using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormIssueDashboard : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        FakeIssueRepository _issueRepository = new FakeIssueRepository();
        public FormIssueDashboard(AppUser appUser, int projectId)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
            _SelectedProjectId = projectId;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            label2 = _issueRepository.GetTotalNumberOfIssues(_SelectedProjectId).ToString;
        }
    }
}
