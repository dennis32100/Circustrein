using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circustrein.Common;

namespace Circustrein
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            
            Animal a = new Animal(AnimalDiet.Carnivore, AnimalSize.Small);
            Animal b = new Animal(AnimalDiet.Herbivore, AnimalSize.Medium);
            Animal c = new Animal(AnimalDiet.Carnivore, AnimalSize.Medium);
            Animal d = new Animal(AnimalDiet.Herbivore, AnimalSize.Large);
            Animal e = new Animal(AnimalDiet.Carnivore, AnimalSize.Large);
            Animal f = new Animal(AnimalDiet.Herbivore, AnimalSize.Medium);
            Animal g = new Animal(AnimalDiet.Carnivore, AnimalSize.Medium);
            Animal h = new Animal(AnimalDiet.Carnivore, AnimalSize.Small);
            Animal i = new Animal(AnimalDiet.Herbivore, AnimalSize.Medium);
            Animal j = new Animal(AnimalDiet.Herbivore, AnimalSize.Medium);

            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(b);
            animals.Add(c);
            animals.Add(d);
            animals.Add(e);
            animals.Add(f);
            animals.Add(g);
            animals.Add(h);
            animals.Add(i);
            animals.Add(j);

            Algorithm algo = new Algorithm();
            List<Coupe> sorted = algo.SortAnimalsIntoCoupes(animals);

            foreach (var coupe in sorted)
            {
                Console.WriteLine("CoupeNr: " + coupe.coupeN.ToString());
                foreach (var animal in coupe.AnimalsInCoupe)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            //Carnivores
            if (rbtnCarnivore.Checked && rbtnSmall.Checked)
            {
                //Animal a = new Animal(rbtnCarnivore.Text.ToString(), rbtnSmall.Text.ToString());
                Animal a = new Animal(AnimalDiet.Carnivore, AnimalSize.Small);
                lbAnimals.Items.Add(a);
            }
            else if (rbtnCarnivore.Checked && rbtnMedium.Checked)
            {
                //Animal a = new Animal(rbtnCarnivore.Text.ToString(), rbtnMedium.Text.ToString());
                Animal a = new Animal(AnimalDiet.Carnivore, AnimalSize.Medium);
                lbAnimals.Items.Add(a);
            }
            else if (rbtnCarnivore.Checked && rbtnLarge.Checked)
            {
                //Animal a = new Animal(rbtnCarnivore.Text.ToString(), rbtnLarge.Text.ToString());
                Animal a = new Animal(AnimalDiet.Carnivore, AnimalSize.Large);
                lbAnimals.Items.Add(a);
            }

            //Herbivores
            else if (rbtnHerbivore.Checked && rbtnSmall.Checked)
            {
                //Animal a = new Animal(rbtnHerbivore.Text.ToString(), rbtnSmall.Text.ToString());
                Animal a = new Animal(AnimalDiet.Herbivore, AnimalSize.Small);
                lbAnimals.Items.Add(a);
            }
            else if (rbtnHerbivore.Checked && rbtnMedium.Checked)
            {
                //Animal a = new Animal(rbtnHerbivore.Text.ToString(), rbtnMedium.Text.ToString());
                Animal a = new Animal(AnimalDiet.Herbivore, AnimalSize.Medium);
                lbAnimals.Items.Add(a);
            }
            else if (rbtnHerbivore.Checked && rbtnLarge.Checked)
            {
                //Animal a = new Animal(rbtnHerbivore.Text.ToString(), rbtnLarge.Text.ToString());
                Animal a = new Animal(AnimalDiet.Herbivore, AnimalSize.Large);
                lbAnimals.Items.Add(a);
            }
            else
            {
                MessageBox.Show("Select both the diet and size of the animal");
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
