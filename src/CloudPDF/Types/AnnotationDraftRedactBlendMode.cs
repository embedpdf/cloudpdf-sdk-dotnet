using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftRedactBlendMode.AnnotationDraftRedactBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftRedactBlendMode : IStringEnum
{
    public static readonly AnnotationDraftRedactBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftRedactBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftRedactBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftRedactBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftRedactBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftRedactBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftRedactBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftRedactBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftRedactBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftRedactBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftRedactBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftRedactBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftRedactBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftRedactBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftRedactBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftRedactBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftRedactBlendMode(string value)
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
    public static AnnotationDraftRedactBlendMode FromCustom(string value)
    {
        return new AnnotationDraftRedactBlendMode(value);
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

    public static bool operator ==(AnnotationDraftRedactBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftRedactBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftRedactBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftRedactBlendMode(string value) => new(value);

    internal class AnnotationDraftRedactBlendModeSerializer
        : JsonConverter<AnnotationDraftRedactBlendMode>
    {
        public override AnnotationDraftRedactBlendMode Read(
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
            return new AnnotationDraftRedactBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftRedactBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftRedactBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftRedactBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftRedactBlendMode value,
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
