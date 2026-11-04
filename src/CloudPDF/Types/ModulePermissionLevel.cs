using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(ModulePermissionLevel.ModulePermissionLevelSerializer))]
[Serializable]
public readonly record struct ModulePermissionLevel : IStringEnum
{
    public static readonly ModulePermissionLevel Document = new(Values.Document);

    public static readonly ModulePermissionLevel Tenant = new(Values.Tenant);

    public ModulePermissionLevel(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ModulePermissionLevel FromCustom(string value)
    {
        return new ModulePermissionLevel(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ModulePermissionLevel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ModulePermissionLevel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ModulePermissionLevel value) => value.Value;

    public static explicit operator ModulePermissionLevel(string value) => new(value);

    internal class ModulePermissionLevelSerializer : JsonConverter<ModulePermissionLevel>
    {
        public override ModulePermissionLevel Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new ModulePermissionLevel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ModulePermissionLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ModulePermissionLevel ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new ModulePermissionLevel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ModulePermissionLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Document = "document";

        public const string Tenant = "tenant";
    }
}
