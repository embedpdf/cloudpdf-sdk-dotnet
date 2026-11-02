using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesInsertBlankLayoutLabelsItemStyle.ChangeItemPagesInsertBlankLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesInsertBlankLayoutLabelsItemStyle : IStringEnum
{
    public static readonly ChangeItemPagesInsertBlankLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesInsertBlankLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly ChangeItemPagesInsertBlankLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly ChangeItemPagesInsertBlankLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly ChangeItemPagesInsertBlankLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public ChangeItemPagesInsertBlankLayoutLabelsItemStyle(string value)
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
    public static ChangeItemPagesInsertBlankLayoutLabelsItemStyle FromCustom(string value)
    {
        return new ChangeItemPagesInsertBlankLayoutLabelsItemStyle(value);
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
        ChangeItemPagesInsertBlankLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesInsertBlankLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesInsertBlankLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator ChangeItemPagesInsertBlankLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class ChangeItemPagesInsertBlankLayoutLabelsItemStyleSerializer
        : JsonConverter<ChangeItemPagesInsertBlankLayoutLabelsItemStyle>
    {
        public override ChangeItemPagesInsertBlankLayoutLabelsItemStyle Read(
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
            return new ChangeItemPagesInsertBlankLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesInsertBlankLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesInsertBlankLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new ChangeItemPagesInsertBlankLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesInsertBlankLayoutLabelsItemStyle value,
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
