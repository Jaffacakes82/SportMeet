//------------------------------------------------------------------------
// <copyright file="RegisterActivity.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Activities
{
    using Android.App;
    using Android.OS;
    using Android.Text;
    using Android.Widget;
    using Services.Contracts;

    /// <summary>
    /// The Register Activity
    /// </summary>
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        /// <summary>
        /// Gets or sets the username text from the form
        /// </summary>
        private EditText UsernameText { get; set; }
        /// <summary>
        /// Gets or sets the email text from the form
        /// </summary>
        private EditText EmailText { get; set; }

        /// <summary>
        /// Gets or sets the first name text from the form
        /// </summary>
        private EditText FirstNameText { get; set; }

        /// <summary>
        /// Gets or sets the last name text from the form
        /// </summary>
        private EditText LastNameText { get; set; }

        /// <summary>
        /// Gets or sets the password one text from the form
        /// </summary>
        private EditText PasswordOneText { get; set; }

        /// <summary>
        /// Gets or sets the password two text from the form
        /// </summary>
        private EditText PasswordTwoText { get; set; }

        /// <summary>
        /// Gets or sets the register confirmation button
        /// </summary>
        private Button RegisterConfirmButton { get; set; }

        /// <summary>
        /// Gets or sets the register cancel button
        /// </summary>
        private Button RegisterCancelButton { get; set; }

        /// <summary>
        /// Gets or sets the register service
        /// </summary>
        private IRegisterService RegisterService { get; set; }

        /// <summary>
        /// Entry point for the register activity
        /// </summary>
        /// <param name="savedInstanceState">Saved instance state bundle</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.Register);
            this.SetProperties();
            this.AddBindings();
        }

        /// <summary>
        /// Sets form properties
        /// </summary>
        private void SetProperties()
        {
            this.RegisterConfirmButton = this.FindViewById<Button>(Resource.Id.ButtonRegisterConfirm);
            this.RegisterCancelButton = this.FindViewById<Button>(Resource.Id.ButtonRegisterCancel);
            this.UsernameText = this.FindViewById<EditText>(Resource.Id.TextRegisterUsername);
            this.EmailText = this.FindViewById<EditText>(Resource.Id.TextRegisterEmail);
            this.FirstNameText = this.FindViewById<EditText>(Resource.Id.TextRegisterFirstName);
            this.LastNameText = this.FindViewById<EditText>(Resource.Id.TextRegisterLastName);
            this.PasswordOneText = this.FindViewById<EditText>(Resource.Id.TextRegisterPasswordOne);
            this.PasswordTwoText = this.FindViewById<EditText>(Resource.Id.TextRegisterPasswordTwo);
        }

        /// <summary>
        /// Add event bindings
        /// </summary>
        private void AddBindings()
        {
            this.RegisterConfirmButton.Click += this.RegisterConfirmButton_Click;
            this.RegisterCancelButton.Click += this.RegisterCancelButton_Click;
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
            if (string.IsNullOrWhiteSpace(this.UsernameText.Text) ||
                string.IsNullOrWhiteSpace(this.EmailText.Text) ||
                string.IsNullOrWhiteSpace(this.FirstNameText.Text) ||
                string.IsNullOrWhiteSpace(this.LastNameText.Text) ||
                string.IsNullOrWhiteSpace(this.PasswordOneText.Text) ||
                string.IsNullOrWhiteSpace(this.PasswordTwoText.Text))
            {
                AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Please complete all fields.");
                dialog.SetPositiveButton("OK", (senderAlert, args) => { });
                dialog.Show();
            }
            else if (this.PasswordOneText.Text.Trim() != this.PasswordTwoText.Text.Trim())
            {
                AlertDialog.Builder dialog = new AlertDialog.Builder(this);
                dialog.SetTitle("Passwords do not match.");
                dialog.SetPositiveButton("OK", (senderAlert, args) => { });
                dialog.Show();
            }
            else
            {
                
            }
        }
    }
}