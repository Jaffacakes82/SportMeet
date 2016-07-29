//------------------------------------------------------------------------
// <copyright file="RegisterActivity.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Activities
{
    using Android.App;
    using Android.OS;
    using Android.Widget;

    /// <summary>
    /// The Register Activity
    /// </summary>
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        /// <summary>
        /// Entry point for the register activity
        /// </summary>
        /// <param name="savedInstanceState">Saved instance state bundle</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.Register);
            this.AddBindings();
        }

        /// <summary>
        /// Add event bindings
        /// </summary>
        private void AddBindings()
        {
            Button registerConfirmButton = this.FindViewById<Button>(Resource.Id.ButtonRegisterConfirm);
            registerConfirmButton.Click += this.RegisterConfirmButton_Click;

            Button registerCancelButton = this.FindViewById<Button>(Resource.Id.ButtonRegisterCancel);
            registerCancelButton.Click += this.RegisterCancelButton_Click;
        }

        /// <summary>
        /// Event handler for registration cancellation
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void RegisterCancelButton_Click(object sender, System.EventArgs e)
        {
            this.StartActivity(typeof(MainActivity));
        }

        /// <summary>
        /// Event handler for registration confirmation
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event arguments</param>
        private void RegisterConfirmButton_Click(object sender, System.EventArgs e)
        {
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            dialog.SetTitle("Passwords do not match.");
            dialog.SetPositiveButton("OK", (senderAlert, args) => { });
            dialog.Show();
        }
    }
}