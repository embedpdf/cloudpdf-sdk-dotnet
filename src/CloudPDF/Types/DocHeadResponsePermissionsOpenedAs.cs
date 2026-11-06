using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocHeadResponsePermissionsOpenedAs.DocHeadResponsePermissionsOpenedAsSerializer)
)]
[Serializable]
public readonly record struct DocHeadResponsePermissionsOpenedAs : IStringEnum
{
    public static readonly DocHeadResponsePermissionsOpenedAs None = new(Values.None);

    public static readonly DocHeadResponsePermissionsOpenedAs User = new(Values.User);

    public static readonly DocHeadResponsePermissionsOpenedAs Owner = new(Values.Owner);

    public DocHeadResponsePermissionsOpenedAs(string value)
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
    public static DocHeadResponsePermissionsOpenedAs FromCustom(string value)
    {
        return new DocHeadResponsePermissionsOpenedAs(value);
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

    public static bool operator ==(DocHeadResponsePermissionsOpenedAs value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHeadResponsePermissionsOpenedAs value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHeadResponsePermissionsOpenedAs value) => value.Value;

    public static explicit operator DocHeadResponsePermissionsOpenedAs(string value) => new(value);

    internal class DocHeadResponsePermissionsOpenedAsSerializer
        : JsonConverter<DocHeadResponsePermissionsOpenedAs>
    {
        public override DocHeadResponsePermissionsOpenedAs Read(
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
            return new DocHeadResponsePermissionsOpenedAs(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHeadResponsePermissionsOpenedAs value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHeadResponsePermissionsOpenedAs ReadAsPropertyName(
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
            return new DocHeadResponsePermissionsOpenedAs(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHeadResponsePermissionsOpenedAs value,
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
        public const string None = "none";

        public const string User = "user";

        public const string Owner = "owner";
    }
}
