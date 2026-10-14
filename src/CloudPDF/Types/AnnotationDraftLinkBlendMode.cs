using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftLinkBlendMode.AnnotationDraftLinkBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftLinkBlendMode : IStringEnum
{
    public static readonly AnnotationDraftLinkBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftLinkBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftLinkBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftLinkBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftLinkBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftLinkBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftLinkBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftLinkBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftLinkBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftLinkBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftLinkBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftLinkBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftLinkBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftLinkBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftLinkBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftLinkBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftLinkBlendMode(string value)
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
    public static AnnotationDraftLinkBlendMode FromCustom(string value)
    {
        return new AnnotationDraftLinkBlendMode(value);
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

    public static bool operator ==(AnnotationDraftLinkBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftLinkBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftLinkBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftLinkBlendMode(string value) => new(value);

    internal class AnnotationDraftLinkBlendModeSerializer
        : JsonConverter<AnnotationDraftLinkBlendMode>
    {
        public override AnnotationDraftLinkBlendMode Read(
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
            return new AnnotationDraftLinkBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLinkBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLinkBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftLinkBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLinkBlendMode value,
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
