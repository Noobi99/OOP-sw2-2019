using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion4ConsoleApp
{
    class Program
    {
        // COM threading model
        [STAThread]
        static void Main(string[] args)
        {
            // Application.Run(new FormOpg0());
            //Application.Run(new FormOpg1());
            //Application.Run(new FormOpg2());
            //Application.Run(new FormOpg3());
            //Application.Run(new FormOpg4());
            //Application.Run(new FormOpg5());
            Application.Run(new FormOpg7());
        }
    }
    class FormOpg0 : Form
    {
        // Kaldes komponenter
        private Label lblHello;
        private Button btnHello;
        private NumberButton nbtnHello;

        public FormOpg0()
        {
            // Laver instans af klasserne
            lblHello = new Label();
            btnHello = new Button();
            nbtnHello = new NumberButton(1);

            // initialisering
            Controls.Add(lblHello);
            Controls.Add(btnHello);
            Controls.Add(nbtnHello);

            lblHello.Location = new Point(12, 9);
            lblHello.Text = "Hello world";
            

            // x starter fra toppen og y starter fra venstre i point
            btnHello.Location = new Point(32, 36);
            btnHello.Text = "Tryk";
            // Click er et event og der tilføjes flere handlers
            btnHello.Click += BtnAdd_Click;
            btnHello.DoubleClick += BtnAdd_Click;

            nbtnHello.Location = new Point(100, 100);

        }

        // object sender er hvem det er, og eventargs e er parametrene
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        
    }

    class FormOpg6 : Form
    {
//        Write an application with nine buttons numbered from 0 to 9 (similar to the dialpad on a mobile
//        phone).
        
          
    }

    class FormOpg7 : Form
    {
//        7. Write a calculator application inspired by the dialpad control from today’s lecture.
        private NumberPanel numberpanel;
        private TextBox txtInput;

        public FormOpg7()
        {
            numberpanel = new NumberPanel();
            txtInput = new TextBox();

            numberpanel.NumberClick += NumberPanel_NumberClick;
            numberpanel.Size = new Size(150, 150);

            txtInput.Size = new Size(250, 120);
            txtInput.Location = new Point(1, 150);

            Controls.Add(numberpanel);
            Controls.Add(txtInput);
        }

        private void NumberPanel_NumberClick(object sender, int e)
        {
            
        }
    }

}
