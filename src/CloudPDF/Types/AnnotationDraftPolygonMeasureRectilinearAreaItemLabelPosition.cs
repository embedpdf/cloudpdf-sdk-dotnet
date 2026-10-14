using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition.AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition
    : IStringEnum
{
    public static readonly AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition Prefix =
        new(Values.Prefix);

    public AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition(string value)
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
    public static AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition FromCustom(
        string value
    )
    {
        return new AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition(value);
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
        AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPositionSerializer
        : JsonConverter<AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition>
    {
        public override AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition Read(
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
            return new AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolygonMeasureRectilinearAreaItemLabelPosition value,
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
        public const string Suffix = "suffix";

        public const string Prefix = "prefix";
    }
}
