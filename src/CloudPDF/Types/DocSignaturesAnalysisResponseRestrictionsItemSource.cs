using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseRestrictionsItemSource.DocSignaturesAnalysisResponseRestrictionsItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseRestrictionsItemSource : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseRestrictionsItemSource Docmdp = new(
        Values.Docmdp
    );

    public static readonly DocSignaturesAnalysisResponseRestrictionsItemSource Fieldmdp = new(
        Values.Fieldmdp
    );

    public static readonly DocSignaturesAnalysisResponseRestrictionsItemSource Lock = new(
        Values.Lock
    );

    public DocSignaturesAnalysisResponseRestrictionsItemSource(string value)
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
    public static DocSignaturesAnalysisResponseRestrictionsItemSource FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseRestrictionsItemSource(value);
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
        DocSignaturesAnalysisResponseRestrictionsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysisResponseRestrictionsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesAnalysisResponseRestrictionsItemSource value
    ) => value.Value;

    public static explicit operator DocSignaturesAnalysisResponseRestrictionsItemSource(
        string value
    ) => new(value);

    internal class DocSignaturesAnalysisResponseRestrictionsItemSourceSerializer
        : JsonConverter<DocSignaturesAnalysisResponseRestrictionsItemSource>
    {
        public override DocSignaturesAnalysisResponseRestrictionsItemSource Read(
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
            return new DocSignaturesAnalysisResponseRestrictionsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseRestrictionsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseRestrictionsItemSource ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseRestrictionsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseRestrictionsItemSource value,
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
