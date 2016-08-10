//------------------------------------------------------------------------
// <copyright file="LoginActivity.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet
{
    using System;
    using Activities;
    using Android.App;
    using Android.OS;
    using Android.Views;
    using Android.Views.Animations;
    using Android.Widget;
    using Services.Contracts;
    using Services.Services;

    /// <summary>
    /// Entry point for the application
    /// </summary>
    [Activity(Label = "SportMeet")]
    public class LoginActivity : Activity
    {
        /// <summary>
        /// Gets or sets the username text
        /// </summary>
        public virtual EditText UsernameText { get; set; }

        /// <summary>
        /// Gets or sets the password text
        /// </summary>
        public virtual EditText PasswordText { get; set; }

        /// <summary>
        /// Gets or sets the login button
        /// </summary>
        public virtual Button LoginButton { get; set; }

        /// <summary>
        /// Gets or sets the register button
        /// </summary>
        public virtual Button RegisterButton { get; set; }

        /// <summary>
        /// Gets or sets the user service
        /// </summary>
        public virtual new IUserService UserService { get; set; }

        /// <summary>
        /// Entry point for the activity
        /// </summary>
        /// <param name="bundle">Android bundle</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.Login);
            this.SetProperties();
            this.AddBindings();

            ImageView tickImage = FindViewById<ImageView>(Resource.Id.ImageRegistrationSuccessful);
            TextView succesText = FindViewById<TextView>(Resource.Id.TextRegistrationSuccessful);
            tickImage.Visibility = ViewStates.Invisible;
            succesText.Visibility = ViewStates.Invisible;

            bool registrationSuccess = this.Intent.GetBooleanExtra("RegistrationSuccess", false);

            if (registrationSuccess)
            {
                tickImage.Visibility = ViewStates.Visible;
                succesText.Visibility = ViewStates.Visible;
                tickImage.StartAnimation(AnimationUtils.LoadAnimation(this.ApplicationContext, Resource.Animation.fade_in));
                succesText.StartAnimation(AnimationUtils.LoadAnimation(this.ApplicationContext, Resource.Animation.fade_in));
            }
        }

        private void SetProperties()
        {
            this.RegisterButton = FindViewById<Button>(Resource.Id.ButtonRegister);
            this.LoginButton = FindViewById<Button>(Resource.Id.ButtonLogin);
            this.UsernameText = FindViewById<EditText>(Resource.Id.TextUsername);
            this.PasswordText = FindViewById<EditText>(Resource.Id.TextPassword);
            this.UserService = new UserService();
        }

        /// <summary>
        /// Adds event bindings
        /// </summary>
        private void AddBindings()
        {
            this.RegisterButton.Click += this.RegisterButton_Click;
            this.LoginButton.Click += this.LoginButton_Click;
        }

        /// <summary>
        /// Event handler for the login button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.UsernameText.Text) ||
                string.IsNullOrWhiteSpace(this.PasswordText.Text))
            {
                AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Please complete all fields.");
                dialog.SetPositiveButton("OK", (senderAlert, args) => { });
                dialog.Show();
            }
            else
            {
                string authToken = this.UserService.Login(this.UsernameText.Text, this.PasswordText.Text);
            }
        }

        /// <summary>
        /// Event handler for the register button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.StartActivity(typeof(RegisterActivity));
        }
    }
}