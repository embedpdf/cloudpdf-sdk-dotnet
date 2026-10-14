using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationRedactBlendMode.AnnotationRedactBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationRedactBlendMode : IStringEnum
{
    public static readonly AnnotationRedactBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationRedactBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationRedactBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationRedactBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationRedactBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationRedactBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationRedactBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationRedactBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationRedactBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationRedactBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationRedactBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationRedactBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationRedactBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationRedactBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationRedactBlendMode Color = new(Values.Color);

    public static readonly AnnotationRedactBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationRedactBlendMode(string value)
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
    public static AnnotationRedactBlendMode FromCustom(string value)
    {
        return new AnnotationRedactBlendMode(value);
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

    public static bool operator ==(AnnotationRedactBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationRedactBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationRedactBlendMode value) => value.Value;

    public static explicit operator AnnotationRedactBlendMode(string value) => new(value);

    internal class AnnotationRedactBlendModeSerializer : JsonConverter<AnnotationRedactBlendMode>
    {
        public override AnnotationRedactBlendMode Read(
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
            return new AnnotationRedactBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationRedactBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationRedactBlendMode ReadAsPropertyName(
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
            return new AnnotationRedactBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationRedactBlendMode value,
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
