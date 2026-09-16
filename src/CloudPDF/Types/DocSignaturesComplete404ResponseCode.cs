using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete404ResponseCode.DocSignaturesComplete404ResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete404ResponseCode : IStringEnum
{
    public static readonly DocSignaturesComplete404ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocSignaturesComplete404ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocSignaturesComplete404ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocSignaturesComplete404ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocSignaturesComplete404ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocSignaturesComplete404ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocSignaturesComplete404ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocSignaturesComplete404ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocSignaturesComplete404ResponseCode Network = new(Values.Network);

    public static readonly DocSignaturesComplete404ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocSignaturesComplete404ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocSignaturesComplete404ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocSignaturesComplete404ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocSignaturesComplete404ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocSignaturesComplete404ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocSignaturesComplete404ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocSignaturesComplete404ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocSignaturesComplete404ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocSignaturesComplete404ResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public static readonly DocSignaturesComplete404ResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocSignaturesComplete404ResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocSignaturesComplete404ResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocSignaturesComplete404ResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocSignaturesComplete404ResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocSignaturesComplete404ResponseCode StaleBase = new(Values.StaleBase);

    public DocSignaturesComplete404ResponseCode(string value)
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
    public static DocSignaturesComplete404ResponseCode FromCustom(string value)
    {
        return new DocSignaturesComplete404ResponseCode(value);
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

    public static bool operator ==(DocSignaturesComplete404ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesComplete404ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesComplete404ResponseCode value) =>
        value.Value;

    public static explicit operator DocSignaturesComplete404ResponseCode(string value) =>
        new(value);

    internal class DocSignaturesComplete404ResponseCodeSerializer
        : JsonConverter<DocSignaturesComplete404ResponseCode>
    {
        public override DocSignaturesComplete404ResponseCode Read(
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
            return new DocSignaturesComplete404ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete404ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete404ResponseCode ReadAsPropertyName(
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
            return new DocSignaturesComplete404ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete404ResponseCode value,
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
