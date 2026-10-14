using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationLineMeasureRectilinearXItemLabelPosition.AnnotationLineMeasureRectilinearXItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationLineMeasureRectilinearXItemLabelPosition : IStringEnum
{
    public static readonly AnnotationLineMeasureRectilinearXItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly AnnotationLineMeasureRectilinearXItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public AnnotationLineMeasureRectilinearXItemLabelPosition(string value)
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
    public static AnnotationLineMeasureRectilinearXItemLabelPosition FromCustom(string value)
    {
        return new AnnotationLineMeasureRectilinearXItemLabelPosition(value);
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
        AnnotationLineMeasureRectilinearXItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationLineMeasureRectilinearXItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationLineMeasureRectilinearXItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationLineMeasureRectilinearXItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationLineMeasureRectilinearXItemLabelPositionSerializer
        : JsonConverter<AnnotationLineMeasureRectilinearXItemLabelPosition>
    {
        public override AnnotationLineMeasureRectilinearXItemLabelPosition Read(
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
            return new AnnotationLineMeasureRectilinearXItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLineMeasureRectilinearXItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationLineMeasureRectilinearXItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationLineMeasureRectilinearXItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLineMeasureRectilinearXItemLabelPosition value,
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
