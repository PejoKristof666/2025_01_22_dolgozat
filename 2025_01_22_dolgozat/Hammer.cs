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
    class Hammer : Tools
    {
        public string HammerMaterial { get; set; }
        public Hammer(string types, string materials, string hammerMaterials) : base(types,materials)
        {
            HammerMaterial = hammerMaterials;
            ClickTools();
        }

        public override void ClickTools()
        {
            this.Click += (s, e) =>
            {
                MessageBox.Show($"Az anyaga: {material} | A nyelének az anyaga: {HammerMaterial}");
            };
        }
    }
}
