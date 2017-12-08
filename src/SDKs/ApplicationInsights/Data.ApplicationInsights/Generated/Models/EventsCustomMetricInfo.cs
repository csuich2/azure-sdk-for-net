// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The custom metric info
    /// </summary>
    public partial class EventsCustomMetricInfo
    {
        /// <summary>
        /// Initializes a new instance of the EventsCustomMetricInfo class.
        /// </summary>
        public EventsCustomMetricInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventsCustomMetricInfo class.
        /// </summary>
        /// <param name="name">The name of the custom metric</param>
        /// <param name="value">The value of the custom metric</param>
        /// <param name="valueSum">The sum of the custom metric</param>
        /// <param name="valueCount">The count of the custom metric</param>
        /// <param name="valueMin">The minimum value of the custom
        /// metric</param>
        /// <param name="valueMax">The maximum value of the custom
        /// metric</param>
        /// <param name="valueStdDev">The standard deviation of the custom
        /// metric</param>
        public EventsCustomMetricInfo(string name = default(string), int? value = default(int?), int? valueSum = default(int?), int? valueCount = default(int?), int? valueMin = default(int?), int? valueMax = default(int?), int? valueStdDev = default(int?))
        {
            Name = name;
            Value = value;
            ValueSum = valueSum;
            ValueCount = valueCount;
            ValueMin = valueMin;
            ValueMax = valueMax;
            ValueStdDev = valueStdDev;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; set; }

        /// <summary>
        /// Gets or sets the sum of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "valueSum")]
        public int? ValueSum { get; set; }

        /// <summary>
        /// Gets or sets the count of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "valueCount")]
        public int? ValueCount { get; set; }

        /// <summary>
        /// Gets or sets the minimum value of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "valueMin")]
        public int? ValueMin { get; set; }

        /// <summary>
        /// Gets or sets the maximum value of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "valueMax")]
        public int? ValueMax { get; set; }

        /// <summary>
        /// Gets or sets the standard deviation of the custom metric
        /// </summary>
        [JsonProperty(PropertyName = "valueStdDev")]
        public int? ValueStdDev { get; set; }

    }
}
