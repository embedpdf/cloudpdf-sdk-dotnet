using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationInkBlendMode.AnnotationInkBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationInkBlendMode : IStringEnum
{
    public static readonly AnnotationInkBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationInkBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationInkBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationInkBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationInkBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationInkBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationInkBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationInkBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationInkBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationInkBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationInkBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationInkBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationInkBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationInkBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationInkBlendMode Color = new(Values.Color);

    public static readonly AnnotationInkBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationInkBlendMode(string value)
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
    public static AnnotationInkBlendMode FromCustom(string value)
    {
        return new AnnotationInkBlendMode(value);
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

    public static bool operator ==(AnnotationInkBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationInkBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationInkBlendMode value) => value.Value;

    public static explicit operator AnnotationInkBlendMode(string value) => new(value);

    internal class AnnotationInkBlendModeSerializer : JsonConverter<AnnotationInkBlendMode>
    {
        public override AnnotationInkBlendMode Read(
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
            return new AnnotationInkBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationInkBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationInkBlendMode ReadAsPropertyName(
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
            return new AnnotationInkBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationInkBlendMode value,
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
