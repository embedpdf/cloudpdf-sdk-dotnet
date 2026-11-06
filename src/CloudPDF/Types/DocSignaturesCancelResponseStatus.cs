using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCancelResponseStatus.DocSignaturesCancelResponseStatusSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCancelResponseStatus : IStringEnum
{
    public static readonly DocSignaturesCancelResponseStatus Cancelled = new(Values.Cancelled);

    public static readonly DocSignaturesCancelResponseStatus AlreadyCompleted = new(
        Values.AlreadyCompleted
    );

    public static readonly DocSignaturesCancelResponseStatus Unknown = new(Values.Unknown);

    public DocSignaturesCancelResponseStatus(string value)
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
    public static DocSignaturesCancelResponseStatus FromCustom(string value)
    {
        return new DocSignaturesCancelResponseStatus(value);
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

    public static bool operator ==(DocSignaturesCancelResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesCancelResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCancelResponseStatus value) => value.Value;

    public static explicit operator DocSignaturesCancelResponseStatus(string value) => new(value);

    internal class DocSignaturesCancelResponseStatusSerializer
        : JsonConverter<DocSignaturesCancelResponseStatus>
    {
        public override DocSignaturesCancelResponseStatus Read(
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
            return new DocSignaturesCancelResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCancelResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCancelResponseStatus ReadAsPropertyName(
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
            return new DocSignaturesCancelResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCancelResponseStatus value,
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
