﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Serialization
{
    /// <summary>
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2: Page
    {
        private new MainWindow Parent;

        public Task2()
        {
            InitializeComponent();
        }
        public Task2(MainWindow window) : this()
        {
            Parent = window;
        }
    }
}