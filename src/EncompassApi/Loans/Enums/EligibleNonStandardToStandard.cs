﻿using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// EligibleNonStandardToStandard
    /// </summary>
    public enum EligibleNonStandardToStandard
    {
        /// <summary>
        /// May
        /// </summary>
        May = 0,
        /// <summary>
        /// May Not
        /// </summary>
        [EnumMember(Value = "May Not")]
        MayNot = 1
    }
}