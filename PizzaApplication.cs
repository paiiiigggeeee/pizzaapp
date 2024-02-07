using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class PizzaApplication : Form
    {
        public PizzaApplication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculatePrice_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void calculatePricebtn_Click(object sender, EventArgs e)
        {
            //The following if statements contain integers and variables that pertain to the pizza options selected by the user.
            if (margheritabtn.Checked == true)
            {
                int price = 12;
                int calories = 276;
                //The totalPrice integer is calculated based off calories in respective if statement and toppings price variable. 
                int totalPrice = toppingsPrice(price); 
                //The totalCalories integer is calculated based off calories in respective if statment and toppings calorie variable. 
                int totalCalories = toppingsCalories(calories);

                //The user's text input in the textboxes are defined below and converted
                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);

                //A background image is uploaded from the following path when this if statement is executed 
                BackgroundImage = Image.FromFile(@"C:/C#/PizzaApplication/Margherita-Pizza-5.jpg");
            }

            if (fourCheeseBtn.Checked == true)
            {
                //The following if statements contain integers and variables that pertain to the pizza options selected by the user.
                int price = 10;
                int calories = 200;

                //The totalPrice integer is calculated based off calories in respective if statement and toppings price variable. 
                int totalPrice = toppingsPrice(price);
                //The totalCalories integer is calculated based off calories in respective if statment and toppings calorie variable. 
                int totalCalories = toppingsCalories(calories);


                //The user's text input in the textboxes are defined below and converted
                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);

                //A background image is uploaded from the following path when this if statement is executed 
                BackgroundImage = Image.FromFile(@"C:/C#/PizzaApplication/fourcheese.jpg");
            }
            if (veggieBtn.Checked == true)
            {
                //The following if statements contain integers and variables that pertain to the pizza options selected by the user.
                int price = 11;
                int calories = 240;

                //The totalPrice integer is calculated based off calories in respective if statement and toppings price variable. 
                int totalPrice = toppingsPrice(price);
                //The totalCalories integer is calculated based off calories in respective if statment and toppings calorie variable. 
                int totalCalories = toppingsCalories(calories);


                //The user's text input in the textboxes are defined below and converted
                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);

                //A background image is uploaded from the following path when this if statement is executed 
                BackgroundImage = Image.FromFile(@"C:/C#/PizzaApplication/veggiepizza.jpg");
            }
            if (meatLoverBtn.Checked == true)
            {
                //The following if statements contain integers and variables that pertain to the pizza options selected by the user.
                int price = 13;
                int calories = 300;

                //The totalPrice integer is calculated based off calories in respective if statement and toppings price variable. 
                int totalPrice = toppingsPrice(price);
                //The totalCalories integer is calculated based off calories in respective if statment and toppings calorie variable. 
                int totalCalories = toppingsCalories(calories);


                //The user's text input in the textboxes are defined below and converted
                priceTextBox.Text = Convert.ToString(totalPrice);
                caloriesTextBox.Text = Convert.ToString(totalCalories);

                //A background image is uploaded from the following path when this if statement is executed 
                BackgroundImage = Image.FromFile(@"C:/C#/PizzaApplication/meatloverspizza.jpg");
            }


        }

        //Below if counter statements are created in response to the event of checkboxes being selected by the user
        private int checkedCheckBoxes()
        {
            int counter = 0; //counter is defined as starting at 0
            ///***The below if statements indicate that if a user selects any of the following toppings boxes, 
            ///the counter will add one to the initial integer of 0.
            ///
         
            if (extraCheeseBox.Checked == true)
            {
                counter++;
            }
            if (extraVeggiesbox.Checked == true)
            {
                counter++;
            }
            if (gfBox.Checked == true)
            {
                counter++;
            }
            
            // The value of the counter after the if statements is returned.
            return counter;
        }

        //Below the price of toppings is defined.
        private int toppingsPrice(int price)
        {
            int checkedBoxes = checkedCheckBoxes();
            int addDollars = 1 * checkedBoxes; //Multiply number of checked boxes by 1 dollar.
            price = price + addDollars; //Added dollars from toppings is added to total pizza price. 
            return price;

        }

        //Below the calories of toppings is defined.
        private int toppingsCalories(int calories)
        {
            int checkedBoxes = checkedCheckBoxes();
            int addCalories = 20 * checkedBoxes; //Mulitply number of checked boxes by 20 calories.
            calories = calories + addCalories; //Added calories from toppings is added to total pizza calories.
            return calories;

        }


        private void meatLoverBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
