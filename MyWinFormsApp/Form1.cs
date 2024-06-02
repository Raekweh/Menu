using System;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Create a button
            Button myButton = new Button();
            myButton.Text = "Click Me";
            myButton.Location = new System.Drawing.Point(50, 50);
            myButton.Click += new EventHandler(MyButton_Click);
            
            // Add the button to the form
            this.Controls.Add(myButton);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
