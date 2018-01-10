﻿namespace Microsoft.Azure.ApplicationInsights.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// An intervaled metric result data.
    /// </summary>
    public class MetricsIntervaledResult
    {
        /// <summary>
        /// Gets start time of the metric.
        /// </summary>
        public string Start { get; internal set; }

        /// <summary>
        /// Gets start time of the metric.
        /// </summary>
        public string End { get; internal set; }

        /// <summary>
        /// The interval used to segment the data.
        /// </summary>
        public string Interval { get; internal set; }

        /// <summary>
        /// The intervals of data.
        /// </summary>
        public IList<MetricsIntervaledData> Intervals { get; internal set; }
    }
}
