using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPatchSubtype.WidgetPatchSubtypeSerializer))]
[Serializable]
public readonly record struct WidgetPatchSubtype : IStringEnum
{
    public static readonly WidgetPatchSubtype Widget = new(Values.Widget);

    public WidgetPatchSubtype(string value)
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
    public static WidgetPatchSubtype FromCustom(string value)
    {
        return new WidgetPatchSubtype(value);
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

    public static bool operator ==(WidgetPatchSubtype value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPatchSubtype value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPatchSubtype value) => value.Value;

    public static explicit operator WidgetPatchSubtype(string value) => new(value);

    internal class WidgetPatchSubtypeSerializer : JsonConverter<WidgetPatchSubtype>
    {
        public override WidgetPatchSubtype Read(
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
            return new WidgetPatchSubtype(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPatchSubtype value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPatchSubtype ReadAsPropertyName(
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
            return new WidgetPatchSubtype(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPatchSubtype value,
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
        public const string Widget = "widget";
    }
}
