using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationLinkBlendMode.AnnotationLinkBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationLinkBlendMode : IStringEnum
{
    public static readonly AnnotationLinkBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationLinkBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationLinkBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationLinkBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationLinkBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationLinkBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationLinkBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationLinkBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationLinkBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationLinkBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationLinkBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationLinkBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationLinkBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationLinkBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationLinkBlendMode Color = new(Values.Color);

    public static readonly AnnotationLinkBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationLinkBlendMode(string value)
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
    public static AnnotationLinkBlendMode FromCustom(string value)
    {
        return new AnnotationLinkBlendMode(value);
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

    public static bool operator ==(AnnotationLinkBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationLinkBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationLinkBlendMode value) => value.Value;

    public static explicit operator AnnotationLinkBlendMode(string value) => new(value);

    internal class AnnotationLinkBlendModeSerializer : JsonConverter<AnnotationLinkBlendMode>
    {
        public override AnnotationLinkBlendMode Read(
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
            return new AnnotationLinkBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLinkBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationLinkBlendMode ReadAsPropertyName(
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
            return new AnnotationLinkBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLinkBlendMode value,
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
