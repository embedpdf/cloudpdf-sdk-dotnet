using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPlacementBorderStyle.WidgetPlacementBorderStyleSerializer))]
[Serializable]
public readonly record struct WidgetPlacementBorderStyle : IStringEnum
{
    public static readonly WidgetPlacementBorderStyle Solid = new(Values.Solid);

    public static readonly WidgetPlacementBorderStyle Dashed = new(Values.Dashed);

    public static readonly WidgetPlacementBorderStyle Beveled = new(Values.Beveled);

    public static readonly WidgetPlacementBorderStyle Inset = new(Values.Inset);

    public static readonly WidgetPlacementBorderStyle Underline = new(Values.Underline);

    public WidgetPlacementBorderStyle(string value)
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
    public static WidgetPlacementBorderStyle FromCustom(string value)
    {
        return new WidgetPlacementBorderStyle(value);
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

    public static bool operator ==(WidgetPlacementBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPlacementBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPlacementBorderStyle value) => value.Value;

    public static explicit operator WidgetPlacementBorderStyle(string value) => new(value);

    internal class WidgetPlacementBorderStyleSerializer : JsonConverter<WidgetPlacementBorderStyle>
    {
        public override WidgetPlacementBorderStyle Read(
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
            return new WidgetPlacementBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPlacementBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPlacementBorderStyle ReadAsPropertyName(
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
            return new WidgetPlacementBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPlacementBorderStyle value,
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
        public const string Solid = "solid";

        public const string Dashed = "dashed";

        public const string Beveled = "beveled";

        public const string Inset = "inset";

        public const string Underline = "underline";
    }
}
