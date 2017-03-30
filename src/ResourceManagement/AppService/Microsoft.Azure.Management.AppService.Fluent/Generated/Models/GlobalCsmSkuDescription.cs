// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// A Global SKU Description.
    /// </summary>
    public partial class GlobalCsmSkuDescription
    {
        /// <summary>
        /// Initializes a new instance of the GlobalCsmSkuDescription class.
        /// </summary>
        public GlobalCsmSkuDescription() { }

        /// <summary>
        /// Initializes a new instance of the GlobalCsmSkuDescription class.
        /// </summary>
        /// <param name="name">Name of the resource SKU.</param>
        /// <param name="tier">Service Tier of the resource SKU.</param>
        /// <param name="capacity">Min, max, and default scale values of the
        /// SKU.</param>
        /// <param name="locations">Locations of the SKU.</param>
        /// <param name="capabilities">Capabilities of the SKU, e.g., is
        /// traffic manager enabled?</param>
        public GlobalCsmSkuDescription(string name = default(string), string tier = default(string), SkuCapacity capacity = default(SkuCapacity), System.Collections.Generic.IList<string> locations = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<CapabilityInner> capabilities = default(System.Collections.Generic.IList<CapabilityInner>))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            Locations = locations;
            Capabilities = capabilities;
        }

        /// <summary>
        /// Gets or sets name of the resource SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets service Tier of the resource SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets min, max, and default scale values of the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public SkuCapacity Capacity { get; set; }

        /// <summary>
        /// Gets or sets locations of the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "locations")]
        public System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets capabilities of the SKU, e.g., is traffic manager
        /// enabled?
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capabilities")]
        public System.Collections.Generic.IList<CapabilityInner> Capabilities { get; set; }

    }
}