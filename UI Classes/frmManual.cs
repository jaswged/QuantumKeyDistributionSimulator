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
    public partial class frmManual : Form
        {
#region Variables
        int clickThrough = 1;
        //AlicePhoton aliceSends;
        public static int bitsToUse = 0;
        string ReadA = "You read a: ";
        public static int numOfBitsToUse= 1;
        string bits = "";
        int[] bitArray;
        public string BobFilters;
        public AlicePhoton[] photonsOfAlice;
        char[,] readPhotons = new char[3,bitsToUse];
        public int CurrentBit;
        public string bitInputNumber = "";
#endregion
        public frmManual()
            {
            InitializeComponent();
            }
        private void frmManual_Load(object sender, EventArgs e)
            {
            if (QuantumGedamkeDistribution.Utility.InputBox("Bit Number", "How many bits would you like?", ref bitInputNumber) == DialogResult.OK)
                {
                numOfBitsToUse = Convert.ToInt32(bitInputNumber);
                }
                bitArray = new int[numOfBitsToUse];
                photonsOfAlice = new AlicePhoton[numOfBitsToUse];
            hideAll();
            fillAlicePhotons();
            }
        private void fillAlicePhotons()
            {
            Random r = new Random();
            for (int i = 0; i < photonsOfAlice.Length; i++)
                {
                photonsOfAlice[i] = new AlicePhoton(r.Next(0, 4));
                //alicePhotons[i] = r.Next(0, 4);
                }
            }
        #region Label Click and increment
        private void label1_Click(object sender, EventArgs e)
            {
            switch (clickThrough)
                {
                case 1: this.lblBob.Show();
                    this.lblBob.Hide(); // Hide Bob
                    ShowAlice();        // Show Alice
                    clickThrough++;
                    break;
                case 2:
                    hideAlice();
                    ShowFilter();
                    lblClickToContinue.Hide();
                    photon1.Show();
                    // Code to go through and pick filters for each photon
                    clickThrough++;
                    break;
                case 3:
                    MessageBox.Show(readbitArray(bitArray, ref bits),"Current Bits",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAlisonComparison aliceCompare = new frmAlisonComparison();
                    aliceCompare.Inbits = bits;
                    aliceCompare.bitArray = bitArray;
                    aliceCompare.AliceFilters = getRectilinear(photonsOfAlice);
                    aliceCompare.BobFilters = BobFilters;
                    aliceCompare.ShowDialog();
                    this.Close();
                    break;
                }
            }

        private string readbitArray(int[] bitArray, ref string bits)
            {            
            foreach (int i in bitArray)
                {
                bits += i.ToString() + " ";
                }
            return bits;
            }
        #endregion
        #region Hide All the THINGS!!!
        public void hideAll()
            {
            hideAlice();
            hidePhotons();
            hideFilter();
            hideResults();
            lblCurrentBits.Hide();
            }
        public void hideAlice()
            {
            lblAlice.Hide();
            lblAlice2.Hide();
            lblAlice3.Hide();
            }
        public void hidePhotons()
            {
            photon1.Hide();
            }
        public void hideResults()
            {
            filter1.Hide();
            }
        public void hideFilter()
            {
            lblFilter.Hide();
            lblPhotons.Hide();
            lblPlus.Hide();
            lblCross.Hide();
            btnRead.Hide();
            lblJustRead.Hide();
            lblRead.Hide();
            }
        #endregion
        #region Show All the THINGS!!!
        public void ShowAll()
            {
            ShowAlice();
            ShowPhotons();
            ShowFilter();
            }
        public void ShowAlice()
            {
            lblAlice.Show();
            lblAlice2.Show();
            lblAlice3.Show();
            }
        public void ShowPhotons()
            {
            photon1.Show();
            }
        public void ShowFilter()
            {
            lblFilter.Show();
            lblPhotons.Show();
            lblPlus.Show();
            lblCross.Show();
            btnRead.Show();
            lblJustRead.Show();
            }
        #endregion
        #region Change Color of Selected
        // Change cross to white/Selected.
        private void lblCross_Click(object sender, EventArgs e)
            {
            lblCross.ForeColor = System.Drawing.Color.White;
            lblPlus.ForeColor = System.Drawing.Color.Yellow;
            }
        // Change plus to white/Selected.
        private void lblPlus_Click(object sender, EventArgs e)
            {
            lblPlus.ForeColor = System.Drawing.Color.White;
            lblCross.ForeColor = System.Drawing.Color.Yellow;
            }
        #endregion
        private void btnRead_Click(object sender, EventArgs e)
            {
            lblCurrentBits.Show();
            lblJustRead.Show();
            filter1.Show();
           char c;
           if(lblPlus.ForeColor == System.Drawing.Color.White)
                {
                c = readPhoton(photonsOfAlice[bitsToUse], false, ref CurrentBit);
                lblJustRead.Text = ReadA + c + " ";// +CurrentBit;              
                lblPlus.ForeColor = System.Drawing.Color.Yellow;
                filter1.Text += "\t" + c;
                BobFilters += "+";
                lblCurrentBits.Text += CurrentBit + " ";
                bitsToUse++;
                }
            else if (lblCross.ForeColor == System.Drawing.Color.White)
                {
                c = readPhoton(photonsOfAlice[bitsToUse], true, ref CurrentBit);
                lblJustRead.Text = ReadA + c + " ";// +CurrentBit;
                lblCross.ForeColor = System.Drawing.Color.Yellow;
                filter1.Text += "\t" + c;
                BobFilters += "x";
                lblCurrentBits.Text += CurrentBit + " ";
                bitsToUse++;
                }
            else{
            MessageBox.Show("You must decide on a filter to use. Click the + or x", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           #region if at end   
            bitArray[bitsToUse-1] = CurrentBit;            
          
            if (bitsToUse == numOfBitsToUse)
                {
                lblClickToContinue.Show();
                btnRead.Hide();
                lblCross.Hide();
                lblPlus.Hide();
                lblFilter.Hide();
                }
            else
                {
                photon1.Text += "\t\t" + "\t*";
                }
            #endregion
            }
        // Reads a photon with the chosen filter.
        public char readPhoton(AlicePhoton electroMagneticRadiationPacket,bool filter, ref int CurrentBit)
            {
                // true = x; false = + 
            if (electroMagneticRadiationPacket.Rectilinear == filter)
                {
                    if(electroMagneticRadiationPacket.Rectilinear == true && electroMagneticRadiationPacket.Polarization == true)
                        {
                        CurrentBit = 1;
                        return '/'; // rectilinear is x and polar is true so 1
                        }
                    else if(electroMagneticRadiationPacket.Rectilinear == true && electroMagneticRadiationPacket.Polarization == false)
                        {
                        CurrentBit = 0;
                        return '\\'; // rectilinear is x and polar is false so 0
                        }
                    else if(electroMagneticRadiationPacket.Rectilinear == false && electroMagneticRadiationPacket.Polarization == true)
                        {
                        CurrentBit = 1;
                        return '|'; // rectilinear is + and polar is true so 1
                        }
                    else //if(electroMagneticRadiationPacket.Rectilinear == false && electroMagneticRadiationPacket.Polarization == false)
                        {
                        CurrentBit = 0;
                        return '-'; // rectilinear is + and polar is false so 0
                        }
                }
            else
                {
                Random r = new Random();
                int result =r.Next(0,2);
                if (electroMagneticRadiationPacket.Rectilinear == false)// && electroMagneticRadiationPacket.Polarization == true)
                    {
                    if(result == 0)
                        {
                        CurrentBit = 0;
                        return '\\'; // read random wrong answer
                        }
                    else
                        {
                        CurrentBit = 1;
                        return '/'; // read random wrong answer
                        }
                    }
                else //if (electroMagneticRadiationPacket.Rectilinear == true) && electroMagneticRadiationPacket.Polarization == false)
                    {
                    if (result == 0)
                        {
                        CurrentBit = 0;
                        return '-'; // read random wrong answer
                        }
                    else
                        {
                        CurrentBit = 1;
                        return '|'; // read random wrong answer
                        }
                    }
                }
            }
        public string getRectilinear(AlicePhoton[] alice)
            {
            string aliceString = "";
            foreach (AlicePhoton a in alice)
                {
                if (a.Rectilinear == true)
                    {
                    aliceString += "x";
                    }
                else
                    {
                    aliceString += "+";
                    }
                }
                return aliceString;
            }
        #region Old Code
        /*
               if (electroMagneticRadiationPacket.Rectilinear == true && electroMagneticRadiationPacket.Polarization == true)
                    {
                    if(result == 0)
                        {
                        return '\\'; // read random wrong answer
                        }
                    else
                        {
                        return '/'; // read random wrong answer
                        }
                    }
                else if (electroMagneticRadiationPacket.Rectilinear == true && electroMagneticRadiationPacket.Polarization == false)
                    {
                    if (result == 0)
                        {
                        return '\\'; // read random wrong answer
                        }
                    else
                        {
                        return '/'; // read random wrong answer
                        }
                    }
                else if (electroMagneticRadiationPacket.Rectilinear == false && electroMagneticRadiationPacket.Polarization == true)
                    {                    
                    if (result == 0)
                        {
                        return '\\'; // read random wrong answer
                        }
                    else
                        {
                        return '/'; // read random wrong answer
                        }
                    }
                else if (electroMagneticRadiationPacket.Rectilinear == false && electroMagneticRadiationPacket.Polarization == false)
                    {                
                    if (result == 0)
                        {
                        return '\\'; // read random wrong answer
                        }
                    else
                        {
                        return '/'; // read random wrong answer
                        }
                    }
         * */
        #endregion
        }
    }
