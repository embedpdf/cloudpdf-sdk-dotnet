using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationLineBorderStyle.AnnotationLineBorderStyleSerializer))]
[Serializable]
public readonly record struct AnnotationLineBorderStyle : IStringEnum
{
    public static readonly AnnotationLineBorderStyle Solid = new(Values.Solid);

    public static readonly AnnotationLineBorderStyle Dashed = new(Values.Dashed);

    public static readonly AnnotationLineBorderStyle Beveled = new(Values.Beveled);

    public static readonly AnnotationLineBorderStyle Inset = new(Values.Inset);

    public AnnotationLineBorderStyle(string value)
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
    public static AnnotationLineBorderStyle FromCustom(string value)
    {
        return new AnnotationLineBorderStyle(value);
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

    public static bool operator ==(AnnotationLineBorderStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationLineBorderStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationLineBorderStyle value) => value.Value;

    public static explicit operator AnnotationLineBorderStyle(string value) => new(value);

    internal class AnnotationLineBorderStyleSerializer : JsonConverter<AnnotationLineBorderStyle>
    {
        public override AnnotationLineBorderStyle Read(
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
            return new AnnotationLineBorderStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationLineBorderStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationLineBorderStyle ReadAsPropertyName(
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
            return new AnnotationLineBorderStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationLineBorderStyle value,
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

        public const string Beveled = "beveled";

        public const string Inset = "inset";
    }
}
