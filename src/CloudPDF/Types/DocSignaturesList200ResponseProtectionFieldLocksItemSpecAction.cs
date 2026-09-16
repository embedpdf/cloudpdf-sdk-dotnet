using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction.DocSignaturesList200ResponseProtectionFieldLocksItemSpecActionSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction
    : IStringEnum
{
    public static readonly DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction All = new(
        Values.All
    );

    public static readonly DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction Include =
        new(Values.Include);

    public static readonly DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction Exclude =
        new(Values.Exclude);

    public DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction(string value)
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
    public static DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction FromCustom(
        string value
    )
    {
        return new DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction(value);
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
        DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction value
    ) => value.Value;

    public static explicit operator DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction(
        string value
    ) => new(value);

    internal class DocSignaturesList200ResponseProtectionFieldLocksItemSpecActionSerializer
        : JsonConverter<DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction>
    {
        public override DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction Read(
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
            return new DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction ReadAsPropertyName(
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
            return new DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseProtectionFieldLocksItemSpecAction value,
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
        public const string All = "all";

        public const string Include = "include";

        public const string Exclude = "exclude";
    }
}
