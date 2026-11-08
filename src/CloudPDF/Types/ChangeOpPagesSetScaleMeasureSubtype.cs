using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeOpPagesSetScaleMeasureSubtype.ChangeOpPagesSetScaleMeasureSubtypeSerializer)
)]
[Serializable]
public readonly record struct ChangeOpPagesSetScaleMeasureSubtype : IStringEnum
{
    public static readonly ChangeOpPagesSetScaleMeasureSubtype Rectilinear = new(
        Values.Rectilinear
    );

    public ChangeOpPagesSetScaleMeasureSubtype(string value)
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
    public static ChangeOpPagesSetScaleMeasureSubtype FromCustom(string value)
    {
        return new ChangeOpPagesSetScaleMeasureSubtype(value);
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

    public static bool operator ==(ChangeOpPagesSetScaleMeasureSubtype value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChangeOpPagesSetScaleMeasureSubtype value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChangeOpPagesSetScaleMeasureSubtype value) =>
        value.Value;

    public static explicit operator ChangeOpPagesSetScaleMeasureSubtype(string value) => new(value);

    internal class ChangeOpPagesSetScaleMeasureSubtypeSerializer
        : JsonConverter<ChangeOpPagesSetScaleMeasureSubtype>
    {
        public override ChangeOpPagesSetScaleMeasureSubtype Read(
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
            return new ChangeOpPagesSetScaleMeasureSubtype(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureSubtype value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeOpPagesSetScaleMeasureSubtype ReadAsPropertyName(
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
            return new ChangeOpPagesSetScaleMeasureSubtype(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeOpPagesSetScaleMeasureSubtype value,
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
