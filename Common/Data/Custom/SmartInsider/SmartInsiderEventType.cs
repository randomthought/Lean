﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace QuantConnect.Data.Custom.SmartInsider
{
    /// <summary>
    /// Describes what will or has taken place in an execution
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SmartInsiderEventType
    {
        /// <summary>
        /// Board's authority to repurchase.
        /// </summary>
        [EnumMember(Value = "Authorisation")]
        Authorization,

        /// <summary>
        /// Notification of the board that shares will be repurchased.
        /// </summary>
        [EnumMember(Value = "New Intention")]
        Intention,

        /// <summary>
        /// Repurchase transactions that have been actioned.
        /// </summary>
        [EnumMember(Value = "Transaction")]
        Transaction,

        /// <summary>
        /// Unknown - intentions only
        /// </summary>
        [EnumMember(Value = "Upwards Revision")]
        UpwardsRevision,

        /// <summary>
        /// Unknown - intentions only
        /// </summary>
        [EnumMember(Value = "Downwards Revision")]
        DownwardsRevision,

        /// <summary>
        /// Unknown - intentions only
        /// </summary>
        [EnumMember(Value = "Revised Details")]
        RevisedDetails,
    }
}
