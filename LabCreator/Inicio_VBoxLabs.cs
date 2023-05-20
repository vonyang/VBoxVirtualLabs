using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCreator
{
    public partial class iniVboxlabs : Form
    {
        public iniVboxlabs()
        {
            InitializeComponent();
        }

        private void Ini_VBoxLabs_Load(object sender, EventArgs e)
        {
            iniButton.Enabled = true;
        }

        private void ini_start_button_Click(object sender, EventArgs e)
        {
            using (menuVBoxLabs Menu_VBoxLabs = new menuVBoxLabs())
            {
                Menu_VBoxLabs.ShowDialog();
            }
        }
    }
}
