using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace WinGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            //wb.Url="http://www.miniclip.com/games/raiders-took-my-dog/en/#t-l-gs1-H";
            this.wb.Navigate("http://www.miniclip.com/games/raiders-took-my-dog/en/#t-l-gs1-H");
        }
    }
}
