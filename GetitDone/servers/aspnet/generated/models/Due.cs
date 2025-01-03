// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Getitdone.Service.Models
{

    public partial class Due
    {
        public string Date { get; set; }

        [JsonPropertyName("is_recurring")]
        public bool IsRecurring { get; set; }

        public string Datetime { get; set; }

        public string String { get; set; }

        public string Timezone { get; set; }


    }
}
