using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCompleteResponseStatus.DocSignaturesCompleteResponseStatusSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCompleteResponseStatus : IStringEnum
{
    public static readonly DocSignaturesCompleteResponseStatus Completed = new(Values.Completed);

    public static readonly DocSignaturesCompleteResponseStatus AlreadyCompleted = new(
        Values.AlreadyCompleted
    );

    public DocSignaturesCompleteResponseStatus(string value)
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
    public static DocSignaturesCompleteResponseStatus FromCustom(string value)
    {
        return new DocSignaturesCompleteResponseStatus(value);
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

    public static bool operator ==(DocSignaturesCompleteResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesCompleteResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCompleteResponseStatus value) =>
        value.Value;

    public static explicit operator DocSignaturesCompleteResponseStatus(string value) => new(value);

    internal class DocSignaturesCompleteResponseStatusSerializer
        : JsonConverter<DocSignaturesCompleteResponseStatus>
    {
        public override DocSignaturesCompleteResponseStatus Read(
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
            return new DocSignaturesCompleteResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCompleteResponseStatus ReadAsPropertyName(
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
            return new DocSignaturesCompleteResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseStatus value,
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
