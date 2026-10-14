using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesFlatten200ResponseUsage.DocPagesFlatten200ResponseUsageSerializer))]
[Serializable]
public readonly record struct DocPagesFlatten200ResponseUsage : IStringEnum
{
    public static readonly DocPagesFlatten200ResponseUsage Display = new(Values.Display);

    public static readonly DocPagesFlatten200ResponseUsage Print = new(Values.Print);

    public DocPagesFlatten200ResponseUsage(string value)
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
    public static DocPagesFlatten200ResponseUsage FromCustom(string value)
    {
        return new DocPagesFlatten200ResponseUsage(value);
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

    public static bool operator ==(DocPagesFlatten200ResponseUsage value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesFlatten200ResponseUsage value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesFlatten200ResponseUsage value) => value.Value;

    public static explicit operator DocPagesFlatten200ResponseUsage(string value) => new(value);

    internal class DocPagesFlatten200ResponseUsageSerializer
        : JsonConverter<DocPagesFlatten200ResponseUsage>
    {
        public override DocPagesFlatten200ResponseUsage Read(
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
            return new DocPagesFlatten200ResponseUsage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesFlatten200ResponseUsage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesFlatten200ResponseUsage ReadAsPropertyName(
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
            return new DocPagesFlatten200ResponseUsage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesFlatten200ResponseUsage value,
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
