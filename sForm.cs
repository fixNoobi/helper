using Ini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La2Coding
{
    public partial class sForm : Form
    {
        public sForm()
        {
            InitializeComponent();
        }


        private void qSetUp_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(Environment.CurrentDirectory + "\\set.ini");
            ini.IniWriteValue("General", "FindInTopDir", qFindInTopDir.Checked.ToString());
            ini.IniWriteValue("General", "FindMask", qExtModeCh.Checked.ToString());
            ini.IniWriteValue("General", "FindMaskExt", qExtMode.SelectedItem.ToString());
        }

        private void sForm_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(Environment.CurrentDirectory + "\\set.ini");
            qFindInTopDir.Checked = Convert.ToBoolean(ini.IniReadValue("General", "FindInTopDir"));
            qExtModeCh.Checked = Convert.ToBoolean(ini.IniReadValue("General", "FindMask"));
            qExtMode.SelectedItem = ini.IniReadValue("General", "FindMaskExt");
        }

        private void qOK_Click(object sender, EventArgs e)
        {
            qSetUp_Click(this, null);
            this.Close();
        }

        private void qExtModeCh_CheckedChanged(object sender, EventArgs e)
        {
            if (qExtModeCh.Checked != true) qExtMode.Enabled = false;
            else qExtMode.Enabled = true;
        }
    }
}
