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

namespace MovingBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int movesNumber = 0;

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            List<Button> btList = new List<Button>();
            foreach (Button bt in this.pnl.Controls)
            {
                btList.Add(bt);
            }

            var last = btList[btList.Count - 1];

            for (var i = 0 ; i< 41 ; i++)
            {
                btList[i] = btList[i+1];
                btList[i].BackColor = btList[i+1].BackColor;
                btList[i].Text = btList[i+1].Text;
                btList[i].ForeColor = btList[i+1].ForeColor;
                //   btList[i + 1].TabIndex = btList[i].TabIndex;
                // this.pnl.Controls.Add(btList[i + 1]);
                btList[i].Refresh();
               // Thread.Sleep(500);

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
