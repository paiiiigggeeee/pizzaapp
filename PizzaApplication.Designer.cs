
namespace PizzaApplication
{
    partial class PizzaApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.margheritabtn = new System.Windows.Forms.RadioButton();
            this.meatLoverBtn = new System.Windows.Forms.RadioButton();
            this.fourCheeseBtn = new System.Windows.Forms.RadioButton();
            this.veggieBtn = new System.Windows.Forms.RadioButton();
            this.calculatePrice = new System.Windows.Forms.Button();
            this.additionalToppingsLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.extraVeggiesbox = new System.Windows.Forms.CheckBox();
            this.extraCheeseBox = new System.Windows.Forms.CheckBox();
            this.gfBox = new System.Windows.Forms.CheckBox();
            this.calculatePricebtn = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.caloriesTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Select your pizza option: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // margheritabtn
            // 
            this.margheritabtn.AutoSize = true;
            this.margheritabtn.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.margheritabtn.Location = new System.Drawing.Point(38, 159);
            this.margheritabtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.margheritabtn.Name = "margheritabtn";
            this.margheritabtn.Size = new System.Drawing.Size(197, 35);
            this.margheritabtn.TabIndex = 3;
            this.margheritabtn.TabStop = true;
            this.margheritabtn.Text = "&Margherita";
            this.margheritabtn.UseVisualStyleBackColor = true;
            this.margheritabtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // meatLoverBtn
            // 
            this.meatLoverBtn.AutoSize = true;
            this.meatLoverBtn.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meatLoverBtn.Location = new System.Drawing.Point(38, 212);
            this.meatLoverBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.meatLoverBtn.Name = "meatLoverBtn";
            this.meatLoverBtn.Size = new System.Drawing.Size(200, 35);
            this.meatLoverBtn.TabIndex = 4;
            this.meatLoverBtn.TabStop = true;
            this.meatLoverBtn.Text = "Meat &Lover ";
            this.meatLoverBtn.UseVisualStyleBackColor = true;
            this.meatLoverBtn.CheckedChanged += new System.EventHandler(this.meatLoverBtn_CheckedChanged);
            // 
            // fourCheeseBtn
            // 
            this.fourCheeseBtn.AutoSize = true;
            this.fourCheeseBtn.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourCheeseBtn.Location = new System.Drawing.Point(38, 265);
            this.fourCheeseBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.fourCheeseBtn.Name = "fourCheeseBtn";
            this.fourCheeseBtn.Size = new System.Drawing.Size(207, 35);
            this.fourCheeseBtn.TabIndex = 5;
            this.fourCheeseBtn.TabStop = true;
            this.fourCheeseBtn.Text = "&Four Cheese";
            this.fourCheeseBtn.UseVisualStyleBackColor = true;
            // 
            // veggieBtn
            // 
            this.veggieBtn.AutoSize = true;
            this.veggieBtn.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veggieBtn.Location = new System.Drawing.Point(38, 318);
            this.veggieBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.veggieBtn.Name = "veggieBtn";
            this.veggieBtn.Size = new System.Drawing.Size(125, 35);
            this.veggieBtn.TabIndex = 6;
            this.veggieBtn.TabStop = true;
            this.veggieBtn.Text = "&Veggie";
            this.veggieBtn.UseVisualStyleBackColor = true;
            // 
            // calculatePrice
            // 
            this.calculatePrice.Location = new System.Drawing.Point(219, 1338);
            this.calculatePrice.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.calculatePrice.Name = "calculatePrice";
            this.calculatePrice.Size = new System.Drawing.Size(396, 65);
            this.calculatePrice.TabIndex = 7;
            this.calculatePrice.Text = "Show me the price:";
            this.calculatePrice.UseVisualStyleBackColor = true;
            this.calculatePrice.Click += new System.EventHandler(this.calculatePrice_Click);
            // 
            // additionalToppingsLabel
            // 
            this.additionalToppingsLabel.AutoSize = true;
            this.additionalToppingsLabel.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalToppingsLabel.Location = new System.Drawing.Point(31, 408);
            this.additionalToppingsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.additionalToppingsLabel.Name = "additionalToppingsLabel";
            this.additionalToppingsLabel.Size = new System.Drawing.Size(417, 40);
            this.additionalToppingsLabel.TabIndex = 8;
            this.additionalToppingsLabel.Text = "&Additional Toppings:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(79, 1070);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(226, 41);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Extra Cheese";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 1198);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(308, 41);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TRIPLE the cheese";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 1338);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show me the calories:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // extraVeggiesbox
            // 
            this.extraVeggiesbox.AutoSize = true;
            this.extraVeggiesbox.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraVeggiesbox.Location = new System.Drawing.Point(31, 467);
            this.extraVeggiesbox.Name = "extraVeggiesbox";
            this.extraVeggiesbox.Size = new System.Drawing.Size(228, 35);
            this.extraVeggiesbox.TabIndex = 12;
            this.extraVeggiesbox.Text = "Extra &Veggies";
            this.extraVeggiesbox.UseVisualStyleBackColor = true;
            // 
            // extraCheeseBox
            // 
            this.extraCheeseBox.AutoSize = true;
            this.extraCheeseBox.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraCheeseBox.Location = new System.Drawing.Point(31, 514);
            this.extraCheeseBox.Name = "extraCheeseBox";
            this.extraCheeseBox.Size = new System.Drawing.Size(222, 35);
            this.extraCheeseBox.TabIndex = 13;
            this.extraCheeseBox.Text = "Extra C&heese";
            this.extraCheeseBox.UseVisualStyleBackColor = true;
            // 
            // gfBox
            // 
            this.gfBox.AutoSize = true;
            this.gfBox.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gfBox.Location = new System.Drawing.Point(31, 570);
            this.gfBox.Name = "gfBox";
            this.gfBox.Size = new System.Drawing.Size(287, 35);
            this.gfBox.TabIndex = 14;
            this.gfBox.Text = "&Gluten Free Crust";
            this.gfBox.UseVisualStyleBackColor = true;
            // 
            // calculatePricebtn
            // 
            this.calculatePricebtn.BackColor = System.Drawing.Color.OrangeRed;
            this.calculatePricebtn.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePricebtn.Location = new System.Drawing.Point(31, 632);
            this.calculatePricebtn.Name = "calculatePricebtn";
            this.calculatePricebtn.Size = new System.Drawing.Size(202, 88);
            this.calculatePricebtn.TabIndex = 16;
            this.calculatePricebtn.Text = "&Calculate";
            this.calculatePricebtn.UseVisualStyleBackColor = false;
            this.calculatePricebtn.Click += new System.EventHandler(this.calculatePricebtn_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(225, 757);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(282, 44);
            this.priceTextBox.TabIndex = 17;
            // 
            // caloriesTextBox
            // 
            this.caloriesTextBox.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesTextBox.Location = new System.Drawing.Point(225, 824);
            this.caloriesTextBox.Name = "caloriesTextBox";
            this.caloriesTextBox.Size = new System.Drawing.Size(282, 44);
            this.caloriesTextBox.TabIndex = 18;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(32, 757);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(117, 36);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "&Price:";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLabel.Location = new System.Drawing.Point(32, 832);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(167, 36);
            this.caloriesLabel.TabIndex = 20;
            this.caloriesLabel.Text = "C&alories:";
            // 
            // PizzaApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 922);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.caloriesTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.calculatePricebtn);
            this.Controls.Add(this.gfBox);
            this.Controls.Add(this.extraCheeseBox);
            this.Controls.Add(this.extraVeggiesbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.additionalToppingsLabel);
            this.Controls.Add(this.calculatePrice);
            this.Controls.Add(this.veggieBtn);
            this.Controls.Add(this.fourCheeseBtn);
            this.Controls.Add(this.meatLoverBtn);
            this.Controls.Add(this.margheritabtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "PizzaApplication";
            this.Text = "Create Your Own Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton margheritabtn;
        private System.Windows.Forms.RadioButton meatLoverBtn;
        private System.Windows.Forms.RadioButton fourCheeseBtn;
        private System.Windows.Forms.RadioButton veggieBtn;
        private System.Windows.Forms.Button calculatePrice;
        private System.Windows.Forms.Label additionalToppingsLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox extraVeggiesbox;
        private System.Windows.Forms.CheckBox extraCheeseBox;
        private System.Windows.Forms.CheckBox gfBox;
        private System.Windows.Forms.Button calculatePricebtn;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox caloriesTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label caloriesLabel;
    }
}

