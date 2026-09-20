using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemPolygonIntent.DocAnnotationsList200ResponseAnnotationsItemPolygonIntentSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemPolygonIntent
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolygonIntent PolygonCloud =
        new(Values.PolygonCloud);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolygonIntent PolygonDimension =
        new(Values.PolygonDimension);

    public DocAnnotationsList200ResponseAnnotationsItemPolygonIntent(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemPolygonIntent FromCustom(string value)
    {
        return new DocAnnotationsList200ResponseAnnotationsItemPolygonIntent(value);
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
        DocAnnotationsList200ResponseAnnotationsItemPolygonIntent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemPolygonIntent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemPolygonIntent value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemPolygonIntent(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemPolygonIntentSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolygonIntent>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemPolygonIntent Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolygonIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolygonIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolygonIntent ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolygonIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolygonIntent value,
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
        public const string PolygonCloud = "PolygonCloud";

        public const string PolygonDimension = "PolygonDimension";
    }
}
