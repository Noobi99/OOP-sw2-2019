using System;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    class FormOpg2 : Form
    {
        //        2. Write an application with a single button with the text Click Me! When the button is clicked,
        //    change its text to You Clicked! and disable the button.iv
        private Button btnClick;

        public FormOpg2()
        {
            btnClick = new Button();

            btnClick.Text = "Click Me!";
            btnClick.Click += BtnClick_Click;

            Controls.Add(btnClick);
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "You Clicked!";
            (sender as Button).Enabled = false;
        }
    }
}