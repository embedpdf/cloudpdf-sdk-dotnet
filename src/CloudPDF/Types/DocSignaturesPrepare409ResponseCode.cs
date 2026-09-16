using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesPrepare409ResponseCode.DocSignaturesPrepare409ResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesPrepare409ResponseCode : IStringEnum
{
    public static readonly DocSignaturesPrepare409ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocSignaturesPrepare409ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocSignaturesPrepare409ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocSignaturesPrepare409ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocSignaturesPrepare409ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocSignaturesPrepare409ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocSignaturesPrepare409ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocSignaturesPrepare409ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocSignaturesPrepare409ResponseCode Network = new(Values.Network);

    public static readonly DocSignaturesPrepare409ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocSignaturesPrepare409ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocSignaturesPrepare409ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocSignaturesPrepare409ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocSignaturesPrepare409ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocSignaturesPrepare409ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocSignaturesPrepare409ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocSignaturesPrepare409ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocSignaturesPrepare409ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocSignaturesPrepare409ResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public static readonly DocSignaturesPrepare409ResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocSignaturesPrepare409ResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocSignaturesPrepare409ResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocSignaturesPrepare409ResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocSignaturesPrepare409ResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocSignaturesPrepare409ResponseCode StaleBase = new(Values.StaleBase);

    public DocSignaturesPrepare409ResponseCode(string value)
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
    public static DocSignaturesPrepare409ResponseCode FromCustom(string value)
    {
        return new DocSignaturesPrepare409ResponseCode(value);
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

    public static bool operator ==(DocSignaturesPrepare409ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesPrepare409ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesPrepare409ResponseCode value) =>
        value.Value;

    public static explicit operator DocSignaturesPrepare409ResponseCode(string value) => new(value);

    internal class DocSignaturesPrepare409ResponseCodeSerializer
        : JsonConverter<DocSignaturesPrepare409ResponseCode>
    {
        public override DocSignaturesPrepare409ResponseCode Read(
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
            return new DocSignaturesPrepare409ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesPrepare409ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesPrepare409ResponseCode ReadAsPropertyName(
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
            return new DocSignaturesPrepare409ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesPrepare409ResponseCode value,
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
