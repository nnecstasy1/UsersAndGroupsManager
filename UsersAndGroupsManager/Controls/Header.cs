﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndGroupsManager.Controls
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        internal void UpdateLabel(string v)
        {
            lblHeaderText.Text = v;
        }
    }
}
