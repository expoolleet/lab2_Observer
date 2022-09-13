using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Main : Form
    {
        private Publisher pub;

        public Main(Publisher pub)
        {
            InitializeComponent();

            this.pub = pub;
        }

        private void SubscribeAll()
        {
            Monitor1 monitor1 = new Monitor1(pub);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (subList.SelectedIndex != -1)
            //{
            //    Form item = subList.Items[subList.SelectedIndex];
                

            //}
        
        }
    }
}
