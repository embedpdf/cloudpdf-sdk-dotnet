using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction Decimal =
        new(Values.Decimal);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction Fraction =
        new(Values.Fraction);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction Round =
        new(Values.Round);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction Truncate =
        new(Values.Truncate);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFractionSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygonMeasureRlSlopeItemFraction value,
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
