// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.ContosoProviderHub.Service.Models
{

    ///<summary>
    /// Localized display information for and operation.
    ///</summary>
    public partial class OperationDisplay
    {
        ///<summary>
        /// The localized friendly form of the resource provider name, e.g. "Microsoft
        /// toring Insights" or "Microsoft Compute".
        ///</summary>
        public string Provider { get; set; }

        ///<summary>
        /// The localized friendly name of the resource type related to this operation.
        ///  "Virtual Machines" or "Job Schedule Collections".
        ///</summary>
        public string Resource { get; set; }

        ///<summary>
        /// The concise, localized friendly name for the operation; suitable for
        /// downs. E.g. "Create or Update Virtual Machine", "Restart Virtual Machine".
        ///</summary>
        public string Operation { get; set; }

        ///<summary>
        /// The short, localized friendly description of the operation; suitable for
        ///  tips and detailed views.
        ///</summary>
        public string Description { get; set; }


    }
}
