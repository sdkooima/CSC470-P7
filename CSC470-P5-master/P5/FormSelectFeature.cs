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
    public partial class FormSelectFeature : Form
    {
        public FormSelectFeature()
        {
            InitializeComponent();
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {
            FakeFeatureRepository repo = new FakeFeatureRepository();
            this.CenterToParent();
            var cheat = repo.GetAll(1);
            foreach (Feature f in cheat)
            {
                //listView1.Items.AddRange(f.Title.Select(t => new ListViewItem(t)).ToArray());
                listView1.Items.Add(new ListViewItem(f.Title));
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
