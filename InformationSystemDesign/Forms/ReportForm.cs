﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystemDesign.Controllers;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm(List<ReportValue> reportValues)
        {
            InitializeComponent();
            _reportGridView.DataSource = reportValues;
        }
    }
}
