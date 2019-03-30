using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    class FormOpg5 : Form
    {
        //    Write an application with a button and a textbox.When the button is clicked, show a
        //    messagebox with the txt from the textbox.
        private Button btnButton;
        private TextBox txtTextbox;

        public FormOpg5()
        {
            btnButton = new Button();
            txtTextbox = new TextBox();

            btnButton.Location = new Point(100, 100);
            btnButton.Text = "Show MessageBox";
            btnButton.Size = new Size(100, 50);

            btnButton.Click += BtnButton_Click;

            Controls.Add(btnButton);
            Controls.Add(txtTextbox);
        }

        private void BtnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtTextbox.Text);
        }
    }
}