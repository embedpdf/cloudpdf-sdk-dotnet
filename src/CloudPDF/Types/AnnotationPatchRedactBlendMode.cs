using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchRedactBlendMode.AnnotationPatchRedactBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchRedactBlendMode : IStringEnum
{
    public static readonly AnnotationPatchRedactBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchRedactBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchRedactBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchRedactBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchRedactBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchRedactBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchRedactBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchRedactBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchRedactBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchRedactBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchRedactBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchRedactBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchRedactBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchRedactBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchRedactBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchRedactBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchRedactBlendMode(string value)
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
    public static AnnotationPatchRedactBlendMode FromCustom(string value)
    {
        return new AnnotationPatchRedactBlendMode(value);
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

    public static bool operator ==(AnnotationPatchRedactBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchRedactBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchRedactBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchRedactBlendMode(string value) => new(value);

    internal class AnnotationPatchRedactBlendModeSerializer
        : JsonConverter<AnnotationPatchRedactBlendMode>
    {
        public override AnnotationPatchRedactBlendMode Read(
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
            return new AnnotationPatchRedactBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchRedactBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchRedactBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchRedactBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchRedactBlendMode value,
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
