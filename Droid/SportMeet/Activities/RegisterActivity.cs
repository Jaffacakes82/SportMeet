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
        }
    }
}