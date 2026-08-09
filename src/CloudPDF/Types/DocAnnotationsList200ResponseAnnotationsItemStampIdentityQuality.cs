using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality.DocAnnotationsList200ResponseAnnotationsItemStampIdentityQualitySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality Durable =
        new(Values.Durable);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality Weak =
        new(Values.Weak);

    public DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality(value);
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
        DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemStampIdentityQualitySerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStampIdentityQuality value,
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
        public const string Durable = "durable";

        public const string Weak = "weak";
    }
}
