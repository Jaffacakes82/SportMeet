//------------------------------------------------------------------------
// <copyright file="IRestService.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

using SportMeet.Core.Entities;

namespace SportMeet.Services.Contracts
{
    /// <summary>
    /// The rest service contract
    /// </summary>
    public interface IRestService
    {
        /// <summary>
        /// GETs a resource from a URL
        /// </summary>
        /// <param name="url">The URL to GET</param>
        /// <returns>The response</returns>
        T Get<T>(string url) where T : new();

        /// <summary>
        /// POSTs a resource to a URL
        /// </summary>
        /// <param name="url">The URL to POST to</param>
        /// <returns>The response</returns>
        T Post<T>(string url, object obj) where T : new();
    }
}
