using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    class NumberPanel : UserControl
    {

        public event EventHandler<int> NumberClick;

        public NumberPanel()
        {
            SetupNumberButtons();
        }

        void ButtonNumberClick(object sender, int number)
        {
            if (NumberClick != null)
                NumberClick(this, number);

            
        }

        private void SetupNumberButtons()
        {
            NumberButton[] buttons = new NumberButton[10];
            for (int buttonIndex = 0; buttonIndex < 9; buttonIndex++) // initialize 1-9
            {
                int xPosition = ((buttonIndex % 3) * 30);
                int yPosition = (2 - ((buttonIndex - (buttonIndex % 3)) / 3)) * 30;
                NumberButton numberButton = new NumberButton(buttonIndex + 1);
                numberButton.Location = new Point(xPosition, yPosition);
                numberButton.Size = new Size(25, 25);
                buttons[buttonIndex] = numberButton;
            }
            buttons[9] = new NumberButton(0, new Point(0, 90)); // initialize 0
            buttons[9].Size = new Size(3 * 25, 25);
            this.SuspendLayout();
            foreach (NumberButton button in buttons)
            {
                this.Controls.Add(button);
                button.NumberClick += ButtonNumberClick;
            }
            this.ResumeLayout();
        }

    }
}
