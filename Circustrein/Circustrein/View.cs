using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            //Carnivores
            if (rbtnCarnivore.Checked && rbtnSmall.Checked)
            {
                Animal a = new Animal(rbtnCarnivore.Text.ToString(), rbtnSmall.Text.ToString());
                lbAnimals.Items.Add(a);
            }
            else if (rbtnCarnivore.Checked && rbtnMedium.Checked)
            {
                Animal a = new Animal(rbtnCarnivore.Text.ToString(), rbtnMedium.Text.ToString());
                lbAnimals.Items.Add(a);
            }
            else if (rbtnCarnivore.Checked && rbtnLarge.Checked)
            {
                Animal a = new Animal(rbtnCarnivore.Text.ToString(), rbtnLarge.Text.ToString());
                lbAnimals.Items.Add(a);
            }

            //Herbivores
            else if (rbtnHerbivore.Checked && rbtnSmall.Checked)
            {
                Animal a = new Animal(rbtnHerbivore.Text.ToString(), rbtnSmall.Text.ToString());
                lbAnimals.Items.Add(a);
            }
            else if (rbtnHerbivore.Checked && rbtnMedium.Checked)
            {
                Animal a = new Animal(rbtnHerbivore.Text.ToString(), rbtnMedium.Text.ToString());
                lbAnimals.Items.Add(a);
            }
            else if (rbtnHerbivore.Checked && rbtnLarge.Checked)
            {
                Animal a = new Animal(rbtnHerbivore.Text.ToString(), rbtnLarge.Text.ToString());
                lbAnimals.Items.Add(a);
            }
        }

        private void radiobuttonsSize_CheckedChanged(object sender, EventArgs e)
        {
            //if (((RadioButton)sender).Checked)
            //{
            //    MessageBox.Show(sender.);
            //}
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            foreach (var item in lbAnimals.Items)
            {
                lvSortedCoupes.Items.Add(item.ToString());
            }
            
        }
    }
}
