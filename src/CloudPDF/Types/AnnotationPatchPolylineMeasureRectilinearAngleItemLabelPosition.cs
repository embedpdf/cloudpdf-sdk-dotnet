using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition.AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition
    : IStringEnum
{
    public static readonly AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition Prefix =
        new(Values.Prefix);

    public AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition(string value)
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
    public static AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition FromCustom(
        string value
    )
    {
        return new AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition(value);
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
        AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPositionSerializer
        : JsonConverter<AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition>
    {
        public override AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition Read(
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
            return new AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineMeasureRectilinearAngleItemLabelPosition value,
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
