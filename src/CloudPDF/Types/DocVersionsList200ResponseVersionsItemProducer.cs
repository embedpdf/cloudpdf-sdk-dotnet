using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsList200ResponseVersionsItemProducer.DocVersionsList200ResponseVersionsItemProducerSerializer)
)]
[Serializable]
public readonly record struct DocVersionsList200ResponseVersionsItemProducer : IStringEnum
{
    public static readonly DocVersionsList200ResponseVersionsItemProducer Upload = new(
        Values.Upload
    );

    public static readonly DocVersionsList200ResponseVersionsItemProducer Signature = new(
        Values.Signature
    );

    public DocVersionsList200ResponseVersionsItemProducer(string value)
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
    public static DocVersionsList200ResponseVersionsItemProducer FromCustom(string value)
    {
        return new DocVersionsList200ResponseVersionsItemProducer(value);
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
        DocVersionsList200ResponseVersionsItemProducer value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsList200ResponseVersionsItemProducer value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsList200ResponseVersionsItemProducer value) =>
        value.Value;

    public static explicit operator DocVersionsList200ResponseVersionsItemProducer(string value) =>
        new(value);

    internal class DocVersionsList200ResponseVersionsItemProducerSerializer
        : JsonConverter<DocVersionsList200ResponseVersionsItemProducer>
    {
        public override DocVersionsList200ResponseVersionsItemProducer Read(
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
            return new DocVersionsList200ResponseVersionsItemProducer(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsList200ResponseVersionsItemProducer value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsList200ResponseVersionsItemProducer ReadAsPropertyName(
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
            return new DocVersionsList200ResponseVersionsItemProducer(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsList200ResponseVersionsItemProducer value,
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
