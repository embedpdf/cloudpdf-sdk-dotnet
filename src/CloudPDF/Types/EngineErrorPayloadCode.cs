using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(EngineErrorPayloadCode.EngineErrorPayloadCodeSerializer))]
[Serializable]
public readonly record struct EngineErrorPayloadCode : IStringEnum
{
    public static readonly EngineErrorPayloadCode Unknown = new(Values.Unknown);

    public static readonly EngineErrorPayloadCode InvalidArg = new(Values.InvalidArg);

    public static readonly EngineErrorPayloadCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly EngineErrorPayloadCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly EngineErrorPayloadCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly EngineErrorPayloadCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly EngineErrorPayloadCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly EngineErrorPayloadCode Aborted = new(Values.Aborted);

    public static readonly EngineErrorPayloadCode Network = new(Values.Network);

    public static readonly EngineErrorPayloadCode Unauthenticated = new(Values.Unauthenticated);

    public static readonly EngineErrorPayloadCode Forbidden = new(Values.Forbidden);

    public static readonly EngineErrorPayloadCode NotFound = new(Values.NotFound);

    public static readonly EngineErrorPayloadCode WireFormat = new(Values.WireFormat);

    public static readonly EngineErrorPayloadCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly EngineErrorPayloadCode InvalidReference = new(Values.InvalidReference);

    public static readonly EngineErrorPayloadCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly EngineErrorPayloadCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly EngineErrorPayloadCode NotImplemented = new(Values.NotImplemented);

    public static readonly EngineErrorPayloadCode MalformedPdf = new(Values.MalformedPdf);

    public EngineErrorPayloadCode(string value)
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
    public static EngineErrorPayloadCode FromCustom(string value)
    {
        return new EngineErrorPayloadCode(value);
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

    public static bool operator ==(EngineErrorPayloadCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EngineErrorPayloadCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EngineErrorPayloadCode value) => value.Value;

    public static explicit operator EngineErrorPayloadCode(string value) => new(value);

    internal class EngineErrorPayloadCodeSerializer : JsonConverter<EngineErrorPayloadCode>
    {
        public override EngineErrorPayloadCode Read(
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
            return new EngineErrorPayloadCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EngineErrorPayloadCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EngineErrorPayloadCode ReadAsPropertyName(
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
            return new EngineErrorPayloadCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EngineErrorPayloadCode value,
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
