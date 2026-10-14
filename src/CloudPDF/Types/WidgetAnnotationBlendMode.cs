using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationBlendMode.WidgetAnnotationBlendModeSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationBlendMode : IStringEnum
{
    public static readonly WidgetAnnotationBlendMode Normal = new(Values.Normal);

    public static readonly WidgetAnnotationBlendMode Multiply = new(Values.Multiply);

    public static readonly WidgetAnnotationBlendMode Screen = new(Values.Screen);

    public static readonly WidgetAnnotationBlendMode Overlay = new(Values.Overlay);

    public static readonly WidgetAnnotationBlendMode Darken = new(Values.Darken);

    public static readonly WidgetAnnotationBlendMode Lighten = new(Values.Lighten);

    public static readonly WidgetAnnotationBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly WidgetAnnotationBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly WidgetAnnotationBlendMode HardLight = new(Values.HardLight);

    public static readonly WidgetAnnotationBlendMode SoftLight = new(Values.SoftLight);

    public static readonly WidgetAnnotationBlendMode Difference = new(Values.Difference);

    public static readonly WidgetAnnotationBlendMode Exclusion = new(Values.Exclusion);

    public static readonly WidgetAnnotationBlendMode Hue = new(Values.Hue);

    public static readonly WidgetAnnotationBlendMode Saturation = new(Values.Saturation);

    public static readonly WidgetAnnotationBlendMode Color = new(Values.Color);

    public static readonly WidgetAnnotationBlendMode Luminosity = new(Values.Luminosity);

    public WidgetAnnotationBlendMode(string value)
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
    public static WidgetAnnotationBlendMode FromCustom(string value)
    {
        return new WidgetAnnotationBlendMode(value);
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

    public static bool operator ==(WidgetAnnotationBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationBlendMode value) => value.Value;

    public static explicit operator WidgetAnnotationBlendMode(string value) => new(value);

    internal class WidgetAnnotationBlendModeSerializer : JsonConverter<WidgetAnnotationBlendMode>
    {
        public override WidgetAnnotationBlendMode Read(
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
            return new WidgetAnnotationBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationBlendMode ReadAsPropertyName(
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
            return new WidgetAnnotationBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationBlendMode value,
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
        public const string Normal = "normal";

        public const string Multiply = "multiply";

        public const string Screen = "screen";

        public const string Overlay = "overlay";

        public const string Darken = "darken";

        public const string Lighten = "lighten";

        public const string ColorDodge = "color-dodge";

        public const string ColorBurn = "color-burn";

        public const string HardLight = "hard-light";

        public const string SoftLight = "soft-light";

        public const string Difference = "difference";

        public const string Exclusion = "exclusion";

        public const string Hue = "hue";

        public const string Saturation = "saturation";

        public const string Color = "color";

        public const string Luminosity = "luminosity";
    }
}
