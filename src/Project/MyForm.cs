﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            Child child = new Child();
            child.ExecuteOrder666();
        }
    }
}
