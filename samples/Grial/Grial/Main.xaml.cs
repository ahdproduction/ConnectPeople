﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UXDivers.Artina.Grial
{
	[XamlCompilation (XamlCompilationOptions.Skip)]
	public partial class Main : Application
	{
		public static DateTime MinimumDate = DateTime.Parse("Jan 1 2000");
		public static DateTime MaximumDate = DateTime.Parse("Dec 31 2050");

		public static MasterDetailPage MasterDetailPage;

		static Main() 
		{
			ViewFactory.Register<LoginPage, LoginViewModel> ();
			ViewFactory.Register<HomePage, HomeViewModel> ();
			ViewFactory.Register<MenuPage, MenuViewModel> ();
		}
		public Main ()
		{
			InitializeComponent ();

			MainPage = new NavigationPage (ViewFactory.Create<LoginViewModel> () as Page) {
				Title = "Login"
			};

			MainPage.SetValue (NavigationPage.BarTextColorProperty, Color.White);

		}
		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}