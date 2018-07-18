﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace Sample_WPF_1
{
    public class ViewModelClass : ReactiveObject
    {
        private string _fullName;
        private string _lastName;
        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                this.RaiseAndSetIfChanged(ref _firstName, value);
                UpdateFullName();

            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                this.RaiseAndSetIfChanged(ref _lastName, value);
                UpdateFullName();

            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                this.RaiseAndSetIfChanged(ref _fullName, value);
            }
        }

        private void UpdateFullName()
        {
            FullName = $"{FirstName} {LastName}";
        }


        public ViewModelClass()
        {
            FirstName = "Jon";
            LastName = "Snow";
        }
    }
}
