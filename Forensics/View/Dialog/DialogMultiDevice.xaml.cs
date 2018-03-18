﻿using Forensics.ViewModel.Dialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Forensics.View.Dialog
{
    /// <summary>
    /// Interaction logic for DialogMultiDevice.xaml
    /// </summary>
    public partial class DialogMultiDevice : Window
    {
        public DialogMultiDevice()
        {
            InitializeComponent();

            this.DataContext = new DialogMultiDeviceModel();
        }
    }
}