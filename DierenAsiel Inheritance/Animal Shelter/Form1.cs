using System;
using System.Windows.Forms;
using Animal_Shelter.Animals; 
using System.Collections.Generic;

namespace Animal_Shelter
{
    public partial class Form1 : Form
    {
        private Reservation reservations = new Reservation();
        public Form1()
        {
            InitializeComponent(); 
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBadHabits.Enabled = this.cmbSpecies.Text == "Cat"; 

        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Gender gender = radMale.Checked ? Gender.Male : Gender.Female;
          
            if (this.cmbSpecies.Text == "Cat")
            {
                this.reservations.NewCat(txtName.Text, gender, txtBadHabits.Text);
                this.btnReserveCat.Enabled = true;
            }
            else if (this.cmbSpecies.Text == "Dog")
            {
                this.reservations.NewDog(txtName.Text, gender);
                this.btnReserveDog.Enabled = true;
            }

            RefreshList();
        }

        private void RefreshList()
        { 
            //Haal alle bestaande dieren uit de lijst  
            lbAnimals.Items.Clear(); 
            //Ladd alle dieren uit de lijst in de listbox
            foreach (Animal a in reservations.Animals)
            {
                lbAnimals.Items.Add(a);
            }
        }

        private void btnReserveCat_Click(object sender, EventArgs e)
        { 
            //Kijk of het gekozen Dier een kat is 
            if (lbAnimals.SelectedItem is Cat)
            { 
                //Cast het geselecteerde item om naar een kat
                Cat cat = lbAnimals.SelectedItem as Cat;
                
                //Kijk of de naam van een reserveerder niet leeg is 
                if (!string.IsNullOrWhiteSpace(txtReservor.Text))
                { 
                    //Reserveer de kat
                    cat.Reserve(txtReservor.Text);
                } 
                //Geef een foutmelding als de naam van de reseveerder niet ingevuld is 
                else
                {
                    MessageBox.Show("Voer de naam van de Reserveerder in!");
                }
            }
            //Geef een foutmelding als het gekozen dier geen kat is 
            else {
                MessageBox.Show("Het gekozen dier is geen Hond");
            }
            RefreshList();
        }

        private void btnReserveDog_Click(object sender, EventArgs e)
        {

            if (lbAnimals.SelectedItem is Dog)
            {
                Dog dog = lbAnimals.SelectedItem as Dog;

                if (!string.IsNullOrWhiteSpace(txtReservor.Text))
                {
                    dog.Reserve(txtReservor.Text);
                }
                else
                {
                    MessageBox.Show("Voer de naam van de Reserveerder in!");
                }
            }

            else
            {
                MessageBox.Show("Het gekozen dier is geen Hond");
            }
            RefreshList();

        }
    }
}
