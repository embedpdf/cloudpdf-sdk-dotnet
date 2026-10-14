using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifest200ResponseProtectionFieldLocksItemSource.DocManifest200ResponseProtectionFieldLocksItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocManifest200ResponseProtectionFieldLocksItemSource : IStringEnum
{
    public static readonly DocManifest200ResponseProtectionFieldLocksItemSource Fieldmdp = new(
        Values.Fieldmdp
    );

    public static readonly DocManifest200ResponseProtectionFieldLocksItemSource Lock = new(
        Values.Lock
    );

    public DocManifest200ResponseProtectionFieldLocksItemSource(string value)
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
    public static DocManifest200ResponseProtectionFieldLocksItemSource FromCustom(string value)
    {
        return new DocManifest200ResponseProtectionFieldLocksItemSource(value);
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
        DocManifest200ResponseProtectionFieldLocksItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocManifest200ResponseProtectionFieldLocksItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocManifest200ResponseProtectionFieldLocksItemSource value
    ) => value.Value;

    public static explicit operator DocManifest200ResponseProtectionFieldLocksItemSource(
        string value
    ) => new(value);

    internal class DocManifest200ResponseProtectionFieldLocksItemSourceSerializer
        : JsonConverter<DocManifest200ResponseProtectionFieldLocksItemSource>
    {
        public override DocManifest200ResponseProtectionFieldLocksItemSource Read(
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
            return new DocManifest200ResponseProtectionFieldLocksItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest200ResponseProtectionFieldLocksItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifest200ResponseProtectionFieldLocksItemSource ReadAsPropertyName(
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
            return new DocManifest200ResponseProtectionFieldLocksItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest200ResponseProtectionFieldLocksItemSource value,
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
