using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType.DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Goto =
        new(Values.Goto);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Uri = new(
        Values.Uri
    );

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Sound =
        new(Values.Sound);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Movie =
        new(Values.Movie);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Hide =
        new(Values.Hide);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Named =
        new(Values.Named);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType(value);
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
        DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType>
    {
        public override DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureActionsFormatRootType value,
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
        public const string Unknown = "unknown";

        public const string Goto = "goto";

        public const string GotoRemote = "goto-remote";

        public const string GotoEmbedded = "goto-embedded";

        public const string Launch = "launch";

        public const string Thread = "thread";

        public const string Uri = "uri";

        public const string Sound = "sound";

        public const string Movie = "movie";

        public const string Hide = "hide";

        public const string Named = "named";

        public const string SubmitForm = "submit-form";

        public const string ResetForm = "reset-form";

        public const string ImportData = "import-data";

        public const string Javascript = "javascript";

        public const string SetOcgState = "set-ocg-state";

        public const string Rendition = "rendition";

        public const string Transition = "transition";

        public const string Goto3DView = "goto-3d-view";
    }
}
