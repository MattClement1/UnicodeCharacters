/*
*Created by: Matthew Clement
*Created on: 16-Oct-2015
*Created for: Unit #3-11
*This program converts numbers to Unicode
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeCharacters
{
    public partial class frmUnicodeCharacters : Form
    {
        public frmUnicodeCharacters()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string letter;
            for (int number = 65; number <= 90; number++) 
            {
                letter = Char.ConvertFromUtf32(number);
                this.lstCharacterList.Items.Add(letter + " - " + number);
            }
        }
    }
}
