using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    public class NumberButton : Button
    {
        private int _number;

        public NumberButton(int number)
        {
            _number = number;
            this.Text = _number.ToString();
        }

        // Kalder den oprindelige constructor
        public NumberButton(int number, Point point) : this(number)
        {
            this.Location = point;
        }

        protected override void OnClick(EventArgs e)
        {
            // Husk og kald base klassen Button click
            base.OnClick(e);

            // Denne er null, hvis der er koblet handlers til   
            if (NumberClick != null)
            {
                NumberClick(this, _number);
            }
        }

        // Parameteriseret med den type som den giver med.
        public event EventHandler<int> NumberClick;
    }
}
