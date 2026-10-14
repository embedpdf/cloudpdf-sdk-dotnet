using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftLineBlendMode.AnnotationDraftLineBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftLineBlendMode : IStringEnum
{
    public static readonly AnnotationDraftLineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftLineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftLineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftLineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftLineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftLineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftLineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftLineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftLineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftLineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftLineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftLineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftLineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftLineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftLineBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftLineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftLineBlendMode(string value)
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
    public static AnnotationDraftLineBlendMode FromCustom(string value)
    {
        return new AnnotationDraftLineBlendMode(value);
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

    public static bool operator ==(AnnotationDraftLineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftLineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftLineBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftLineBlendMode(string value) => new(value);

    internal class AnnotationDraftLineBlendModeSerializer
        : JsonConverter<AnnotationDraftLineBlendMode>
    {
        public override AnnotationDraftLineBlendMode Read(
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
            return new AnnotationDraftLineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftLineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineBlendMode value,
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
