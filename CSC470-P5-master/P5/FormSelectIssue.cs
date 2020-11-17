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
    public partial class FormSelectIssue : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;
        public FormSelectIssue(AppUser appUser, int SelectedProjectId)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
            _SelectedProjectId = SelectedProjectId;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
