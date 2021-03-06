﻿using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// DemandFeature
    /// </summary>
    public enum DemandFeature
    {
        /// <summary>
        /// Has Demand Feature
        /// </summary>
        [Description("Has Demand Feature")]
        HasDemandFeature = 0,
        /// <summary>
        /// NoDemandFeature
        /// </summary>
        NoDemandFeature = 1
    }
}