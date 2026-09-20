using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseItemMeasureRlYItemFraction.DocPagesViewports200ResponseItemMeasureRlYItemFractionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseItemMeasureRlYItemFraction : IStringEnum
{
    public static readonly DocPagesViewports200ResponseItemMeasureRlYItemFraction Decimal = new(
        Values.Decimal
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlYItemFraction Fraction = new(
        Values.Fraction
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlYItemFraction Round = new(
        Values.Round
    );

    public static readonly DocPagesViewports200ResponseItemMeasureRlYItemFraction Truncate = new(
        Values.Truncate
    );

    public DocPagesViewports200ResponseItemMeasureRlYItemFraction(string value)
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
    public static DocPagesViewports200ResponseItemMeasureRlYItemFraction FromCustom(string value)
    {
        return new DocPagesViewports200ResponseItemMeasureRlYItemFraction(value);
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
        DocPagesViewports200ResponseItemMeasureRlYItemFraction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseItemMeasureRlYItemFraction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseItemMeasureRlYItemFraction value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseItemMeasureRlYItemFraction(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseItemMeasureRlYItemFractionSerializer
        : JsonConverter<DocPagesViewports200ResponseItemMeasureRlYItemFraction>
    {
        public override DocPagesViewports200ResponseItemMeasureRlYItemFraction Read(
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
            return new DocPagesViewports200ResponseItemMeasureRlYItemFraction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlYItemFraction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseItemMeasureRlYItemFraction ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseItemMeasureRlYItemFraction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseItemMeasureRlYItemFraction value,
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
