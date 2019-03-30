using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    class FormOpg3 : Form
    {
//        Write an application with a label and a button.When the button is clicked, change the text of
//        the label to You Clicked! 
        private Label lblLabel;
        private Button btnButton;

        public FormOpg3()
        {
            lblLabel = new Label();
            btnButton = new Button();

            lblLabel.Text = "Not Clicked";
            btnButton.Text = "Click";

            btnButton.Location = new Point(100, 100);

            Controls.Add(lblLabel);
            Controls.Add(btnButton);

            btnButton.Click += BtnClick_Click;
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            lblLabel.Text = "You Clicked!";
        }
    }
}