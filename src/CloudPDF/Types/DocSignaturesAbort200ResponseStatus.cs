using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAbort200ResponseStatus.DocSignaturesAbort200ResponseStatusSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAbort200ResponseStatus : IStringEnum
{
    public static readonly DocSignaturesAbort200ResponseStatus Aborted = new(Values.Aborted);

    public static readonly DocSignaturesAbort200ResponseStatus AlreadyCompleted = new(
        Values.AlreadyCompleted
    );

    public static readonly DocSignaturesAbort200ResponseStatus Unknown = new(Values.Unknown);

    public DocSignaturesAbort200ResponseStatus(string value)
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
    public static DocSignaturesAbort200ResponseStatus FromCustom(string value)
    {
        return new DocSignaturesAbort200ResponseStatus(value);
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

    public static bool operator ==(DocSignaturesAbort200ResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesAbort200ResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAbort200ResponseStatus value) =>
        value.Value;

    public static explicit operator DocSignaturesAbort200ResponseStatus(string value) => new(value);

    internal class DocSignaturesAbort200ResponseStatusSerializer
        : JsonConverter<DocSignaturesAbort200ResponseStatus>
    {
        public override DocSignaturesAbort200ResponseStatus Read(
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
            return new DocSignaturesAbort200ResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAbort200ResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAbort200ResponseStatus ReadAsPropertyName(
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
            return new DocSignaturesAbort200ResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAbort200ResponseStatus value,
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
        public const string Aborted = "aborted";

        public const string AlreadyCompleted = "already-completed";

        public const string Unknown = "unknown";
    }
}
