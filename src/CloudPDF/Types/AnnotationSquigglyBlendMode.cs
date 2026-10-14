using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationSquigglyBlendMode.AnnotationSquigglyBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationSquigglyBlendMode : IStringEnum
{
    public static readonly AnnotationSquigglyBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationSquigglyBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationSquigglyBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationSquigglyBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationSquigglyBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationSquigglyBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationSquigglyBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationSquigglyBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationSquigglyBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationSquigglyBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationSquigglyBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationSquigglyBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationSquigglyBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationSquigglyBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationSquigglyBlendMode Color = new(Values.Color);

    public static readonly AnnotationSquigglyBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationSquigglyBlendMode(string value)
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
    public static AnnotationSquigglyBlendMode FromCustom(string value)
    {
        return new AnnotationSquigglyBlendMode(value);
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

    public static bool operator ==(AnnotationSquigglyBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationSquigglyBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationSquigglyBlendMode value) => value.Value;

    public static explicit operator AnnotationSquigglyBlendMode(string value) => new(value);

    internal class AnnotationSquigglyBlendModeSerializer
        : JsonConverter<AnnotationSquigglyBlendMode>
    {
        public override AnnotationSquigglyBlendMode Read(
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
            return new AnnotationSquigglyBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationSquigglyBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationSquigglyBlendMode ReadAsPropertyName(
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
            return new AnnotationSquigglyBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationSquigglyBlendMode value,
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
