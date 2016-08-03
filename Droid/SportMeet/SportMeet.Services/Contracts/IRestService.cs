//------------------------------------------------------------------------
// <copyright file="IRestService.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

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
        string Get(string url);

        /// <summary>
        /// POSTs a resource to a URL
        /// </summary>
        /// <param name="url">The URL to POST to</param>
        /// <returns>The response</returns>
        string Post(string url);
    }
}
