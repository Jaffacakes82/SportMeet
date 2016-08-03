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
    using RestSharp;
    using SportMeet.Services.Contracts;

    /// <summary>
    /// The service implementation for the user service contract
    /// </summary>
    public class UserService : IUserService
    {
        /// <inheritdoc />
        public bool Register(string username, string emailAddress, string firstName, string lastName, string passwordOne, string passwordTwo)
        {
            throw new NotImplementedException();
        }
    }
}
