﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using formation.ViewModels;

namespace formation.Views
{
    public partial class MonAgePage : ContentPage
    {
        PersonneViewModel viewModel;
        public MonAgePage()
        {
            viewModel = new PersonneViewModel();
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}
