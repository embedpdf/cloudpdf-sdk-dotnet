using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureAngleItemFraction.DocPagesSetScaleRequestMeasureAngleItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureAngleItemFraction : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureAngleItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesSetScaleRequestMeasureAngleItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly DocPagesSetScaleRequestMeasureAngleItemFraction Round = new(
        Values.Round
    );

    public static readonly DocPagesSetScaleRequestMeasureAngleItemFraction Truncate = new(
        Values.Truncate
    );

    public DocPagesSetScaleRequestMeasureAngleItemFraction(string value)
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
    public static DocPagesSetScaleRequestMeasureAngleItemFraction FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureAngleItemFraction(value);
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
        DocPagesSetScaleRequestMeasureAngleItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureAngleItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetScaleRequestMeasureAngleItemFraction value) =>
        value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureAngleItemFraction(string value) =>
        new(value);

    internal class DocPagesSetScaleRequestMeasureAngleItemFractionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureAngleItemFraction>
    {
        public override DocPagesSetScaleRequestMeasureAngleItemFraction Read(
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
            return new DocPagesSetScaleRequestMeasureAngleItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureAngleItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureAngleItemFraction ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureAngleItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureAngleItemFraction value,
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
