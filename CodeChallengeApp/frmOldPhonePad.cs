using CodeChallenge.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChallenge.WindowApp
{
    public partial class frmOldPhonePad : Form
    {
        public frmOldPhonePad()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = textBoxInput.Text;
                string output = OldPhonePad.ParseInput(input);
                labelOutput.Text = $"Output: {output}";
                textBoxInput.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }      
    }
}
