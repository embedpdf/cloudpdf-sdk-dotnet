using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType.DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Goto =
        new(Values.Goto);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Uri =
        new(Values.Uri);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Sound =
        new(Values.Sound);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Movie =
        new(Values.Movie);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Hide =
        new(Values.Hide);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Named =
        new(Values.Named);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType(value);
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
        DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType>
    {
        public override DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemSignatureActionsKeystrokeRootType value,
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
