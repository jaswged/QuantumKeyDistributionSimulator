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
    public partial class frmAlisonComparison : Form
        {
        #region Variables
        public int count = 0;
        public string Inbits;
        protected string OutBits;
        public string BobFilters;
        public string AliceFilters;
        string ResultingFilter;        
        // One or the other`
        public AlicePhoton[] photonsOfAlice = new AlicePhoton[8];
        public int[] bitArray = new int[8];        
        #endregion

        public frmAlisonComparison()
            {
            InitializeComponent();
            }
        private void frmAlisonComparison_Load(object sender, EventArgs e)
            {
            lblBitString.Hide();
            lblCorrect.Hide();
            ResultingFilter = compareRectilinearChoices(AliceFilters, BobFilters, bitArray);
            lblAliceFilters.Text = AliceFilters;
            lblBobFilters.Text = BobFilters;
            lblCorrectFilters.Text = ResultingFilter;
            }
        private void lblClickToContinue_Click(object sender, EventArgs e)
        {
        lblBitString.Show();
        lblBitString.Text = OutBits; 
        lblCorrect.Show();
        hideAllTheTHings();
        if (count == 1)
            {
            frmEncryption encry = new frmEncryption();
            encry.bits = OutBits;
            encry.ShowDialog();
            this.Close();
            }
        count++;
        }

        private void hideAllTheTHings()
            {
            lblAliceFilters.Hide();
            lblAlicesFilters.Hide();
            lblBobFilters.Hide();
            label2.Hide();
            lblYouChose.Hide();
            }
        private string compareRectilinearChoices(string Alice, string Bob, int[] bitArray)
            {
            string result = "";
            for(int i = 0; i<Alice.Length; i++)
                {
                    if(Alice[i] == Bob[i])
                        {
                        result += Alice[i];
                        OutBits += bitArray[i];
                        //lblCorrect.Text += bitArray[i];
                        }
                    else
                        {
                        result += " ";
                        OutBits += " ";
                        }
                }
            return result;
            }
        }
    }
