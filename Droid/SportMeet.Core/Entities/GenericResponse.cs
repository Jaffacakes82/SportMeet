//------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------
namespace SportMeet.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contract or the API response
    /// </summary>
    public class GenericResponse
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="GenericResponse"/> class /> 
        /// </summary>
        public GenericResponse()
        {
        }

        /// <summary>
        /// Gets or sets whether the request was a success
        /// </summary>
        public virtual bool Success { get; set; }
    }
}
