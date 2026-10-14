using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCancel200ResponseStatus.DocSignaturesCancel200ResponseStatusSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCancel200ResponseStatus : IStringEnum
{
    public static readonly DocSignaturesCancel200ResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly DocSignaturesCancel200ResponseStatus AlreadyCompleted = new(
        Values.AlreadyCompleted
    );

    public static readonly DocSignaturesCancel200ResponseStatus Unknown = new(Values.Unknown);

    public DocSignaturesCancel200ResponseStatus(string value)
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
    public static DocSignaturesCancel200ResponseStatus FromCustom(string value)
    {
        return new DocSignaturesCancel200ResponseStatus(value);
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

    public static bool operator ==(DocSignaturesCancel200ResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesCancel200ResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCancel200ResponseStatus value) =>
        value.Value;

    public static explicit operator DocSignaturesCancel200ResponseStatus(string value) =>
        new(value);

    internal class DocSignaturesCancel200ResponseStatusSerializer
        : JsonConverter<DocSignaturesCancel200ResponseStatus>
    {
        public override DocSignaturesCancel200ResponseStatus Read(
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
            return new DocSignaturesCancel200ResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCancel200ResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCancel200ResponseStatus ReadAsPropertyName(
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
            return new DocSignaturesCancel200ResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCancel200ResponseStatus value,
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
        public const string Cancelled = "cancelled";

        public const string AlreadyCompleted = "already-completed";

        public const string Unknown = "unknown";
    }
}
