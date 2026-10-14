using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPolylineMeasureRectilinearAreaItemLabelPosition.AnnotationPolylineMeasureRectilinearAreaItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationPolylineMeasureRectilinearAreaItemLabelPosition
    : IStringEnum
{
    public static readonly AnnotationPolylineMeasureRectilinearAreaItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly AnnotationPolylineMeasureRectilinearAreaItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public AnnotationPolylineMeasureRectilinearAreaItemLabelPosition(string value)
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
    public static AnnotationPolylineMeasureRectilinearAreaItemLabelPosition FromCustom(string value)
    {
        return new AnnotationPolylineMeasureRectilinearAreaItemLabelPosition(value);
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
        AnnotationPolylineMeasureRectilinearAreaItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPolylineMeasureRectilinearAreaItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPolylineMeasureRectilinearAreaItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationPolylineMeasureRectilinearAreaItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationPolylineMeasureRectilinearAreaItemLabelPositionSerializer
        : JsonConverter<AnnotationPolylineMeasureRectilinearAreaItemLabelPosition>
    {
        public override AnnotationPolylineMeasureRectilinearAreaItemLabelPosition Read(
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
            return new AnnotationPolylineMeasureRectilinearAreaItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolylineMeasureRectilinearAreaItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolylineMeasureRectilinearAreaItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationPolylineMeasureRectilinearAreaItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolylineMeasureRectilinearAreaItemLabelPosition value,
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
