using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete200ResponseSignatureFieldMdpAction.DocSignaturesComplete200ResponseSignatureFieldMdpActionSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete200ResponseSignatureFieldMdpAction : IStringEnum
{
    public static readonly DocSignaturesComplete200ResponseSignatureFieldMdpAction All = new(
        Values.All
    );

    public static readonly DocSignaturesComplete200ResponseSignatureFieldMdpAction Include = new(
        Values.Include
    );

    public static readonly DocSignaturesComplete200ResponseSignatureFieldMdpAction Exclude = new(
        Values.Exclude
    );

    public DocSignaturesComplete200ResponseSignatureFieldMdpAction(string value)
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
    public static DocSignaturesComplete200ResponseSignatureFieldMdpAction FromCustom(string value)
    {
        return new DocSignaturesComplete200ResponseSignatureFieldMdpAction(value);
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
        DocSignaturesComplete200ResponseSignatureFieldMdpAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesComplete200ResponseSignatureFieldMdpAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesComplete200ResponseSignatureFieldMdpAction value
    ) => value.Value;

    public static explicit operator DocSignaturesComplete200ResponseSignatureFieldMdpAction(
        string value
    ) => new(value);

    internal class DocSignaturesComplete200ResponseSignatureFieldMdpActionSerializer
        : JsonConverter<DocSignaturesComplete200ResponseSignatureFieldMdpAction>
    {
        public override DocSignaturesComplete200ResponseSignatureFieldMdpAction Read(
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
            return new DocSignaturesComplete200ResponseSignatureFieldMdpAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureFieldMdpAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete200ResponseSignatureFieldMdpAction ReadAsPropertyName(
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
            return new DocSignaturesComplete200ResponseSignatureFieldMdpAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureFieldMdpAction value,
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
