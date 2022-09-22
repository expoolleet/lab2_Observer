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
    public partial class Monitor1 : Form, ISub
    {
        IPub pub;

        public Monitor1()
        {
            InitializeComponent();
        }

        public Monitor1(IPub publisher)
        {
            InitializeComponent();
            pub = publisher;
        }


        private void Subscribe()
        {
           pub.AddSub(this);

        }

        private void Unsubscribe()
        {
            pub.RemoveSub(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            label1.Text = "Температура: " + temp;
            label2.Text = "Влажность: " + humidity;
            label3.Text = "Давление: " + pressure;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subscribe();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unsubscribe();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Monitor1_Load(object sender, EventArgs e)
        {
            Subscribe();
        }
    }  
}
