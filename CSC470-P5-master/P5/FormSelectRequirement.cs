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
    public partial class FormSelectRequirement : Form
    {
        public FormSelectRequirement()
        {
            InitializeComponent();
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
