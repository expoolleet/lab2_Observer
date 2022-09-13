﻿using System;
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

        public Monitor1(IPub pub)
        {
            InitializeComponent();
            this.pub = pub;
        }

        private void Subscribe()
        {
            pub.AddSub(this);
        }

        private void Unsubscribe()
        {
            pub.RemoveSub(this);
        }

        public void Update(float temp, float pressure, float humidity)
        {
            label1.Text = "Температура: " + temp;
            label2.Text = "Влажность: " + humidity;
            label3.Text = "Давление: " + pressure;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unsubscribe();
        }
    }

    
}
