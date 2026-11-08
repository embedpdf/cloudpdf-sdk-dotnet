using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemPagesSetScaleMeasureSubtype.ChangeItemPagesSetScaleMeasureSubtypeSerializer)
)]
[Serializable]
public readonly record struct ChangeItemPagesSetScaleMeasureSubtype : IStringEnum
{
    public static readonly ChangeItemPagesSetScaleMeasureSubtype Rectilinear = new(
        Values.Rectilinear
    );

    public ChangeItemPagesSetScaleMeasureSubtype(string value)
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
    public static ChangeItemPagesSetScaleMeasureSubtype FromCustom(string value)
    {
        return new ChangeItemPagesSetScaleMeasureSubtype(value);
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

    public static bool operator ==(ChangeItemPagesSetScaleMeasureSubtype value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChangeItemPagesSetScaleMeasureSubtype value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemPagesSetScaleMeasureSubtype value) =>
        value.Value;

    public static explicit operator ChangeItemPagesSetScaleMeasureSubtype(string value) =>
        new(value);

    internal class ChangeItemPagesSetScaleMeasureSubtypeSerializer
        : JsonConverter<ChangeItemPagesSetScaleMeasureSubtype>
    {
        public override ChangeItemPagesSetScaleMeasureSubtype Read(
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
            return new ChangeItemPagesSetScaleMeasureSubtype(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureSubtype value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemPagesSetScaleMeasureSubtype ReadAsPropertyName(
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
            return new ChangeItemPagesSetScaleMeasureSubtype(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemPagesSetScaleMeasureSubtype value,
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
        public const string Rectilinear = "rectilinear";
    }
}
