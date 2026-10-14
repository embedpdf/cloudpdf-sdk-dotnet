using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationTextBlendMode.AnnotationTextBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationTextBlendMode : IStringEnum
{
    public static readonly AnnotationTextBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationTextBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationTextBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationTextBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationTextBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationTextBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationTextBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationTextBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationTextBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationTextBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationTextBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationTextBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationTextBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationTextBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationTextBlendMode Color = new(Values.Color);

    public static readonly AnnotationTextBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationTextBlendMode(string value)
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
    public static AnnotationTextBlendMode FromCustom(string value)
    {
        return new AnnotationTextBlendMode(value);
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

    public static bool operator ==(AnnotationTextBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationTextBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationTextBlendMode value) => value.Value;

    public static explicit operator AnnotationTextBlendMode(string value) => new(value);

    internal class AnnotationTextBlendModeSerializer : JsonConverter<AnnotationTextBlendMode>
    {
        public override AnnotationTextBlendMode Read(
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
            return new AnnotationTextBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationTextBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationTextBlendMode ReadAsPropertyName(
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
            return new AnnotationTextBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationTextBlendMode value,
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
