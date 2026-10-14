using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition.AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition
    : IStringEnum
{
    public static readonly AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition Prefix =
        new(Values.Prefix);

    public AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition(string value)
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
    public static AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition FromCustom(
        string value
    )
    {
        return new AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition(value);
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
        AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPositionSerializer
        : JsonConverter<AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition>
    {
        public override AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition Read(
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
            return new AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonMeasureRectilinearSlopeItemLabelPosition value,
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
