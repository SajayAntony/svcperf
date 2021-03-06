﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EtlViewer.Viewer.Controls
{
    /// <summary>
    /// Interaction logic for EventDetails.xaml
    /// </summary>
    internal partial class EventDetails : Window
    {
        public EventDetails()
        {
            InitializeComponent();
            SystemCommandHandler.Bind(this);
            this.KeyDown += (s, e) =>
                {
                    if (e.Key == Key.Escape)
                    {
                        this.Hide();
                    }
                };
        }
    }
}
