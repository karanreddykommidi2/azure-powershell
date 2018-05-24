// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Compute.Version_2018_04.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MaintenanceOperationResultCodeTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MaintenanceOperationResultCodeTypes
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "RetryLater")]
        RetryLater,
        [EnumMember(Value = "MaintenanceAborted")]
        MaintenanceAborted,
        [EnumMember(Value = "MaintenanceCompleted")]
        MaintenanceCompleted
    }
    internal static class MaintenanceOperationResultCodeTypesEnumExtension
    {
        internal static string ToSerializedValue(this MaintenanceOperationResultCodeTypes? value)
        {
            return value == null ? null : ((MaintenanceOperationResultCodeTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MaintenanceOperationResultCodeTypes value)
        {
            switch( value )
            {
                case MaintenanceOperationResultCodeTypes.None:
                    return "None";
                case MaintenanceOperationResultCodeTypes.RetryLater:
                    return "RetryLater";
                case MaintenanceOperationResultCodeTypes.MaintenanceAborted:
                    return "MaintenanceAborted";
                case MaintenanceOperationResultCodeTypes.MaintenanceCompleted:
                    return "MaintenanceCompleted";
            }
            return null;
        }

        internal static MaintenanceOperationResultCodeTypes? ParseMaintenanceOperationResultCodeTypes(this string value)
        {
            switch( value )
            {
                case "None":
                    return MaintenanceOperationResultCodeTypes.None;
                case "RetryLater":
                    return MaintenanceOperationResultCodeTypes.RetryLater;
                case "MaintenanceAborted":
                    return MaintenanceOperationResultCodeTypes.MaintenanceAborted;
                case "MaintenanceCompleted":
                    return MaintenanceOperationResultCodeTypes.MaintenanceCompleted;
            }
            return null;
        }
    }
}