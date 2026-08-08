using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType.DocFormsGet200ResponseFieldsItemRadioActionsValidateRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Goto = new(
        Values.Goto
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Uri = new(
        Values.Uri
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Sound = new(
        Values.Sound
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Movie = new(
        Values.Movie
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Hide = new(
        Values.Hide
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Named = new(
        Values.Named
    );

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType(value);
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
        DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemRadioActionsValidateRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType>
    {
        public override DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemRadioActionsValidateRootType value,
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
