using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingStartedDemo
{
    public partial class Form1 : Form
    {
        private RadialMenu radialMenu2;
        public Form1()
        {
            InitializeComponent();
           
            this.radialMenu2 = new Syncfusion.Windows.Forms.Tools.RadialMenu();
            this.radialMenu2.Location = new System.Drawing.Point(39, 97);
            this.radialMenu2.MaximumSize = new System.Drawing.Size(700, 700);
            this.radialMenu2.MinimumSize = new System.Drawing.Size(180, 180);
            this.radialMenu2.Name = "radialMenu1";
            this.radialMenu2.OuterRimThickness = 28;
            this.radialMenu2.Size = new System.Drawing.Size(280, 280);
            this.radialMenu2.TabIndex = 2;
            this.radialMenu2.UseIndexBasedOrder = true;
            this.radialMenu2.Visible = true;

        }
    }
}
