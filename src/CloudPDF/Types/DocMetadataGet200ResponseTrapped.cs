using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocMetadataGet200ResponseTrapped.DocMetadataGet200ResponseTrappedSerializer))]
[Serializable]
public readonly record struct DocMetadataGet200ResponseTrapped : IStringEnum
{
    public static readonly DocMetadataGet200ResponseTrapped True = new(Values.True);

    public static readonly DocMetadataGet200ResponseTrapped False = new(Values.False);

    public static readonly DocMetadataGet200ResponseTrapped Unknown = new(Values.Unknown);

    public DocMetadataGet200ResponseTrapped(string value)
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
    public static DocMetadataGet200ResponseTrapped FromCustom(string value)
    {
        return new DocMetadataGet200ResponseTrapped(value);
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

    public static bool operator ==(DocMetadataGet200ResponseTrapped value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocMetadataGet200ResponseTrapped value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocMetadataGet200ResponseTrapped value) => value.Value;

    public static explicit operator DocMetadataGet200ResponseTrapped(string value) => new(value);

    internal class DocMetadataGet200ResponseTrappedSerializer
        : JsonConverter<DocMetadataGet200ResponseTrapped>
    {
        public override DocMetadataGet200ResponseTrapped Read(
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
            return new DocMetadataGet200ResponseTrapped(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocMetadataGet200ResponseTrapped value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocMetadataGet200ResponseTrapped ReadAsPropertyName(
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
            return new DocMetadataGet200ResponseTrapped(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocMetadataGet200ResponseTrapped value,
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
        public const string True = "true";

        public const string False = "false";

        public const string Unknown = "unknown";
    }
}
