﻿using System;

using Xamarin.Forms;
using DIRC.View;

namespace DIRC {
	public class App : Application {
		public App() {
			// The root page of your application
			MainPage = new NavigationPage(new LogonView());
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}

