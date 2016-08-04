//------------------------------------------------------------------------
// <copyright file="RestService.cs" company="Joseph Ellis Software">
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
    using Core.Configuration;
    using Core.Entities;
    using Helpers;
    using RestSharp;
    using SportMeet.Services.Contracts;

    /// <summary>
    /// The rest service implementation
    /// </summary>
    public class RestService : IRestService
    {
        /// <inheritdoc />
        public T Get<T>(string url) where T : new()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public T Post<T>(string url, object obj) where T : new()
        {
            GlobalHelpers.NullCheck(url);
            GlobalHelpers.NullCheck(obj);

            RestClient client = new RestClient(Configuration.BaseUrl);
            RestRequest request = new RestRequest(url, Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddObject(obj);

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                return default(T);
            }

            return response.Data;
        }
    }
}
