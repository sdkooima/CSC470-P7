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
    public partial class FormCreateFeature : Form
    {
        FakeFeatureRepository _FeatureRepository = new FakeFeatureRepository();

        public AppUser _CurrentAppUser;
        public int _SelectedProjectId;
        public FormCreateFeature(AppUser appUser, int SelectedProjectId)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
            _SelectedProjectId = SelectedProjectId;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Feature feature = new Feature();
                feature.Title = textBox1.Text;
                _FeatureRepository.Add(feature);
            }
            else
            {
                MessageBox.Show("Title must have a unique value");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
