using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction.DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction Round =
        new(Values.Round);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction Truncate =
        new(Values.Truncate);

    public DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction(value);
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
        DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFractionSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineMeasureRlXItemFraction value,
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
