// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Getitdone.Models
{
    /// <summary> The Collaborator. </summary>
    public partial class Collaborator
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal Collaborator(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        internal Collaborator(string id, string name, string email, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Name = name;
            Email = email;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Gets the Id. </summary>
        public string Id { get; }

        /// <summary> Gets the Name. </summary>
        public string Name { get; }

        /// <summary> Gets the Email. </summary>
        public string Email { get; }
    }
}
