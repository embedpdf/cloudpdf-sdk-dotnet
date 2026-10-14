using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationCaretIntent.AnnotationCaretIntentSerializer))]
[Serializable]
public readonly record struct AnnotationCaretIntent : IStringEnum
{
    public static readonly AnnotationCaretIntent Replace = new(Values.Replace);

    public AnnotationCaretIntent(string value)
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
    public static AnnotationCaretIntent FromCustom(string value)
    {
        return new AnnotationCaretIntent(value);
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

    public static bool operator ==(AnnotationCaretIntent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationCaretIntent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationCaretIntent value) => value.Value;

    public static explicit operator AnnotationCaretIntent(string value) => new(value);

    internal class AnnotationCaretIntentSerializer : JsonConverter<AnnotationCaretIntent>
    {
        public override AnnotationCaretIntent Read(
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
            return new AnnotationCaretIntent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationCaretIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationCaretIntent ReadAsPropertyName(
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
            return new AnnotationCaretIntent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationCaretIntent value,
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
