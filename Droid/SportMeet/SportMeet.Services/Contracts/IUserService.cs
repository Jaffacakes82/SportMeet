//------------------------------------------------------------------------
// <copyright file="IUserService.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The contract for the user service
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Registers the user with the system
        /// </summary>
        /// <param name="username">The users username</param>
        /// <param name="email">The users email</param>
        /// <param name="firstName">The users first name</param>
        /// <param name="lastName">The users last name</param>
        /// <param name="passwordOne">The users password</param>
        /// <param name="passwordTwo">The users repeated password</param>
        /// <returns>True or false, depending on whether registration failed</returns>
        bool Register(string username, string email, string firstName, string lastName, string passwordOne, string passwordTwo);
    }
}
