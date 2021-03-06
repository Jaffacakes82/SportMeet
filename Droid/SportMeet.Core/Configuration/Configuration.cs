﻿//------------------------------------------------------------------------
// <copyright file="Configuration.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Core.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Static configuration class
    /// </summary>
    public static class Configuration
    {
#if DEBUG
        /// <summary>
        /// The base URL for the API
        /// </summary>
        public const string BaseUrl = "http://10.0.2.2:3000/api";
#endif
        public const string ApplicationName = "Squash";
    }
}
