using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureAreaItemFraction.DocPagesSetScaleRequestMeasureAreaItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureAreaItemFraction : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureAreaItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesSetScaleRequestMeasureAreaItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly DocPagesSetScaleRequestMeasureAreaItemFraction Round = new(Values.Round);

    public static readonly DocPagesSetScaleRequestMeasureAreaItemFraction Truncate = new(
        Values.Truncate
    );

    public DocPagesSetScaleRequestMeasureAreaItemFraction(string value)
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
    public static DocPagesSetScaleRequestMeasureAreaItemFraction FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureAreaItemFraction(value);
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
        DocPagesSetScaleRequestMeasureAreaItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesSetScaleRequestMeasureAreaItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetScaleRequestMeasureAreaItemFraction value) =>
        value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureAreaItemFraction(string value) =>
        new(value);

    internal class DocPagesSetScaleRequestMeasureAreaItemFractionSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureAreaItemFraction>
    {
        public override DocPagesSetScaleRequestMeasureAreaItemFraction Read(
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
            return new DocPagesSetScaleRequestMeasureAreaItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureAreaItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureAreaItemFraction ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureAreaItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureAreaItemFraction value,
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
