using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    class FormOpg4 : Form
    {
        //    Write an application with a textbox and a button.When the button is clicked, the text in the
        //    textbox should be capitalized.
        private TextBox txtCity;
        private Button btnCapitalize;
        
        public FormOpg4()
        {
            txtCity = new TextBox();
            btnCapitalize = new Button();


            // Button properties
            btnCapitalize.Location = new Point(100, 100);
            btnCapitalize.Text = "Capitalize";

            btnCapitalize.Click += BtnCapitalize_Click;

            Controls.Add(txtCity);
            Controls.Add(btnCapitalize);
        }

        private void BtnCapitalize_Click(object sender, EventArgs e)
        {
            txtCity.Text = txtCity.Text.ToUpper();
        }
    }
}