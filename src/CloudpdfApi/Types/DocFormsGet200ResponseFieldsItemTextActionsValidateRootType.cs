using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemTextActionsValidateRootType.DocFormsGet200ResponseFieldsItemTextActionsValidateRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemTextActionsValidateRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Goto = new(
        Values.Goto
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Launch = new(
        Values.Launch
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Thread = new(
        Values.Thread
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Uri = new(
        Values.Uri
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Sound = new(
        Values.Sound
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Movie = new(
        Values.Movie
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Hide = new(
        Values.Hide
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Named = new(
        Values.Named
    );

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemTextActionsValidateRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemTextActionsValidateRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemTextActionsValidateRootType(value);
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
        DocFormsGet200ResponseFieldsItemTextActionsValidateRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemTextActionsValidateRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemTextActionsValidateRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemTextActionsValidateRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemTextActionsValidateRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemTextActionsValidateRootType>
    {
        public override DocFormsGet200ResponseFieldsItemTextActionsValidateRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemTextActionsValidateRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextActionsValidateRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemTextActionsValidateRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemTextActionsValidateRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemTextActionsValidateRootType value,
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
