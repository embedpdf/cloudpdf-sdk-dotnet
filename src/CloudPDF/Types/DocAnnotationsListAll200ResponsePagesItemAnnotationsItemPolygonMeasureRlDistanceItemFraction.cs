using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction Round =
        new(Values.Round);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction Truncate =
        new(Values.Truncate);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFractionSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlDistanceItemFraction value,
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
