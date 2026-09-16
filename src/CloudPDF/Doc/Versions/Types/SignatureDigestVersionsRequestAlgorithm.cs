using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(SignatureDigestVersionsRequestAlgorithm.SignatureDigestVersionsRequestAlgorithmSerializer)
)]
[Serializable]
public readonly record struct SignatureDigestVersionsRequestAlgorithm : IStringEnum
{
    public static readonly SignatureDigestVersionsRequestAlgorithm Sha1 = new(Values.Sha1);

    public static readonly SignatureDigestVersionsRequestAlgorithm Sha256 = new(Values.Sha256);

    public static readonly SignatureDigestVersionsRequestAlgorithm Sha384 = new(Values.Sha384);

    public static readonly SignatureDigestVersionsRequestAlgorithm Sha512 = new(Values.Sha512);

    public SignatureDigestVersionsRequestAlgorithm(string value)
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
    public static SignatureDigestVersionsRequestAlgorithm FromCustom(string value)
    {
        return new SignatureDigestVersionsRequestAlgorithm(value);
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

    public static bool operator ==(SignatureDigestVersionsRequestAlgorithm value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SignatureDigestVersionsRequestAlgorithm value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SignatureDigestVersionsRequestAlgorithm value) =>
        value.Value;

    public static explicit operator SignatureDigestVersionsRequestAlgorithm(string value) =>
        new(value);

    internal class SignatureDigestVersionsRequestAlgorithmSerializer
        : JsonConverter<SignatureDigestVersionsRequestAlgorithm>
    {
        public override SignatureDigestVersionsRequestAlgorithm Read(
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
            return new SignatureDigestVersionsRequestAlgorithm(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SignatureDigestVersionsRequestAlgorithm value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SignatureDigestVersionsRequestAlgorithm ReadAsPropertyName(
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
            return new SignatureDigestVersionsRequestAlgorithm(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SignatureDigestVersionsRequestAlgorithm value,
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
        public const string Sha1 = "sha1";

        public const string Sha256 = "sha256";

        public const string Sha384 = "sha384";

        public const string Sha512 = "sha512";
    }
}
