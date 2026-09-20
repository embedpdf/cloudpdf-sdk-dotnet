using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction Round =
        new(Values.Round);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction Truncate =
        new(Values.Truncate);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction(
        string value
    )
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFractionSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlXItemFraction value,
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
