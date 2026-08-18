using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsExportDataResponseCode.DocFormsExportDataResponseCodeSerializer))]
[Serializable]
public readonly record struct DocFormsExportDataResponseCode : IStringEnum
{
    public static readonly DocFormsExportDataResponseCode Unknown = new(Values.Unknown);

    public static readonly DocFormsExportDataResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocFormsExportDataResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocFormsExportDataResponseCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly DocFormsExportDataResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocFormsExportDataResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocFormsExportDataResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocFormsExportDataResponseCode Aborted = new(Values.Aborted);

    public static readonly DocFormsExportDataResponseCode Network = new(Values.Network);

    public static readonly DocFormsExportDataResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocFormsExportDataResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocFormsExportDataResponseCode NotFound = new(Values.NotFound);

    public static readonly DocFormsExportDataResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocFormsExportDataResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocFormsExportDataResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocFormsExportDataResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocFormsExportDataResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocFormsExportDataResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocFormsExportDataResponseCode MalformedPdf = new(Values.MalformedPdf);

    public DocFormsExportDataResponseCode(string value)
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
    public static DocFormsExportDataResponseCode FromCustom(string value)
    {
        return new DocFormsExportDataResponseCode(value);
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

    public static bool operator ==(DocFormsExportDataResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocFormsExportDataResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsExportDataResponseCode value) => value.Value;

    public static explicit operator DocFormsExportDataResponseCode(string value) => new(value);

    internal class DocFormsExportDataResponseCodeSerializer
        : JsonConverter<DocFormsExportDataResponseCode>
    {
        public override DocFormsExportDataResponseCode Read(
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
            return new DocFormsExportDataResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsExportDataResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsExportDataResponseCode ReadAsPropertyName(
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
            return new DocFormsExportDataResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsExportDataResponseCode value,
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
    }
}
