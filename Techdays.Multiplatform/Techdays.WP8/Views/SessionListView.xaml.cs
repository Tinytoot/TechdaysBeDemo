﻿using Cirrious.MvvmCross.WindowsPhone.Views;
using Techdays.Core.ViewModels.Sessions;

namespace Techdays.WP8.Views
{
    public partial class SessionListView : BaseSessionListView
    {
        public SessionListView()
        {
            InitializeComponent();
        }
    }

    public class BaseSessionListView : MvxPhonePage<SessionListViewModel>
    {

    }
}