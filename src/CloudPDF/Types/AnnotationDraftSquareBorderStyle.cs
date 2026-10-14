using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftSquareBorderStyle.AnnotationDraftSquareBorderStyleSerializer))]
[Serializable]
public readonly record struct AnnotationDraftSquareBorderStyle : IStringEnum
{
    public static readonly AnnotationDraftSquareBorderStyle Solid = new(Values.Solid);

    public static readonly AnnotationDraftSquareBorderStyle Dashed = new(Values.Dashed);

    public AnnotationDraftSquareBorderStyle(string value)
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
    public static AnnotationDraftSquareBorderStyle FromCustom(string value)
    {
        return new AnnotationDraftSquareBorderStyle(value);
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

    public static bool operator ==(AnnotationDraftSquareBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftSquareBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftSquareBorderStyle value) => value.Value;

    public static explicit operator AnnotationDraftSquareBorderStyle(string value) => new(value);

    internal class AnnotationDraftSquareBorderStyleSerializer
        : JsonConverter<AnnotationDraftSquareBorderStyle>
    {
        public override AnnotationDraftSquareBorderStyle Read(
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
            return new AnnotationDraftSquareBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftSquareBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftSquareBorderStyle ReadAsPropertyName(
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
            return new AnnotationDraftSquareBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftSquareBorderStyle value,
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
        public const string Solid = "solid";

        public const string Dashed = "dashed";
    }
}
