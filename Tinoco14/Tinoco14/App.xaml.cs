using System;
using Tinoco14.DataContext;
using Tinoco14.Interfaces;
using Tinoco14.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tinoco14
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new MatriculaView();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
