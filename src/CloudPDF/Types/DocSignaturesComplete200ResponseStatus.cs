using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete200ResponseStatus.DocSignaturesComplete200ResponseStatusSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete200ResponseStatus : IStringEnum
{
    public static readonly DocSignaturesComplete200ResponseStatus Completed = new(Values.Completed);

    public static readonly DocSignaturesComplete200ResponseStatus AlreadyCompleted = new(
        Values.AlreadyCompleted
    );

    public DocSignaturesComplete200ResponseStatus(string value)
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
    public static DocSignaturesComplete200ResponseStatus FromCustom(string value)
    {
        return new DocSignaturesComplete200ResponseStatus(value);
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

    public static bool operator ==(DocSignaturesComplete200ResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesComplete200ResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesComplete200ResponseStatus value) =>
        value.Value;

    public static explicit operator DocSignaturesComplete200ResponseStatus(string value) =>
        new(value);

    internal class DocSignaturesComplete200ResponseStatusSerializer
        : JsonConverter<DocSignaturesComplete200ResponseStatus>
    {
        public override DocSignaturesComplete200ResponseStatus Read(
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
            return new DocSignaturesComplete200ResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete200ResponseStatus ReadAsPropertyName(
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
            return new DocSignaturesComplete200ResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseStatus value,
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
        public const string Completed = "completed";

        public const string AlreadyCompleted = "already-completed";
    }
}
