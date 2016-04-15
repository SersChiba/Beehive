using Beehive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive
{
    public partial class Form1 : Form
    {
        Queen queen;
        Worker[] workers = new Worker[4];

        public Form1()
        {
            InitializeComponent();

            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring" });
            queen = new Queen(workers);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queen.WorkTheNextShift();
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            queen.AssignWork(workerBeeJob.Text,(int)shifts.Value);
        }
    }
}
