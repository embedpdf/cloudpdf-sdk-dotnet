using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType.DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Goto =
        new(Values.Goto);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Uri =
        new(Values.Uri);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Sound =
        new(Values.Sound);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Movie =
        new(Values.Movie);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Hide =
        new(Values.Hide);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Named =
        new(Values.Named);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType(value);
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
        DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType>
    {
        public override DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemCheckboxActionsValidateRootType value,
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
