using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction.DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction Round =
        new(Values.Round);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction Truncate =
        new(Values.Truncate);

    public DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction(
            value
        );
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
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFractionSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineMeasureRlXItemFraction value,
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
        public const string Decimal = "decimal";

        public const string Fraction = "fraction";

        public const string Round = "round";

        public const string Truncate = "truncate";
    }
}
