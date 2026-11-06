using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsListResponseVersionsItemProducer.DocVersionsListResponseVersionsItemProducerSerializer)
)]
[Serializable]
public readonly record struct DocVersionsListResponseVersionsItemProducer : IStringEnum
{
    public static readonly DocVersionsListResponseVersionsItemProducer Upload = new(Values.Upload);

    public static readonly DocVersionsListResponseVersionsItemProducer Signature = new(
        Values.Signature
    );

    public DocVersionsListResponseVersionsItemProducer(string value)
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
    public static DocVersionsListResponseVersionsItemProducer FromCustom(string value)
    {
        return new DocVersionsListResponseVersionsItemProducer(value);
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
        DocVersionsListResponseVersionsItemProducer value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsListResponseVersionsItemProducer value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsListResponseVersionsItemProducer value) =>
        value.Value;

    public static explicit operator DocVersionsListResponseVersionsItemProducer(string value) =>
        new(value);

    internal class DocVersionsListResponseVersionsItemProducerSerializer
        : JsonConverter<DocVersionsListResponseVersionsItemProducer>
    {
        public override DocVersionsListResponseVersionsItemProducer Read(
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
            return new DocVersionsListResponseVersionsItemProducer(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsListResponseVersionsItemProducer value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsListResponseVersionsItemProducer ReadAsPropertyName(
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
            return new DocVersionsListResponseVersionsItemProducer(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsListResponseVersionsItemProducer value,
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
        public const string Upload = "upload";

        public const string Signature = "signature";
    }
}
