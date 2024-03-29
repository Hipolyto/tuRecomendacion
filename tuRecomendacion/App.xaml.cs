﻿namespace tuRecomendacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            base.OnStart();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            base.OnSleep();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            base.OnResume();
        }

        public override void CloseWindow(Window window)
        {
            base.CloseWindow(window);
            // Handle when the window is closed
        }
    }
}
