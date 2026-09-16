using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction.DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecActionSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction
    : IStringEnum
{
    public static readonly DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction All =
        new(Values.All);

    public static readonly DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction Include =
        new(Values.Include);

    public static readonly DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction Exclude =
        new(Values.Exclude);

    public DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction(string value)
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
    public static DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction FromCustom(
        string value
    )
    {
        return new DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction(value);
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
        DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction value
    ) => value.Value;

    public static explicit operator DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction(
        string value
    ) => new(value);

    internal class DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecActionSerializer
        : JsonConverter<DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction>
    {
        public override DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction Read(
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
            return new DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction ReadAsPropertyName(
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
            return new DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseProtectionFieldLocksItemSpecAction value,
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
