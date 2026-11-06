using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignaturesResponseProtectionFieldLocksItemSource.DocVersionsSignaturesResponseProtectionFieldLocksItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignaturesResponseProtectionFieldLocksItemSource
    : IStringEnum
{
    public static readonly DocVersionsSignaturesResponseProtectionFieldLocksItemSource Fieldmdp =
        new(Values.Fieldmdp);

    public static readonly DocVersionsSignaturesResponseProtectionFieldLocksItemSource Lock = new(
        Values.Lock
    );

    public DocVersionsSignaturesResponseProtectionFieldLocksItemSource(string value)
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
    public static DocVersionsSignaturesResponseProtectionFieldLocksItemSource FromCustom(
        string value
    )
    {
        return new DocVersionsSignaturesResponseProtectionFieldLocksItemSource(value);
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
        DocVersionsSignaturesResponseProtectionFieldLocksItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignaturesResponseProtectionFieldLocksItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsSignaturesResponseProtectionFieldLocksItemSource value
    ) => value.Value;

    public static explicit operator DocVersionsSignaturesResponseProtectionFieldLocksItemSource(
        string value
    ) => new(value);

    internal class DocVersionsSignaturesResponseProtectionFieldLocksItemSourceSerializer
        : JsonConverter<DocVersionsSignaturesResponseProtectionFieldLocksItemSource>
    {
        public override DocVersionsSignaturesResponseProtectionFieldLocksItemSource Read(
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
            return new DocVersionsSignaturesResponseProtectionFieldLocksItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseProtectionFieldLocksItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignaturesResponseProtectionFieldLocksItemSource ReadAsPropertyName(
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
            return new DocVersionsSignaturesResponseProtectionFieldLocksItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseProtectionFieldLocksItemSource value,
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
