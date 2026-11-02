using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesReorderLayoutLabelsItemStyle.ChangeItemPagesReorderLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesReorderLayoutLabelsItemStyle : IStringEnum
{
    public static readonly ChangeItemPagesReorderLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesReorderLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly ChangeItemPagesReorderLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly ChangeItemPagesReorderLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly ChangeItemPagesReorderLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public ChangeItemPagesReorderLayoutLabelsItemStyle(string value)
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
    public static ChangeItemPagesReorderLayoutLabelsItemStyle FromCustom(string value)
    {
        return new ChangeItemPagesReorderLayoutLabelsItemStyle(value);
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
        ChangeItemPagesReorderLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesReorderLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesReorderLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator ChangeItemPagesReorderLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class ChangeItemPagesReorderLayoutLabelsItemStyleSerializer
        : JsonConverter<ChangeItemPagesReorderLayoutLabelsItemStyle>
    {
        public override ChangeItemPagesReorderLayoutLabelsItemStyle Read(
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
            return new ChangeItemPagesReorderLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesReorderLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesReorderLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new ChangeItemPagesReorderLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesReorderLayoutLabelsItemStyle value,
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
