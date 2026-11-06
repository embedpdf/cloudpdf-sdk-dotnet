using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocHeadResponseAccessReasonsItem.DocHeadResponseAccessReasonsItemSerializer))]
[Serializable]
public readonly record struct DocHeadResponseAccessReasonsItem : IStringEnum
{
    public static readonly DocHeadResponseAccessReasonsItem Password = new(Values.Password);

    public static readonly DocHeadResponseAccessReasonsItem Cdn = new(Values.Cdn);

    public static readonly DocHeadResponseAccessReasonsItem PermissionsUnknown = new(
        Values.PermissionsUnknown
    );

    public DocHeadResponseAccessReasonsItem(string value)
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
    public static DocHeadResponseAccessReasonsItem FromCustom(string value)
    {
        return new DocHeadResponseAccessReasonsItem(value);
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

    public static bool operator ==(DocHeadResponseAccessReasonsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHeadResponseAccessReasonsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHeadResponseAccessReasonsItem value) => value.Value;

    public static explicit operator DocHeadResponseAccessReasonsItem(string value) => new(value);

    internal class DocHeadResponseAccessReasonsItemSerializer
        : JsonConverter<DocHeadResponseAccessReasonsItem>
    {
        public override DocHeadResponseAccessReasonsItem Read(
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
            return new DocHeadResponseAccessReasonsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHeadResponseAccessReasonsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHeadResponseAccessReasonsItem ReadAsPropertyName(
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
            return new DocHeadResponseAccessReasonsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHeadResponseAccessReasonsItem value,
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
        public const string Password = "password";

        public const string Cdn = "cdn";

        public const string PermissionsUnknown = "permissions-unknown";
    }
}
