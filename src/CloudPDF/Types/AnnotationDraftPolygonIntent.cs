using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftPolygonIntent.AnnotationDraftPolygonIntentSerializer))]
[Serializable]
public readonly record struct AnnotationDraftPolygonIntent : IStringEnum
{
    public static readonly AnnotationDraftPolygonIntent PolygonCloud = new(Values.PolygonCloud);

    public static readonly AnnotationDraftPolygonIntent PolygonDimension = new(
        Values.PolygonDimension
    );

    public AnnotationDraftPolygonIntent(string value)
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
    public static AnnotationDraftPolygonIntent FromCustom(string value)
    {
        return new AnnotationDraftPolygonIntent(value);
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

    public static bool operator ==(AnnotationDraftPolygonIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftPolygonIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftPolygonIntent value) => value.Value;

    public static explicit operator AnnotationDraftPolygonIntent(string value) => new(value);

    internal class AnnotationDraftPolygonIntentSerializer
        : JsonConverter<AnnotationDraftPolygonIntent>
    {
        public override AnnotationDraftPolygonIntent Read(
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
            return new AnnotationDraftPolygonIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolygonIntent ReadAsPropertyName(
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
            return new AnnotationDraftPolygonIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonIntent value,
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
        public const string PolygonCloud = "polygon-cloud";

        public const string PolygonDimension = "polygon-dimension";
    }
}
