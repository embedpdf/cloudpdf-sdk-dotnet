using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesFlattenResponseUsage.DocPagesFlattenResponseUsageSerializer))]
[Serializable]
public readonly record struct DocPagesFlattenResponseUsage : IStringEnum
{
    public static readonly DocPagesFlattenResponseUsage Display = new(Values.Display);

    public static readonly DocPagesFlattenResponseUsage Print = new(Values.Print);

    public DocPagesFlattenResponseUsage(string value)
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
    public static DocPagesFlattenResponseUsage FromCustom(string value)
    {
        return new DocPagesFlattenResponseUsage(value);
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

    public static bool operator ==(DocPagesFlattenResponseUsage value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesFlattenResponseUsage value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesFlattenResponseUsage value) => value.Value;

    public static explicit operator DocPagesFlattenResponseUsage(string value) => new(value);

    internal class DocPagesFlattenResponseUsageSerializer
        : JsonConverter<DocPagesFlattenResponseUsage>
    {
        public override DocPagesFlattenResponseUsage Read(
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
            return new DocPagesFlattenResponseUsage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesFlattenResponseUsage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesFlattenResponseUsage ReadAsPropertyName(
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
            return new DocPagesFlattenResponseUsage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesFlattenResponseUsage value,
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
