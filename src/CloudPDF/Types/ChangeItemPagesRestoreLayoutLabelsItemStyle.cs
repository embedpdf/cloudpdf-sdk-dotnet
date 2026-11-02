using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesRestoreLayoutLabelsItemStyle.ChangeItemPagesRestoreLayoutLabelsItemStyleSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesRestoreLayoutLabelsItemStyle : IStringEnum
{
    public static readonly ChangeItemPagesRestoreLayoutLabelsItemStyle Decimal = new(
        Values.Decimal
    );

    public static readonly ChangeItemPagesRestoreLayoutLabelsItemStyle UpperRoman = new(
        Values.UpperRoman
    );

    public static readonly ChangeItemPagesRestoreLayoutLabelsItemStyle LowerRoman = new(
        Values.LowerRoman
    );

    public static readonly ChangeItemPagesRestoreLayoutLabelsItemStyle UpperLetters = new(
        Values.UpperLetters
    );

    public static readonly ChangeItemPagesRestoreLayoutLabelsItemStyle LowerLetters = new(
        Values.LowerLetters
    );

    public ChangeItemPagesRestoreLayoutLabelsItemStyle(string value)
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
    public static ChangeItemPagesRestoreLayoutLabelsItemStyle FromCustom(string value)
    {
        return new ChangeItemPagesRestoreLayoutLabelsItemStyle(value);
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
        ChangeItemPagesRestoreLayoutLabelsItemStyle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemPagesRestoreLayoutLabelsItemStyle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesRestoreLayoutLabelsItemStyle value) =>
        value.Value;

    public static explicit operator ChangeItemPagesRestoreLayoutLabelsItemStyle(string value) =>
        new(value);

    internal class ChangeItemPagesRestoreLayoutLabelsItemStyleSerializer
        : JsonConverter<ChangeItemPagesRestoreLayoutLabelsItemStyle>
    {
        public override ChangeItemPagesRestoreLayoutLabelsItemStyle Read(
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
            return new ChangeItemPagesRestoreLayoutLabelsItemStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesRestoreLayoutLabelsItemStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesRestoreLayoutLabelsItemStyle ReadAsPropertyName(
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
            return new ChangeItemPagesRestoreLayoutLabelsItemStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesRestoreLayoutLabelsItemStyle value,
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
