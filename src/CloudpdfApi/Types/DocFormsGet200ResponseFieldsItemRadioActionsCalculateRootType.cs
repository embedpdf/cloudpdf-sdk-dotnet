using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType.DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Goto = new(
        Values.Goto
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Uri = new(
        Values.Uri
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Sound =
        new(Values.Sound);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Movie =
        new(Values.Movie);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Hide = new(
        Values.Hide
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Named =
        new(Values.Named);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType(value);
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
        DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType>
    {
        public override DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioActionsCalculateRootType value,
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
