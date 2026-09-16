using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysis200ResponseRestrictionsItemSource.DocVersionsAnalysis200ResponseRestrictionsItemSourceSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysis200ResponseRestrictionsItemSource : IStringEnum
{
    public static readonly DocVersionsAnalysis200ResponseRestrictionsItemSource Docmdp = new(
        Values.Docmdp
    );

    public static readonly DocVersionsAnalysis200ResponseRestrictionsItemSource Fieldmdp = new(
        Values.Fieldmdp
    );

    public static readonly DocVersionsAnalysis200ResponseRestrictionsItemSource Lock = new(
        Values.Lock
    );

    public DocVersionsAnalysis200ResponseRestrictionsItemSource(string value)
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
    public static DocVersionsAnalysis200ResponseRestrictionsItemSource FromCustom(string value)
    {
        return new DocVersionsAnalysis200ResponseRestrictionsItemSource(value);
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
        DocVersionsAnalysis200ResponseRestrictionsItemSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysis200ResponseRestrictionsItemSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsAnalysis200ResponseRestrictionsItemSource value
    ) => value.Value;

    public static explicit operator DocVersionsAnalysis200ResponseRestrictionsItemSource(
        string value
    ) => new(value);

    internal class DocVersionsAnalysis200ResponseRestrictionsItemSourceSerializer
        : JsonConverter<DocVersionsAnalysis200ResponseRestrictionsItemSource>
    {
        public override DocVersionsAnalysis200ResponseRestrictionsItemSource Read(
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
            return new DocVersionsAnalysis200ResponseRestrictionsItemSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseRestrictionsItemSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysis200ResponseRestrictionsItemSource ReadAsPropertyName(
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
            return new DocVersionsAnalysis200ResponseRestrictionsItemSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseRestrictionsItemSource value,
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
