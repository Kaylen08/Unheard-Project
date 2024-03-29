﻿using Prism;
using Prism.Ioc;
using Appointments.Services;
using Appointments.Services.Interfaces;
using PrismMapsExample.ViewModels;
using Appointments.ViewModels;
using Appointments.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Appointments
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage/NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IDatabase, UnheardDatabase>();
            containerRegistry.RegisterSingleton<ISecurityService, FakeSecurityService>();
            containerRegistry.Register<IContentPackage, ZipContentPackage>();



            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
            containerRegistry.RegisterForNavigation<SetAppointmentPage, SetAppointmentPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();

            containerRegistry.RegisterForNavigation<SignUp, SignUpViewModel>();
            containerRegistry.RegisterForNavigation<ChatWithProfessionalPage, ChatWithProfessionalPageViewModel>();
            containerRegistry.RegisterForNavigation<StartDiaryPage, StartDiaryPageViewModel>();
            containerRegistry.RegisterForNavigation<LogOutPage, LogOutPageViewModel>();
            containerRegistry.RegisterForNavigation<AppointmentInfo, AppointmentInfoViewModel>();
            containerRegistry.RegisterForNavigation<PersonalDiary, PersonalDiaryViewModel>();
         
        }
    }
}
