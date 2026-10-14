using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFileAttachmentBlendMode.AnnotationDraftFileAttachmentBlendModeSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFileAttachmentBlendMode : IStringEnum
{
    public static readonly AnnotationDraftFileAttachmentBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftFileAttachmentBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftFileAttachmentBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftFileAttachmentBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftFileAttachmentBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftFileAttachmentBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftFileAttachmentBlendMode ColorDodge = new(
        Values.ColorDodge
    );

    public static readonly AnnotationDraftFileAttachmentBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftFileAttachmentBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftFileAttachmentBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftFileAttachmentBlendMode Difference = new(
        Values.Difference
    );

    public static readonly AnnotationDraftFileAttachmentBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftFileAttachmentBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftFileAttachmentBlendMode Saturation = new(
        Values.Saturation
    );

    public static readonly AnnotationDraftFileAttachmentBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftFileAttachmentBlendMode Luminosity = new(
        Values.Luminosity
    );

    public AnnotationDraftFileAttachmentBlendMode(string value)
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
    public static AnnotationDraftFileAttachmentBlendMode FromCustom(string value)
    {
        return new AnnotationDraftFileAttachmentBlendMode(value);
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

    public static bool operator ==(AnnotationDraftFileAttachmentBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFileAttachmentBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFileAttachmentBlendMode value) =>
        value.Value;

    public static explicit operator AnnotationDraftFileAttachmentBlendMode(string value) =>
        new(value);

    internal class AnnotationDraftFileAttachmentBlendModeSerializer
        : JsonConverter<AnnotationDraftFileAttachmentBlendMode>
    {
        public override AnnotationDraftFileAttachmentBlendMode Read(
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
            return new AnnotationDraftFileAttachmentBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFileAttachmentBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFileAttachmentBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftFileAttachmentBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFileAttachmentBlendMode value,
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
