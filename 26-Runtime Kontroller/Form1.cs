using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Runtime_Kontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button();
            //button.Text = "Buton 1";
            //button.Width = 100;
            //button.Height = 30;
            //this.Controls.Add(button);
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = $"Buton {i+1}";
                btn.Width = 100;
                btn.Height = 30;
                btn.Top = i * 30;
                this.Controls.Add(btn);
            }

        }
    }
}
