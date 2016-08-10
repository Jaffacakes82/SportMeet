//------------------------------------------------------------------------
// <copyright file="UserService.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core.Entities;
    using Core.Responses;
    using Helpers;
    using RestSharp;
    using SportMeet.Services.Contracts;

    /// <summary>
    /// The service implementation for the user service contract
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Gets or sets the rest service implementation
        /// </summary>
        public virtual IRestService RestService { get; set; }

        /// <summary>
        /// Initialises a new instance of the <see cref="UserService"/> class/> 
        /// </summary>
        public UserService()
        {
            this.RestService = new RestService();
        }

        /// <inheritdoc />
        public bool Register(string username, string emailAddress, string firstName, string lastName, string password)
        {
            GlobalHelpers.NullCheck(username);
            GlobalHelpers.NullCheck(emailAddress);
            GlobalHelpers.NullCheck(firstName);
            GlobalHelpers.NullCheck(lastName);
            GlobalHelpers.NullCheck(password);

            User toRegister = new User(username, emailAddress, firstName, lastName, password);

            GenericResponse response = this.RestService.Post<GenericResponse>("user/register", toRegister);

            if (response != null)
            {
                return response.Success;
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc />
        public string Login(string username, string password)
        {
            GlobalHelpers.NullCheck(username);
            GlobalHelpers.NullCheck(password);

            User toLogin = new User() { Username = username, Password = password };
            LoginResponse response = this.RestService.Post<LoginResponse>("user/login", toLogin);

            if (response != null)
            {
                return response.AuthToken;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
