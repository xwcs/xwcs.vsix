﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form5_DNF : Form
    {
        public Form5_DNF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            memoEdit1.Text += xwcs.core.linq.BoolExpressionHelper.ToDNF(textEdit1.Text);
        }
    }
}
