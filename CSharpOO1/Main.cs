using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOO1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game newForm2 = new Game();
            this.Hide(); // use dessa maneira.
            newForm2.ShowDialog();
            this.Close();
        }
    }
}
