using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumGedamkeDistribution
    {
    public partial class frmAutomated : Form
        {
        string bitNumber;
        int numBits;
        public frmAutomated()
            {
            InitializeComponent();
            }

        private void frmAutomated_Load(object sender, EventArgs e)
            {
            //Thread.Sleep(1000);
            if (QuantumGedamkeDistribution.Utility.InputBox("Bit Number", "How many bits would you like?", ref bitNumber) == DialogResult.OK)
                {
                numBits = Convert.ToInt32(bitNumber);
                }
            //MessageBox.Show(bitNumber.ToString());
            lblBits.Text += bitNumber.ToString();
            }
        }
    }
