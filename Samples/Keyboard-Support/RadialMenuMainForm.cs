#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Tools;
using System.Runtime.InteropServices;

namespace RadialMenuDemo
{
    public partial class RadialMenuMainForm : MetroForm
    {
        private RadialMenu radialMenu1;

        RadialMenuItem radialMenuItem1 = new RadialMenuItem();
        RadialMenuItem radialMenuItem2 = new RadialMenuItem();
        RadialMenuItem radialMenuItem3 = new RadialMenuItem();
        RadialMenuItem radialMenuItem4 = new RadialMenuItem();
        RadialMenuItem radialMenuItem5 = new RadialMenuItem();
        RadialMenuItem radialMenuItem6 = new RadialMenuItem();
        RadialMenuItem radialMenuItem7 = new RadialMenuItem();
        RadialMenuItem radialMenuItem8 = new RadialMenuItem();
        public RadialMenuMainForm()
        {
            InitializeComponent();


            //ToolTip 
            this.radialMenu1.ShowToolTip = true;

            this.radialMenu1.Size = new Size(180, 180);
            this.radialMenu1.ImageList = imageListAdv1;
            this.radialMenu1.Style =RadialMenuStyle.Office2016Colorful;
            this.radialMenu1.MenuItemImageSize = new Size(27, 27);
            this.radialMenu1.DisplayStyle = DisplayStyle.TextAboveImage;
            this.radialMenu1.WedgeCount = 4;

            this.radialMenuItem5.ImageIndex = 23;
            this.radialMenuItem5.Text = "Edit_items";

            this.radialMenuItem6.ImageIndex = 43;
            this.radialMenuItem6.Text = "Cut_items";

            this.radialMenuItem7.ImageIndex = 56;
            this.radialMenuItem7.Text = "Copy_items";

            this.radialMenuItem7.ImageIndex = 44;
            this.radialMenuItem7.Text = "Paste_items";

            this.radialMenuItem1.ImageIndex = 34;
            this.radialMenuItem1.Text = "Edit";
            this.radialMenuItem1.Items.Add(radialMenuItem5);

            this.radialMenuItem2.ImageIndex = 30;
            this.radialMenuItem2.Text = "Cut";
            this.radialMenuItem2.Items.Add(radialMenuItem6);

            this.radialMenuItem3.ImageIndex = 29;
            this.radialMenuItem3.Text = "Copy";
            this.radialMenuItem3.Items.Add(radialMenuItem7);

            this.radialMenuItem4.ImageIndex = 32;
            this.radialMenuItem4.Text = "Paste";
            this.radialMenuItem4.Items.Add(radialMenuItem8);


            this.radialMenu1.Items.Add(this.radialMenuItem1);
            this.radialMenu1.Items.Add(this.radialMenuItem2);
            this.radialMenu1.Items.Add(this.radialMenuItem3);
            this.radialMenu1.Items.Add(this.radialMenuItem4);
            this.radialMenu1.Items.Add(this.radialMenuItem5);

            SuperAccelerator superAccelerator1 = new SuperAccelerator(this);

            superAccelerator1.SetAccelerator(radialMenuItem1, "E");

            superAccelerator1.SetAccelerator(radialMenuItem2, "C");

            superAccelerator1.SetAccelerator(radialMenuItem3, "X");

            superAccelerator1.SetAccelerator(radialMenuItem4, "P");


            this.radialMenu1.Location = new System.Drawing.Point(339, 97);
            this.radialMenu1.OuterRimThickness = 28;
            this.radialMenu1.Size = new System.Drawing.Size(280, 280);
            this.radialMenu1.Visible = true;
            this.Controls.Add(this.radialMenu1);
        }

    }
}