using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftLineIntent.AnnotationDraftLineIntentSerializer))]
[Serializable]
public readonly record struct AnnotationDraftLineIntent : IStringEnum
{
    public static readonly AnnotationDraftLineIntent LineArrow = new(Values.LineArrow);

    public static readonly AnnotationDraftLineIntent LineDimension = new(Values.LineDimension);

    public AnnotationDraftLineIntent(string value)
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
    public static AnnotationDraftLineIntent FromCustom(string value)
    {
        return new AnnotationDraftLineIntent(value);
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

    public static bool operator ==(AnnotationDraftLineIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftLineIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftLineIntent value) => value.Value;

    public static explicit operator AnnotationDraftLineIntent(string value) => new(value);

    internal class AnnotationDraftLineIntentSerializer : JsonConverter<AnnotationDraftLineIntent>
    {
        public override AnnotationDraftLineIntent Read(
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
            return new AnnotationDraftLineIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineIntent ReadAsPropertyName(
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
            return new AnnotationDraftLineIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineIntent value,
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
        public const string LineArrow = "line-arrow";

        public const string LineDimension = "line-dimension";
    }
}
