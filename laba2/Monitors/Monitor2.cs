using System;
using System.Windows.Forms;
using laba2.Interfaces;

namespace laba2.Monitors
{
    internal partial class Monitor2 : Form, ISub
    {
        private IPub pub;

        public Monitor2()
        {
            InitializeComponent();
        }

        public Monitor2(IPub publisher)
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
            labelTemp.Text = "Температура: " + temp;
            labelHumidity.Text = "Влажность: " + humidity;
            labelPressure.Text = "Давление: " + pressure;
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            Subscribe();
            buttonSub.Enabled = false;
            buttonUnsub.Enabled = true;
        }

        private void unsubButton_Click(object sender, EventArgs e)
        {
            Unsubscribe();
            buttonSub.Enabled = true;
            buttonUnsub.Enabled = false;
        }

        private void Monitor2_Load(object sender, EventArgs e)
        {
            Subscribe();
        }
    }
}
