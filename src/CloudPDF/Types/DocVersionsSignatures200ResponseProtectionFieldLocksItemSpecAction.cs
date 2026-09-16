using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction.DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecActionSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction
    : IStringEnum
{
    public static readonly DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction All =
        new(Values.All);

    public static readonly DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction Include =
        new(Values.Include);

    public static readonly DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction Exclude =
        new(Values.Exclude);

    public DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction(string value)
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
    public static DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction FromCustom(
        string value
    )
    {
        return new DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction(value);
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
        DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction value
    ) => value.Value;

    public static explicit operator DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction(
        string value
    ) => new(value);

    internal class DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecActionSerializer
        : JsonConverter<DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction>
    {
        public override DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction Read(
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
            return new DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction ReadAsPropertyName(
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
            return new DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignatures200ResponseProtectionFieldLocksItemSpecAction value,
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
