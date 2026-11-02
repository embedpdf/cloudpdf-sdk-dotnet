using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesRotateLayoutLabelsItemStyle.ChangeItemPagesRotateLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesRotateLayoutLabelsItemStyle : IStringEnum
{
    public static readonly ChangeItemPagesRotateLayoutLabelsItemStyle Decimal = new(Values.Decimal);

    public static readonly ChangeItemPagesRotateLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly ChangeItemPagesRotateLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly ChangeItemPagesRotateLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly ChangeItemPagesRotateLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public ChangeItemPagesRotateLayoutLabelsItemStyle(string value)
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
    public static ChangeItemPagesRotateLayoutLabelsItemStyle FromCustom(string value)
    {
        return new ChangeItemPagesRotateLayoutLabelsItemStyle(value);
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
        ChangeItemPagesRotateLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesRotateLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesRotateLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator ChangeItemPagesRotateLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class ChangeItemPagesRotateLayoutLabelsItemStyleSerializer
        : JsonConverter<ChangeItemPagesRotateLayoutLabelsItemStyle>
    {
        public override ChangeItemPagesRotateLayoutLabelsItemStyle Read(
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
            return new ChangeItemPagesRotateLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesRotateLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesRotateLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new ChangeItemPagesRotateLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesRotateLayoutLabelsItemStyle value,
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

        public const string UpperRoman = "upperRoman";

        public const string LowerRoman = "lowerRoman";

        public const string UpperLetters = "upperLetters";

        public const string LowerLetters = "lowerLetters";
    }
}
