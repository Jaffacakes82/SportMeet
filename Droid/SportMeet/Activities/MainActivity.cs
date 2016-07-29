//------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet
{
    using System;
    using Android.App;
    using Android.OS;
    using Android.Widget;

    /// <summary>
    /// Entry point for the application
    /// </summary>
    [Activity(Label = "SportMeet", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        /// <summary>
        /// Entry point for the activity
        /// </summary>
        /// <param name="bundle">Android bundle</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.Main);
            this.AddBindings();
        }

        /// <summary>
        /// Adds event bindings
        /// </summary>
        private void AddBindings()
        {
            Button registerButton = FindViewById<Button>(Resource.Id.ButtonRegister);
            registerButton.Click += this.RegisterButton_Click;

            Button loginButton = FindViewById<Button>(Resource.Id.ButtonLogin);
            loginButton.Click += this.LoginButton_Click;
        }

        /// <summary>
        /// Event handler for the login button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Event handler for the register button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}