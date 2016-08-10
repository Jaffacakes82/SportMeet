//------------------------------------------------------------------------
// <copyright file="User.cs" company="Joseph Ellis Software">
//     Copyright (c) Joseph Ellis Software. All rights reserved.
// </copyright>
//------------------------------------------------------------------------

namespace SportMeet.Core.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The user entity (used for serialisation etc.)
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="User"/> class /> 
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="User" /> class /> 
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="username">The username</param>
        /// <param name="emailAddress">The email address</param>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="passwordOne">The password one</param>
        /// <param name="passwordTwo">The password two</param>
        public User(Guid id, string username, string emailAddress, string firstName, string lastName, string password)
        {
            this.Id = id;
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="User" /> class /> 
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="emailAddress">The email address</param>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        /// <param name="passwordOne">The password one</param>
        /// <param name="passwordTwo">The password two</param>
        public User(string username, string emailAddress, string firstName, string lastName, string password)
        {
            this.Id = Guid.NewGuid();
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
        }

        /// <summary>
        /// Gets or sets the users Id
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the users authentication token
        /// </summary>
        public virtual string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets the users username
        /// </summary>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the users email address
        /// </summary>
        public virtual string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user first name
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the users last name
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Gets or sets the users password one
        /// </summary>
        public virtual string Password { get; set; }
    }
}
