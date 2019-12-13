using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Appointments.Model;

namespace Appointments.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private ObservableCollection<Depress> _depress;
        public ObservableCollection<Depress> Depress
        {
            get { return _depress; }
            set { SetProperty(ref _depress, value); }
        }

        private int _carosuelPosition;
        public int CarosualPosition
        {
            get { return _carosuelPosition; }
            set { SetProperty(ref _carosuelPosition, value); }
        }

        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);

            PopulateMonkeys();
        }

        void PopulateMonkeys()
        {
            List<Depress> depress = new List<Depress>();


            depress.Add(new Depress
            {
                Name = "Sadness",
                Location = "",
                Details = "",
                ImageUrl = "Darkness.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Stress",
                Location = "",
                Details = "",
                ImageUrl = "Depressed.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Doubt",
                Location = "",
                Details = "",
                ImageUrl = "Help.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Negativity",
                Location = "",
                Details = "",
                ImageUrl = "Negative.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Broken",
                Location = "",
                Details = "",
                ImageUrl = "Broken.png"
            });

            Depress = new ObservableCollection<Depress>(depress);
        }
    }
}

