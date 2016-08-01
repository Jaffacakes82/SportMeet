//------------------------------------------------------------------------
// <copyright file="IRegisterService.cs" company="Joseph Ellis Software">
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
    using SportMeet.Services.Contracts;

    /// <summary>
    /// The service implementation for the registration contract
    /// </summary>
    public class RegisterService : IRegisterService
    {
        /// <inheritdoc />
        public bool Register(string username, string email, string firstName, string lastName, string passwordOne, string passwordTwo)
        {
            throw new NotImplementedException();
        }
    }
}
