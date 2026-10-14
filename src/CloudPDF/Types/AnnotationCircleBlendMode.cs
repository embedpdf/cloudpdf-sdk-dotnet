using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationCircleBlendMode.AnnotationCircleBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationCircleBlendMode : IStringEnum
{
    public static readonly AnnotationCircleBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationCircleBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationCircleBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationCircleBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationCircleBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationCircleBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationCircleBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationCircleBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationCircleBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationCircleBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationCircleBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationCircleBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationCircleBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationCircleBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationCircleBlendMode Color = new(Values.Color);

    public static readonly AnnotationCircleBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationCircleBlendMode(string value)
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
    public static AnnotationCircleBlendMode FromCustom(string value)
    {
        return new AnnotationCircleBlendMode(value);
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

    public static bool operator ==(AnnotationCircleBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationCircleBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationCircleBlendMode value) => value.Value;

    public static explicit operator AnnotationCircleBlendMode(string value) => new(value);

    internal class AnnotationCircleBlendModeSerializer : JsonConverter<AnnotationCircleBlendMode>
    {
        public override AnnotationCircleBlendMode Read(
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
            return new AnnotationCircleBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationCircleBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationCircleBlendMode ReadAsPropertyName(
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
            return new AnnotationCircleBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationCircleBlendMode value,
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
