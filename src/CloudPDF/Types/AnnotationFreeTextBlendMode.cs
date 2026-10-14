using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationFreeTextBlendMode.AnnotationFreeTextBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationFreeTextBlendMode : IStringEnum
{
    public static readonly AnnotationFreeTextBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationFreeTextBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationFreeTextBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationFreeTextBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationFreeTextBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationFreeTextBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationFreeTextBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationFreeTextBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationFreeTextBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationFreeTextBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationFreeTextBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationFreeTextBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationFreeTextBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationFreeTextBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationFreeTextBlendMode Color = new(Values.Color);

    public static readonly AnnotationFreeTextBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationFreeTextBlendMode(string value)
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
    public static AnnotationFreeTextBlendMode FromCustom(string value)
    {
        return new AnnotationFreeTextBlendMode(value);
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

    public static bool operator ==(AnnotationFreeTextBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextBlendMode value) => value.Value;

    public static explicit operator AnnotationFreeTextBlendMode(string value) => new(value);

    internal class AnnotationFreeTextBlendModeSerializer
        : JsonConverter<AnnotationFreeTextBlendMode>
    {
        public override AnnotationFreeTextBlendMode Read(
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
            return new AnnotationFreeTextBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextBlendMode ReadAsPropertyName(
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
            return new AnnotationFreeTextBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextBlendMode value,
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
