﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsComplex
{
    public partial class Platerscrystal : Form
    {
        public Platerscrystal()
        {
            InitializeComponent();
        }

        private void Platerscrystal_Load(object sender, EventArgs e)
        {
            player1.Refresh();
        }
    }
}
