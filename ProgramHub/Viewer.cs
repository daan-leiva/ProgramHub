using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramHub
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form home = new MainForm();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form info = new EditProgramInfoForm();
            info.Show();
        }
    }
}
