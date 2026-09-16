using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete409ResponseCode.DocSignaturesComplete409ResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete409ResponseCode : IStringEnum
{
    public static readonly DocSignaturesComplete409ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocSignaturesComplete409ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocSignaturesComplete409ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocSignaturesComplete409ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocSignaturesComplete409ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocSignaturesComplete409ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocSignaturesComplete409ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocSignaturesComplete409ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocSignaturesComplete409ResponseCode Network = new(Values.Network);

    public static readonly DocSignaturesComplete409ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocSignaturesComplete409ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocSignaturesComplete409ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocSignaturesComplete409ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocSignaturesComplete409ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocSignaturesComplete409ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocSignaturesComplete409ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocSignaturesComplete409ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocSignaturesComplete409ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocSignaturesComplete409ResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public static readonly DocSignaturesComplete409ResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocSignaturesComplete409ResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocSignaturesComplete409ResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocSignaturesComplete409ResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocSignaturesComplete409ResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocSignaturesComplete409ResponseCode StaleBase = new(Values.StaleBase);

    public DocSignaturesComplete409ResponseCode(string value)
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
    public static DocSignaturesComplete409ResponseCode FromCustom(string value)
    {
        return new DocSignaturesComplete409ResponseCode(value);
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

    public static bool operator ==(DocSignaturesComplete409ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesComplete409ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesComplete409ResponseCode value) =>
        value.Value;

    public static explicit operator DocSignaturesComplete409ResponseCode(string value) =>
        new(value);

    internal class DocSignaturesComplete409ResponseCodeSerializer
        : JsonConverter<DocSignaturesComplete409ResponseCode>
    {
        public override DocSignaturesComplete409ResponseCode Read(
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
            return new DocSignaturesComplete409ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete409ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete409ResponseCode ReadAsPropertyName(
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
            return new DocSignaturesComplete409ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete409ResponseCode value,
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
        public const string Unknown = "Unknown";

        public const string InvalidArg = "InvalidArg";

        public const string DocNotOpen = "DocNotOpen";

        public const string DocOpenFailed = "DocOpenFailed";

        public const string DocPasswordRequired = "DocPasswordRequired";

        public const string DocPasswordIncorrect = "DocPasswordIncorrect";

        public const string SharePasswordRequired = "SharePasswordRequired";

        public const string Aborted = "Aborted";

        public const string Network = "Network";

        public const string Unauthenticated = "Unauthenticated";

        public const string Forbidden = "Forbidden";

        public const string NotFound = "NotFound";

        public const string WireFormat = "WireFormat";

        public const string RuntimeUnavailable = "RuntimeUnavailable";

        public const string InvalidReference = "InvalidReference";

        public const string WeakAnnotationSessionConflict = "WeakAnnotationSessionConflict";

        public const string LayerVersionConflict = "LayerVersionConflict";

        public const string NotImplemented = "NotImplemented";

        public const string MalformedPdf = "MalformedPdf";

        public const string SigningPending = "SigningPending";

        public const string SigningExpired = "SigningExpired";

        public const string SigningVersionMismatch = "SigningVersionMismatch";

        public const string SignatureRefused = "SignatureRefused";

        public const string ProtectedDocument = "ProtectedDocument";

        public const string StaleBase = "StaleBase";
    }
}
