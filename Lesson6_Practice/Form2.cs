﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6_Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        internal void UpdateLabel(object sender, MyObject myObject)
        {
            label1.Text = myObject.Description;
        }
    }
}
