using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysis200ResponseRestrictionsItemSource.DocSignaturesAnalysis200ResponseRestrictionsItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysis200ResponseRestrictionsItemSource : IStringEnum
{
    public static readonly DocSignaturesAnalysis200ResponseRestrictionsItemSource Docmdp = new(
        Values.Docmdp
    );

    public static readonly DocSignaturesAnalysis200ResponseRestrictionsItemSource Fieldmdp = new(
        Values.Fieldmdp
    );

    public static readonly DocSignaturesAnalysis200ResponseRestrictionsItemSource Lock = new(
        Values.Lock
    );

    public DocSignaturesAnalysis200ResponseRestrictionsItemSource(string value)
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
    public static DocSignaturesAnalysis200ResponseRestrictionsItemSource FromCustom(string value)
    {
        return new DocSignaturesAnalysis200ResponseRestrictionsItemSource(value);
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
        DocSignaturesAnalysis200ResponseRestrictionsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysis200ResponseRestrictionsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesAnalysis200ResponseRestrictionsItemSource value
    ) => value.Value;

    public static explicit operator DocSignaturesAnalysis200ResponseRestrictionsItemSource(
        string value
    ) => new(value);

    internal class DocSignaturesAnalysis200ResponseRestrictionsItemSourceSerializer
        : JsonConverter<DocSignaturesAnalysis200ResponseRestrictionsItemSource>
    {
        public override DocSignaturesAnalysis200ResponseRestrictionsItemSource Read(
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
            return new DocSignaturesAnalysis200ResponseRestrictionsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysis200ResponseRestrictionsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysis200ResponseRestrictionsItemSource ReadAsPropertyName(
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
            return new DocSignaturesAnalysis200ResponseRestrictionsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysis200ResponseRestrictionsItemSource value,
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
        public const string Docmdp = "docmdp";

        public const string Fieldmdp = "fieldmdp";

        public const string Lock = "lock";
    }
}
