using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsFlattenResponseUsage.DocAnnotationsFlattenResponseUsageSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsFlattenResponseUsage : IStringEnum
{
    public static readonly DocAnnotationsFlattenResponseUsage Display = new(Values.Display);

    public static readonly DocAnnotationsFlattenResponseUsage Print = new(Values.Print);

    public DocAnnotationsFlattenResponseUsage(string value)
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
    public static DocAnnotationsFlattenResponseUsage FromCustom(string value)
    {
        return new DocAnnotationsFlattenResponseUsage(value);
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

    public static bool operator ==(DocAnnotationsFlattenResponseUsage value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocAnnotationsFlattenResponseUsage value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsFlattenResponseUsage value) => value.Value;

    public static explicit operator DocAnnotationsFlattenResponseUsage(string value) => new(value);

    internal class DocAnnotationsFlattenResponseUsageSerializer
        : JsonConverter<DocAnnotationsFlattenResponseUsage>
    {
        public override DocAnnotationsFlattenResponseUsage Read(
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
            return new DocAnnotationsFlattenResponseUsage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsFlattenResponseUsage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsFlattenResponseUsage ReadAsPropertyName(
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
            return new DocAnnotationsFlattenResponseUsage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsFlattenResponseUsage value,
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
        public const string Display = "display";

        public const string Print = "print";
    }
}
