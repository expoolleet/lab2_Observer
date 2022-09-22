using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba2
{
    public partial class Main : Form
    {
        private Publisher pub = new Publisher();

        public Main()
        {
            InitializeComponent();
        }


        private void turnOnButton_Click(object sender, EventArgs e)
        {
            pub.IsBroadcasting = true;
            turnOnButton.Enabled = false;
            turnOffButton.Enabled = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (subList.SelectedIndex != -1)
            {
                var form = Activator.CreateInstance(Type.GetType("laba2." + subList.Items[subList.SelectedIndex].ToString()), pub) as Form;

                form.Show();
            }
        }

        private void turnOffButton_Click(object sender, EventArgs e)
        {
            pub.IsBroadcasting = false;
            turnOnButton.Enabled = true;
            turnOffButton.Enabled = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var matching = Assembly.GetAssembly(typeof(ISub)).GetTypes()
                .Where(type => typeof(ISub)
                .IsAssignableFrom(type) && !type.IsInterface);

            foreach (var name in matching)
            {
                subList.Items.Add(name.Name);
            }

            pub.Notify();
        }

    }
}
