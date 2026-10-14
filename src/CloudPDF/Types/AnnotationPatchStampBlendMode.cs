using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchStampBlendMode.AnnotationPatchStampBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchStampBlendMode : IStringEnum
{
    public static readonly AnnotationPatchStampBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchStampBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchStampBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchStampBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchStampBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchStampBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchStampBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchStampBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchStampBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchStampBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchStampBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchStampBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchStampBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchStampBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchStampBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchStampBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchStampBlendMode(string value)
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
    public static AnnotationPatchStampBlendMode FromCustom(string value)
    {
        return new AnnotationPatchStampBlendMode(value);
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

    public static bool operator ==(AnnotationPatchStampBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchStampBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchStampBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchStampBlendMode(string value) => new(value);

    internal class AnnotationPatchStampBlendModeSerializer
        : JsonConverter<AnnotationPatchStampBlendMode>
    {
        public override AnnotationPatchStampBlendMode Read(
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
            return new AnnotationPatchStampBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchStampBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchStampBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchStampBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchStampBlendMode value,
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
