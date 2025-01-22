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
    class Tools : UserControl
    {
        public Label label1;

        public string type { get; set; }
        public string material { get; set; }
        public Tools(string types, string materials)
        {
            InitializeComponent();
            type = types;
            material = materials;
            LabelName();
            ClickTools();
            
        }
        public void LabelName()
        {
            label1.Text = type;
        }
        public virtual void ClickTools()
        {
            this.Click += (s, e) =>
            {
                MessageBox.Show($"Az anyaga: {material}");
            };
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Tools
            // 
            this.Controls.Add(this.label1);
            this.Name = "Tools";
            this.Size = new System.Drawing.Size(91, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
