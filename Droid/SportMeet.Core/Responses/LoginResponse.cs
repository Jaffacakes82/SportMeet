//------------------------------------------------------------------------
// <copyright file="LoginResponse.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Core.Responses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The response received from the login request
    /// </summary>
    public class LoginResponse : GenericResponse
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="LoginResponse" /> class/> 
        /// </summary>
        public LoginResponse()
        {
        }

        /// <summary>
        /// Gets or sets the authentication token
        /// </summary>
        public virtual string AuthToken { get; set; }
    }
}
