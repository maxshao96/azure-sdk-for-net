namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VirtualMachineSizeTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VirtualMachineSizeTypes
    {
        [EnumMember(Value = "Basic_A0")]
        BasicA0,
        [EnumMember(Value = "Basic_A1")]
        BasicA1,
        [EnumMember(Value = "Basic_A2")]
        BasicA2,
        [EnumMember(Value = "Basic_A3")]
        BasicA3,
        [EnumMember(Value = "Basic_A4")]
        BasicA4,
        [EnumMember(Value = "Standard_A0")]
        StandardA0,
        [EnumMember(Value = "Standard_A1")]
        StandardA1,
        [EnumMember(Value = "Standard_A2")]
        StandardA2,
        [EnumMember(Value = "Standard_A3")]
        StandardA3,
        [EnumMember(Value = "Standard_A4")]
        StandardA4,
        [EnumMember(Value = "Standard_A5")]
        StandardA5,
        [EnumMember(Value = "Standard_A6")]
        StandardA6,
        [EnumMember(Value = "Standard_A7")]
        StandardA7,
        [EnumMember(Value = "Standard_A8")]
        StandardA8,
        [EnumMember(Value = "Standard_A9")]
        StandardA9,
        [EnumMember(Value = "Standard_G1")]
        StandardG1,
        [EnumMember(Value = "Standard_G2")]
        StandardG2,
        [EnumMember(Value = "Standard_G3")]
        StandardG3,
        [EnumMember(Value = "Standard_G4")]
        StandardG4,
        [EnumMember(Value = "Standard_G5")]
        StandardG5
    }
}