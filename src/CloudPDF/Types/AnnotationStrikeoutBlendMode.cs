using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationStrikeoutBlendMode.AnnotationStrikeoutBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationStrikeoutBlendMode : IStringEnum
{
    public static readonly AnnotationStrikeoutBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationStrikeoutBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationStrikeoutBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationStrikeoutBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationStrikeoutBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationStrikeoutBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationStrikeoutBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationStrikeoutBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationStrikeoutBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationStrikeoutBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationStrikeoutBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationStrikeoutBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationStrikeoutBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationStrikeoutBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationStrikeoutBlendMode Color = new(Values.Color);

    public static readonly AnnotationStrikeoutBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationStrikeoutBlendMode(string value)
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
    public static AnnotationStrikeoutBlendMode FromCustom(string value)
    {
        return new AnnotationStrikeoutBlendMode(value);
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

    public static bool operator ==(AnnotationStrikeoutBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationStrikeoutBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationStrikeoutBlendMode value) => value.Value;

    public static explicit operator AnnotationStrikeoutBlendMode(string value) => new(value);

    internal class AnnotationStrikeoutBlendModeSerializer
        : JsonConverter<AnnotationStrikeoutBlendMode>
    {
        public override AnnotationStrikeoutBlendMode Read(
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
            return new AnnotationStrikeoutBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationStrikeoutBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationStrikeoutBlendMode ReadAsPropertyName(
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
            return new AnnotationStrikeoutBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationStrikeoutBlendMode value,
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
