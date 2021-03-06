﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WindowsProject
{
    public partial class WindowsPhoneControl1 : UserControl
    {
        public WindowsPhoneControl1()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            GetPersons personInst = GetPersons.getPersonInst();

            PeopleListBox.ItemsSource = personInst.getPersonList();
            //PeopleListBox1.ItemsSource = personInst.getPersonList();
            title.Text = personInst.City;
        }

        private void PeopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PeopleListBox.SelectedIndex == -1)
                return;

            Person selectedPerson = ((sender as ListBox).SelectedItem as Person);
            MessageBox.Show("ListBox selected: " + selectedPerson);

            PeopleListBox.SelectedIndex = -1;
        }
        
    }
}
