//------------------------------------------------------------------------
// <copyright file="GlobalHelpers.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Services.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Global helpers class, for trivial tasks.
    /// </summary>
    public static class GlobalHelpers
    {
        /// <summary>
        /// Performs a null check on the parameter
        /// </summary>
        /// <param name="var"></param>
        public static void NullCheck(object param)
        {
            if (param is string)
            {
                if (string.IsNullOrWhiteSpace((string)param))
                {
                    throw new ArgumentNullException("param");
                }
            }
            else
            {
                if (param == null)
                {
                    throw new ArgumentNullException("param");
                }
            }
        }
    }
}
