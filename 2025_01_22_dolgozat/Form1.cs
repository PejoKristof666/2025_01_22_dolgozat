using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_22_dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Start();
        }
        public void Start()
        {
            Tools Shovel = new Tools("Shovel", "Fém");
            this.Controls.Add(Shovel);

            Hammer hammer = new Hammer("Hammer","Fém", "Fa markolat") { Top = Shovel.Top + 60 };
            this.Controls.Add(hammer);

            Screwdriver screwdriver = new Screwdriver("Screwdriver","","Csillagfej") { Top = Shovel.Top + 120 };
            this.Controls.Add(screwdriver);
        }
    }
}
