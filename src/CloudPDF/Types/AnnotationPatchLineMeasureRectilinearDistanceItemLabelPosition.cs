using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition.AnnotationPatchLineMeasureRectilinearDistanceItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition
    : IStringEnum
{
    public static readonly AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition Prefix =
        new(Values.Prefix);

    public AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition(string value)
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
    public static AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition FromCustom(
        string value
    )
    {
        return new AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition(value);
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
        AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationPatchLineMeasureRectilinearDistanceItemLabelPositionSerializer
        : JsonConverter<AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition>
    {
        public override AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition Read(
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
            return new AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineMeasureRectilinearDistanceItemLabelPosition value,
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
