using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition.AnnotationDraftPolylineMeasureRectilinearXItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition
    : IStringEnum
{
    public static readonly AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition Suffix = new(
        Values.Suffix
    );

    public static readonly AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition Prefix = new(
        Values.Prefix
    );

    public AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition(string value)
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
    public static AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition FromCustom(
        string value
    )
    {
        return new AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition(value);
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
        AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition value
    ) => value.Value;

    public static explicit operator AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition(
        string value
    ) => new(value);

    internal class AnnotationDraftPolylineMeasureRectilinearXItemLabelPositionSerializer
        : JsonConverter<AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition>
    {
        public override AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition Read(
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
            return new AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition ReadAsPropertyName(
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
            return new AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineMeasureRectilinearXItemLabelPosition value,
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
