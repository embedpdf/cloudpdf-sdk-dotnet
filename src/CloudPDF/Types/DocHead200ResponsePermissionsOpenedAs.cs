using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocHead200ResponsePermissionsOpenedAs.DocHead200ResponsePermissionsOpenedAsSerializer)
)]
[Serializable]
public readonly record struct DocHead200ResponsePermissionsOpenedAs : IStringEnum
{
    public static readonly DocHead200ResponsePermissionsOpenedAs None = new(Values.None);

    public static readonly DocHead200ResponsePermissionsOpenedAs User = new(Values.User);

    public static readonly DocHead200ResponsePermissionsOpenedAs Owner = new(Values.Owner);

    public DocHead200ResponsePermissionsOpenedAs(string value)
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
    public static DocHead200ResponsePermissionsOpenedAs FromCustom(string value)
    {
        return new DocHead200ResponsePermissionsOpenedAs(value);
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

    public static bool operator ==(DocHead200ResponsePermissionsOpenedAs value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHead200ResponsePermissionsOpenedAs value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHead200ResponsePermissionsOpenedAs value) =>
        value.Value;

    public static explicit operator DocHead200ResponsePermissionsOpenedAs(string value) =>
        new(value);

    internal class DocHead200ResponsePermissionsOpenedAsSerializer
        : JsonConverter<DocHead200ResponsePermissionsOpenedAs>
    {
        public override DocHead200ResponsePermissionsOpenedAs Read(
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
            return new DocHead200ResponsePermissionsOpenedAs(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHead200ResponsePermissionsOpenedAs value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHead200ResponsePermissionsOpenedAs ReadAsPropertyName(
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
            return new DocHead200ResponsePermissionsOpenedAs(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHead200ResponsePermissionsOpenedAs value,
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
