using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality.DocAnnotationsList200ResponseAnnotationsItemTextIdentityQualitySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality Durable =
        new(Values.Durable);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality Weak =
        new(Values.Weak);

    public DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality(value);
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
        DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemTextIdentityQualitySerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemTextIdentityQuality value,
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
