using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocSignaturesList404ResponseCode.DocSignaturesList404ResponseCodeSerializer))]
[Serializable]
public readonly record struct DocSignaturesList404ResponseCode : IStringEnum
{
    public static readonly DocSignaturesList404ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocSignaturesList404ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocSignaturesList404ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocSignaturesList404ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocSignaturesList404ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocSignaturesList404ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocSignaturesList404ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocSignaturesList404ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocSignaturesList404ResponseCode Network = new(Values.Network);

    public static readonly DocSignaturesList404ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocSignaturesList404ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocSignaturesList404ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocSignaturesList404ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocSignaturesList404ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocSignaturesList404ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocSignaturesList404ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocSignaturesList404ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocSignaturesList404ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocSignaturesList404ResponseCode MalformedPdf = new(Values.MalformedPdf);

    public static readonly DocSignaturesList404ResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocSignaturesList404ResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocSignaturesList404ResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocSignaturesList404ResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocSignaturesList404ResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocSignaturesList404ResponseCode StaleBase = new(Values.StaleBase);

    public DocSignaturesList404ResponseCode(string value)
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
    public static DocSignaturesList404ResponseCode FromCustom(string value)
    {
        return new DocSignaturesList404ResponseCode(value);
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

    public static bool operator ==(DocSignaturesList404ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesList404ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesList404ResponseCode value) => value.Value;

    public static explicit operator DocSignaturesList404ResponseCode(string value) => new(value);

    internal class DocSignaturesList404ResponseCodeSerializer
        : JsonConverter<DocSignaturesList404ResponseCode>
    {
        public override DocSignaturesList404ResponseCode Read(
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
            return new DocSignaturesList404ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList404ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesList404ResponseCode ReadAsPropertyName(
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
            return new DocSignaturesList404ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList404ResponseCode value,
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
