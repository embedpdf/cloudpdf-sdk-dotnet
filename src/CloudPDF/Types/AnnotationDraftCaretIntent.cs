using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftCaretIntent.AnnotationDraftCaretIntentSerializer))]
[Serializable]
public readonly record struct AnnotationDraftCaretIntent : IStringEnum
{
    public static readonly AnnotationDraftCaretIntent Replace = new(Values.Replace);

    public AnnotationDraftCaretIntent(string value)
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
    public static AnnotationDraftCaretIntent FromCustom(string value)
    {
        return new AnnotationDraftCaretIntent(value);
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

    public static bool operator ==(AnnotationDraftCaretIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftCaretIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftCaretIntent value) => value.Value;

    public static explicit operator AnnotationDraftCaretIntent(string value) => new(value);

    internal class AnnotationDraftCaretIntentSerializer : JsonConverter<AnnotationDraftCaretIntent>
    {
        public override AnnotationDraftCaretIntent Read(
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
            return new AnnotationDraftCaretIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftCaretIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftCaretIntent ReadAsPropertyName(
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
            return new AnnotationDraftCaretIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftCaretIntent value,
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
        public const string Replace = "replace";
    }
}
