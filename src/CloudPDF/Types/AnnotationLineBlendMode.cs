using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationLineBlendMode.AnnotationLineBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationLineBlendMode : IStringEnum
{
    public static readonly AnnotationLineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationLineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationLineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationLineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationLineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationLineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationLineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationLineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationLineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationLineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationLineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationLineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationLineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationLineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationLineBlendMode Color = new(Values.Color);

    public static readonly AnnotationLineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationLineBlendMode(string value)
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
    public static AnnotationLineBlendMode FromCustom(string value)
    {
        return new AnnotationLineBlendMode(value);
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

    public static bool operator ==(AnnotationLineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationLineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationLineBlendMode value) => value.Value;

    public static explicit operator AnnotationLineBlendMode(string value) => new(value);

    internal class AnnotationLineBlendModeSerializer : JsonConverter<AnnotationLineBlendMode>
    {
        public override AnnotationLineBlendMode Read(
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
            return new AnnotationLineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationLineBlendMode ReadAsPropertyName(
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
            return new AnnotationLineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLineBlendMode value,
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
