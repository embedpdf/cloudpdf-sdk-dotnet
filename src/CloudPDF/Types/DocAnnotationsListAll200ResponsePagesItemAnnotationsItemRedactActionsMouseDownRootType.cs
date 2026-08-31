using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType(
        string value
    )
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType(
            value
        );
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootTypeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedactActionsMouseDownRootType value,
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
