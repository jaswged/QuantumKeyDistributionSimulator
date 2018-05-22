using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumGedamkeDistribution
    {
    public partial class frmMain : Form
        {
        public frmMain()
            {
            InitializeComponent();
            }

        private void lblTitle_Click(object sender, EventArgs e)
            {

            }

        private void btnAuto_Click(object sender, EventArgs e)
            {
            frmAutomated auto = new frmAutomated();
            this.Hide();
            auto.ShowDialog();
            this.Show();
            }

        private void btnMan_Click(object sender, EventArgs e)
            {
            frmManual man = new frmManual();
            this.Hide();
            man.ShowDialog();
            this.Show();

            }

        private void frmMain_Load(object sender, EventArgs e)
            {

            }
        }
    }
