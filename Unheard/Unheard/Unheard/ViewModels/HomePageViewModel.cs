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
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                ImageUrl = "Darkness.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                ImageUrl = "Depressed.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                ImageUrl = "Help.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Squirrel Monkey",
                Location = "Central & South America",
                Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                ImageUrl = "Negative.jpg"
            });

            depress.Add(new Depress
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                Details = "The golden lion tamarin also known as the golden marmoset, is a small New World monkey of the family Callitrichidae.",
                ImageUrl = "Broken.png"
            });

            Depress = new ObservableCollection<Depress>(depress);
        }
    }
}

