using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignaturesResponseSignaturesItemKind.DocVersionsSignaturesResponseSignaturesItemKindSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignaturesResponseSignaturesItemKind : IStringEnum
{
    public static readonly DocVersionsSignaturesResponseSignaturesItemKind Signature = new(
        Values.Signature
    );

    public static readonly DocVersionsSignaturesResponseSignaturesItemKind Timestamp = new(
        Values.Timestamp
    );

    public DocVersionsSignaturesResponseSignaturesItemKind(string value)
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
    public static DocVersionsSignaturesResponseSignaturesItemKind FromCustom(string value)
    {
        return new DocVersionsSignaturesResponseSignaturesItemKind(value);
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

    public static bool operator ==(
        DocVersionsSignaturesResponseSignaturesItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignaturesResponseSignaturesItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsSignaturesResponseSignaturesItemKind value) =>
        value.Value;

    public static explicit operator DocVersionsSignaturesResponseSignaturesItemKind(string value) =>
        new(value);

    internal class DocVersionsSignaturesResponseSignaturesItemKindSerializer
        : JsonConverter<DocVersionsSignaturesResponseSignaturesItemKind>
    {
        public override DocVersionsSignaturesResponseSignaturesItemKind Read(
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
            return new DocVersionsSignaturesResponseSignaturesItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseSignaturesItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignaturesResponseSignaturesItemKind ReadAsPropertyName(
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
            return new DocVersionsSignaturesResponseSignaturesItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseSignaturesItemKind value,
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
        public const string Signature = "signature";

        public const string Timestamp = "timestamp";
    }
}
