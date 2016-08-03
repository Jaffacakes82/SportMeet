//------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Activities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Android.App;
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Android.Views;
    using Android.Widget;
    using Core.Configuration;

    /// <summary>
    /// Main entry point to the application
    /// </summary>
    [Activity(Label = "SportMeet", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        /// <summary>
        /// Entry point for the activity
        /// </summary>
        /// <param name="bundle">The bundle</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ISharedPreferences sharedPrefs = Application.Context.GetSharedPreferences(Configuration.ApplicationName, FileCreationMode.Private);
            string savedUsername = sharedPrefs.GetString("Username", string.Empty);
            string savedPassword = sharedPrefs.GetString("Password", string.Empty);

            if (string.IsNullOrWhiteSpace(savedUsername) || string.IsNullOrWhiteSpace(savedPassword))
            {
                this.StartActivity(typeof(LoginActivity));
                this.Finish();
            }
        }
    }
}