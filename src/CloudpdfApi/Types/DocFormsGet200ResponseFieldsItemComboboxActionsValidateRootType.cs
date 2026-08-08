using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType.DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Goto =
        new(Values.Goto);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Uri =
        new(Values.Uri);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Sound =
        new(Values.Sound);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Movie =
        new(Values.Movie);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Hide =
        new(Values.Hide);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Named =
        new(Values.Named);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType(value);
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
        DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType>
    {
        public override DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemComboboxActionsValidateRootType value,
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
