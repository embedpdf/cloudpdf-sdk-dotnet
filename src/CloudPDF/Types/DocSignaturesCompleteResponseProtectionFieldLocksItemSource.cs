using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCompleteResponseProtectionFieldLocksItemSource.DocSignaturesCompleteResponseProtectionFieldLocksItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCompleteResponseProtectionFieldLocksItemSource
    : IStringEnum
{
    public static readonly DocSignaturesCompleteResponseProtectionFieldLocksItemSource Fieldmdp =
        new(Values.Fieldmdp);

    public static readonly DocSignaturesCompleteResponseProtectionFieldLocksItemSource Lock = new(
        Values.Lock
    );

    public DocSignaturesCompleteResponseProtectionFieldLocksItemSource(string value)
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
    public static DocSignaturesCompleteResponseProtectionFieldLocksItemSource FromCustom(
        string value
    )
    {
        return new DocSignaturesCompleteResponseProtectionFieldLocksItemSource(value);
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

    public static bool operator ==(
        DocSignaturesCompleteResponseProtectionFieldLocksItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesCompleteResponseProtectionFieldLocksItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesCompleteResponseProtectionFieldLocksItemSource value
    ) => value.Value;

    public static explicit operator DocSignaturesCompleteResponseProtectionFieldLocksItemSource(
        string value
    ) => new(value);

    internal class DocSignaturesCompleteResponseProtectionFieldLocksItemSourceSerializer
        : JsonConverter<DocSignaturesCompleteResponseProtectionFieldLocksItemSource>
    {
        public override DocSignaturesCompleteResponseProtectionFieldLocksItemSource Read(
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
            return new DocSignaturesCompleteResponseProtectionFieldLocksItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseProtectionFieldLocksItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCompleteResponseProtectionFieldLocksItemSource ReadAsPropertyName(
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
            return new DocSignaturesCompleteResponseProtectionFieldLocksItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseProtectionFieldLocksItemSource value,
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
        public const string Fieldmdp = "fieldmdp";

        public const string Lock = "lock";
    }
}
