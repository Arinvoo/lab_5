using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_5
{
    public partial class Form1 : Form
    {
        private Bread currentBread;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateBread_Click(object sender, EventArgs e)
        {
            // Використовуємо Builder для створення нового хліба
            BakeryBuilder builder = new BakeryBuilder();
            currentBread = builder
                .SetName(txtName.Text)
                .SetFlourType(txtFlourType.Text)
                .AddSeeds(chkSeeds.Checked)
                .SetGlutenFree(chkGlutenFree.Checked)
                .Build();

            // Показуємо інформацію про створений хліб
            lblBreadInfo.Text = currentBread.ToString();
        }

        private void btnCloneBread_Click(object sender, EventArgs e)
        {
            if (currentBread != null)
            {
                // Клонуємо хліб
                Bread clonedBread = (Bread)currentBread.Clone();
                lblClonedBreadInfo.Text = "Cloned: " + clonedBread.ToString();
            }
            else
            {
                MessageBox.Show("Please create a bread first!");
            }
        }
    }
}
