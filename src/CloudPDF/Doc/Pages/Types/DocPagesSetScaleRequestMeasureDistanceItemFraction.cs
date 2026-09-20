using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureDistanceItemFraction.DocPagesSetScaleRequestMeasureDistanceItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureDistanceItemFraction : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureDistanceItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesSetScaleRequestMeasureDistanceItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly DocPagesSetScaleRequestMeasureDistanceItemFraction Round = new(
        Values.Round
    );

    public static readonly DocPagesSetScaleRequestMeasureDistanceItemFraction Truncate = new(
        Values.Truncate
    );

    public DocPagesSetScaleRequestMeasureDistanceItemFraction(string value)
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
    public static DocPagesSetScaleRequestMeasureDistanceItemFraction FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureDistanceItemFraction(value);
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
        DocPagesSetScaleRequestMeasureDistanceItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureDistanceItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesSetScaleRequestMeasureDistanceItemFraction value
    ) => value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureDistanceItemFraction(
        string value
    ) => new(value);

    internal class DocPagesSetScaleRequestMeasureDistanceItemFractionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureDistanceItemFraction>
    {
        public override DocPagesSetScaleRequestMeasureDistanceItemFraction Read(
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
            return new DocPagesSetScaleRequestMeasureDistanceItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureDistanceItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureDistanceItemFraction ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureDistanceItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureDistanceItemFraction value,
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
