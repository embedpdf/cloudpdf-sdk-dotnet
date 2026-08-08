using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality.DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQualitySerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality Durable =
        new(Values.Durable);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality Weak =
        new(Values.Weak);

    public DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality(value);
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
        DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQualitySerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemRedactIdentityQuality value,
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
