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
    class Screwdriver : Tools
    {
        public string ScrewDriverHeadType { get; set; }
        public Screwdriver(string types, string materials, string ScrewDriverHeadTypes) : base(types, materials)
        {
            ScrewDriverHeadType = ScrewDriverHeadTypes;
            ClickTools();
        }
        public override void ClickTools()
        {
            this.Click += (s, e) =>
            {
                MessageBox.Show($"Az anyaga: {material} | A csavarhúzó fejtipusa: {ScrewDriverHeadType}");
            };
        }
    }
}
