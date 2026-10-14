using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationUnsupportedBlendMode.AnnotationUnsupportedBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationUnsupportedBlendMode : IStringEnum
{
    public static readonly AnnotationUnsupportedBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationUnsupportedBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationUnsupportedBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationUnsupportedBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationUnsupportedBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationUnsupportedBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationUnsupportedBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationUnsupportedBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationUnsupportedBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationUnsupportedBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationUnsupportedBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationUnsupportedBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationUnsupportedBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationUnsupportedBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationUnsupportedBlendMode Color = new(Values.Color);

    public static readonly AnnotationUnsupportedBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationUnsupportedBlendMode(string value)
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
    public static AnnotationUnsupportedBlendMode FromCustom(string value)
    {
        return new AnnotationUnsupportedBlendMode(value);
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

    public static bool operator ==(AnnotationUnsupportedBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationUnsupportedBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationUnsupportedBlendMode value) => value.Value;

    public static explicit operator AnnotationUnsupportedBlendMode(string value) => new(value);

    internal class AnnotationUnsupportedBlendModeSerializer
        : JsonConverter<AnnotationUnsupportedBlendMode>
    {
        public override AnnotationUnsupportedBlendMode Read(
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
            return new AnnotationUnsupportedBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationUnsupportedBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationUnsupportedBlendMode ReadAsPropertyName(
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
            return new AnnotationUnsupportedBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationUnsupportedBlendMode value,
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
