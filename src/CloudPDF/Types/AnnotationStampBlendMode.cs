using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationStampBlendMode.AnnotationStampBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationStampBlendMode : IStringEnum
{
    public static readonly AnnotationStampBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationStampBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationStampBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationStampBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationStampBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationStampBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationStampBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationStampBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationStampBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationStampBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationStampBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationStampBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationStampBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationStampBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationStampBlendMode Color = new(Values.Color);

    public static readonly AnnotationStampBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationStampBlendMode(string value)
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
    public static AnnotationStampBlendMode FromCustom(string value)
    {
        return new AnnotationStampBlendMode(value);
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

    public static bool operator ==(AnnotationStampBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationStampBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationStampBlendMode value) => value.Value;

    public static explicit operator AnnotationStampBlendMode(string value) => new(value);

    internal class AnnotationStampBlendModeSerializer : JsonConverter<AnnotationStampBlendMode>
    {
        public override AnnotationStampBlendMode Read(
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
            return new AnnotationStampBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationStampBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationStampBlendMode ReadAsPropertyName(
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
            return new AnnotationStampBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationStampBlendMode value,
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
