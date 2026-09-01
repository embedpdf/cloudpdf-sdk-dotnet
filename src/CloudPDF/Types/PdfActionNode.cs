// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfActionNode.JsonConverter))]
[Serializable]
public record PdfActionNode
{
    internal PdfActionNode(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Javascript"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Javascript value)
    {
        Type = "javascript";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Goto"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Goto value)
    {
        Type = "goto";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Uri"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Uri value)
    {
        Type = "uri";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Named"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Named value)
    {
        Type = "named";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Hide"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Hide value)
    {
        Type = "hide";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.ResetForm"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.ResetForm value)
    {
        Type = "reset-form";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.GotoRemote"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.GotoRemote value)
    {
        Type = "goto-remote";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.GotoEmbedded"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.GotoEmbedded value)
    {
        Type = "goto-embedded";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Launch"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Launch value)
    {
        Type = "launch";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Rendition"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Rendition value)
    {
        Type = "rendition";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.SubmitForm"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.SubmitForm value)
    {
        Type = "submit-form";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Thread"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Thread value)
    {
        Type = "thread";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Sound"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Sound value)
    {
        Type = "sound";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Movie"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Movie value)
    {
        Type = "movie";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.ImportData"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.ImportData value)
    {
        Type = "import-data";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.SetOcgState"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.SetOcgState value)
    {
        Type = "set-ocg-state";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Transition"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Transition value)
    {
        Type = "transition";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Goto3DView"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Goto3DView value)
    {
        Type = "goto-3d-view";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PdfActionNode with <see cref="PdfActionNode.Unknown"/>.
    /// </summary>
    public PdfActionNode(PdfActionNode.Unknown value)
    {
        Type = "unknown";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "javascript"
    /// </summary>
    public bool IsJavascript => Type == "javascript";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "goto"
    /// </summary>
    public bool IsGoto => Type == "goto";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "uri"
    /// </summary>
    public bool IsUri => Type == "uri";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "named"
    /// </summary>
    public bool IsNamed => Type == "named";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "hide"
    /// </summary>
    public bool IsHide => Type == "hide";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "reset-form"
    /// </summary>
    public bool IsResetForm => Type == "reset-form";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "goto-remote"
    /// </summary>
    public bool IsGotoRemote => Type == "goto-remote";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "goto-embedded"
    /// </summary>
    public bool IsGotoEmbedded => Type == "goto-embedded";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "launch"
    /// </summary>
    public bool IsLaunch => Type == "launch";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "rendition"
    /// </summary>
    public bool IsRendition => Type == "rendition";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "submit-form"
    /// </summary>
    public bool IsSubmitForm => Type == "submit-form";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "thread"
    /// </summary>
    public bool IsThread => Type == "thread";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "sound"
    /// </summary>
    public bool IsSound => Type == "sound";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "movie"
    /// </summary>
    public bool IsMovie => Type == "movie";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "import-data"
    /// </summary>
    public bool IsImportData => Type == "import-data";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "set-ocg-state"
    /// </summary>
    public bool IsSetOcgState => Type == "set-ocg-state";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "transition"
    /// </summary>
    public bool IsTransition => Type == "transition";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "goto-3d-view"
    /// </summary>
    public bool IsGoto3DView => Type == "goto-3d-view";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "unknown"
    /// </summary>
    public bool IsUnknown => Type == "unknown";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeJavascript"/> if <see cref="Type"/> is 'javascript', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'javascript'.</exception>
    public CloudPDF.PdfActionNodeJavascript AsJavascript() =>
        IsJavascript
            ? (CloudPDF.PdfActionNodeJavascript)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'javascript'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeGoto"/> if <see cref="Type"/> is 'goto', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'goto'.</exception>
    public CloudPDF.PdfActionNodeGoto AsGoto() =>
        IsGoto
            ? (CloudPDF.PdfActionNodeGoto)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'goto'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeUri"/> if <see cref="Type"/> is 'uri', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'uri'.</exception>
    public CloudPDF.PdfActionNodeUri AsUri() =>
        IsUri
            ? (CloudPDF.PdfActionNodeUri)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'uri'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeNamed"/> if <see cref="Type"/> is 'named', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'named'.</exception>
    public CloudPDF.PdfActionNodeNamed AsNamed() =>
        IsNamed
            ? (CloudPDF.PdfActionNodeNamed)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'named'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeHide"/> if <see cref="Type"/> is 'hide', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'hide'.</exception>
    public CloudPDF.PdfActionNodeHide AsHide() =>
        IsHide
            ? (CloudPDF.PdfActionNodeHide)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'hide'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeResetForm"/> if <see cref="Type"/> is 'reset-form', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'reset-form'.</exception>
    public CloudPDF.PdfActionNodeResetForm AsResetForm() =>
        IsResetForm
            ? (CloudPDF.PdfActionNodeResetForm)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'reset-form'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeGotoRemote"/> if <see cref="Type"/> is 'goto-remote', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'goto-remote'.</exception>
    public CloudPDF.PdfActionNodeGotoRemote AsGotoRemote() =>
        IsGotoRemote
            ? (CloudPDF.PdfActionNodeGotoRemote)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'goto-remote'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeGotoEmbedded"/> if <see cref="Type"/> is 'goto-embedded', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'goto-embedded'.</exception>
    public CloudPDF.PdfActionNodeGotoEmbedded AsGotoEmbedded() =>
        IsGotoEmbedded
            ? (CloudPDF.PdfActionNodeGotoEmbedded)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'goto-embedded'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeLaunch"/> if <see cref="Type"/> is 'launch', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'launch'.</exception>
    public CloudPDF.PdfActionNodeLaunch AsLaunch() =>
        IsLaunch
            ? (CloudPDF.PdfActionNodeLaunch)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'launch'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeRendition"/> if <see cref="Type"/> is 'rendition', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'rendition'.</exception>
    public CloudPDF.PdfActionNodeRendition AsRendition() =>
        IsRendition
            ? (CloudPDF.PdfActionNodeRendition)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'rendition'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeSubmitForm"/> if <see cref="Type"/> is 'submit-form', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'submit-form'.</exception>
    public CloudPDF.PdfActionNodeSubmitForm AsSubmitForm() =>
        IsSubmitForm
            ? (CloudPDF.PdfActionNodeSubmitForm)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'submit-form'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeThread"/> if <see cref="Type"/> is 'thread', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'thread'.</exception>
    public CloudPDF.PdfActionNodeThread AsThread() =>
        IsThread
            ? (CloudPDF.PdfActionNodeThread)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'thread'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeSound"/> if <see cref="Type"/> is 'sound', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'sound'.</exception>
    public CloudPDF.PdfActionNodeSound AsSound() =>
        IsSound
            ? (CloudPDF.PdfActionNodeSound)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'sound'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeMovie"/> if <see cref="Type"/> is 'movie', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'movie'.</exception>
    public CloudPDF.PdfActionNodeMovie AsMovie() =>
        IsMovie
            ? (CloudPDF.PdfActionNodeMovie)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'movie'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeImportData"/> if <see cref="Type"/> is 'import-data', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'import-data'.</exception>
    public CloudPDF.PdfActionNodeImportData AsImportData() =>
        IsImportData
            ? (CloudPDF.PdfActionNodeImportData)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'import-data'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeSetOcgState"/> if <see cref="Type"/> is 'set-ocg-state', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'set-ocg-state'.</exception>
    public CloudPDF.PdfActionNodeSetOcgState AsSetOcgState() =>
        IsSetOcgState
            ? (CloudPDF.PdfActionNodeSetOcgState)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'set-ocg-state'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeTransition"/> if <see cref="Type"/> is 'transition', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'transition'.</exception>
    public CloudPDF.PdfActionNodeTransition AsTransition() =>
        IsTransition
            ? (CloudPDF.PdfActionNodeTransition)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'transition'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeGoto3DView"/> if <see cref="Type"/> is 'goto-3d-view', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'goto-3d-view'.</exception>
    public CloudPDF.PdfActionNodeGoto3DView AsGoto3DView() =>
        IsGoto3DView
            ? (CloudPDF.PdfActionNodeGoto3DView)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'goto-3d-view'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.PdfActionNodeUnknown"/> if <see cref="Type"/> is 'unknown', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'unknown'.</exception>
    public CloudPDF.PdfActionNodeUnknown AsUnknown() =>
        IsUnknown
            ? (CloudPDF.PdfActionNodeUnknown)Value!
            : throw new global::System.Exception("PdfActionNode.Type is not 'unknown'");

    public T Match<T>(
        Func<CloudPDF.PdfActionNodeJavascript, T> onJavascript,
        Func<CloudPDF.PdfActionNodeGoto, T> onGoto,
        Func<CloudPDF.PdfActionNodeUri, T> onUri,
        Func<CloudPDF.PdfActionNodeNamed, T> onNamed,
        Func<CloudPDF.PdfActionNodeHide, T> onHide,
        Func<CloudPDF.PdfActionNodeResetForm, T> onResetForm,
        Func<CloudPDF.PdfActionNodeGotoRemote, T> onGotoRemote,
        Func<CloudPDF.PdfActionNodeGotoEmbedded, T> onGotoEmbedded,
        Func<CloudPDF.PdfActionNodeLaunch, T> onLaunch,
        Func<CloudPDF.PdfActionNodeRendition, T> onRendition,
        Func<CloudPDF.PdfActionNodeSubmitForm, T> onSubmitForm,
        Func<CloudPDF.PdfActionNodeThread, T> onThread,
        Func<CloudPDF.PdfActionNodeSound, T> onSound,
        Func<CloudPDF.PdfActionNodeMovie, T> onMovie,
        Func<CloudPDF.PdfActionNodeImportData, T> onImportData,
        Func<CloudPDF.PdfActionNodeSetOcgState, T> onSetOcgState,
        Func<CloudPDF.PdfActionNodeTransition, T> onTransition,
        Func<CloudPDF.PdfActionNodeGoto3DView, T> onGoto3DView,
        Func<CloudPDF.PdfActionNodeUnknown, T> onUnknown,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "javascript" => onJavascript(AsJavascript()),
            "goto" => onGoto(AsGoto()),
            "uri" => onUri(AsUri()),
            "named" => onNamed(AsNamed()),
            "hide" => onHide(AsHide()),
            "reset-form" => onResetForm(AsResetForm()),
            "goto-remote" => onGotoRemote(AsGotoRemote()),
            "goto-embedded" => onGotoEmbedded(AsGotoEmbedded()),
            "launch" => onLaunch(AsLaunch()),
            "rendition" => onRendition(AsRendition()),
            "submit-form" => onSubmitForm(AsSubmitForm()),
            "thread" => onThread(AsThread()),
            "sound" => onSound(AsSound()),
            "movie" => onMovie(AsMovie()),
            "import-data" => onImportData(AsImportData()),
            "set-ocg-state" => onSetOcgState(AsSetOcgState()),
            "transition" => onTransition(AsTransition()),
            "goto-3d-view" => onGoto3DView(AsGoto3DView()),
            "unknown" => onUnknown(AsUnknown()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.PdfActionNodeJavascript> onJavascript,
        Action<CloudPDF.PdfActionNodeGoto> onGoto,
        Action<CloudPDF.PdfActionNodeUri> onUri,
        Action<CloudPDF.PdfActionNodeNamed> onNamed,
        Action<CloudPDF.PdfActionNodeHide> onHide,
        Action<CloudPDF.PdfActionNodeResetForm> onResetForm,
        Action<CloudPDF.PdfActionNodeGotoRemote> onGotoRemote,
        Action<CloudPDF.PdfActionNodeGotoEmbedded> onGotoEmbedded,
        Action<CloudPDF.PdfActionNodeLaunch> onLaunch,
        Action<CloudPDF.PdfActionNodeRendition> onRendition,
        Action<CloudPDF.PdfActionNodeSubmitForm> onSubmitForm,
        Action<CloudPDF.PdfActionNodeThread> onThread,
        Action<CloudPDF.PdfActionNodeSound> onSound,
        Action<CloudPDF.PdfActionNodeMovie> onMovie,
        Action<CloudPDF.PdfActionNodeImportData> onImportData,
        Action<CloudPDF.PdfActionNodeSetOcgState> onSetOcgState,
        Action<CloudPDF.PdfActionNodeTransition> onTransition,
        Action<CloudPDF.PdfActionNodeGoto3DView> onGoto3DView,
        Action<CloudPDF.PdfActionNodeUnknown> onUnknown,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "javascript":
                onJavascript(AsJavascript());
                break;
            case "goto":
                onGoto(AsGoto());
                break;
            case "uri":
                onUri(AsUri());
                break;
            case "named":
                onNamed(AsNamed());
                break;
            case "hide":
                onHide(AsHide());
                break;
            case "reset-form":
                onResetForm(AsResetForm());
                break;
            case "goto-remote":
                onGotoRemote(AsGotoRemote());
                break;
            case "goto-embedded":
                onGotoEmbedded(AsGotoEmbedded());
                break;
            case "launch":
                onLaunch(AsLaunch());
                break;
            case "rendition":
                onRendition(AsRendition());
                break;
            case "submit-form":
                onSubmitForm(AsSubmitForm());
                break;
            case "thread":
                onThread(AsThread());
                break;
            case "sound":
                onSound(AsSound());
                break;
            case "movie":
                onMovie(AsMovie());
                break;
            case "import-data":
                onImportData(AsImportData());
                break;
            case "set-ocg-state":
                onSetOcgState(AsSetOcgState());
                break;
            case "transition":
                onTransition(AsTransition());
                break;
            case "goto-3d-view":
                onGoto3DView(AsGoto3DView());
                break;
            case "unknown":
                onUnknown(AsUnknown());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeJavascript"/> and returns true if successful.
    /// </summary>
    public bool TryAsJavascript(out CloudPDF.PdfActionNodeJavascript? value)
    {
        if (Type == "javascript")
        {
            value = (CloudPDF.PdfActionNodeJavascript)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeGoto"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto(out CloudPDF.PdfActionNodeGoto? value)
    {
        if (Type == "goto")
        {
            value = (CloudPDF.PdfActionNodeGoto)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeUri"/> and returns true if successful.
    /// </summary>
    public bool TryAsUri(out CloudPDF.PdfActionNodeUri? value)
    {
        if (Type == "uri")
        {
            value = (CloudPDF.PdfActionNodeUri)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeNamed"/> and returns true if successful.
    /// </summary>
    public bool TryAsNamed(out CloudPDF.PdfActionNodeNamed? value)
    {
        if (Type == "named")
        {
            value = (CloudPDF.PdfActionNodeNamed)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeHide"/> and returns true if successful.
    /// </summary>
    public bool TryAsHide(out CloudPDF.PdfActionNodeHide? value)
    {
        if (Type == "hide")
        {
            value = (CloudPDF.PdfActionNodeHide)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeResetForm"/> and returns true if successful.
    /// </summary>
    public bool TryAsResetForm(out CloudPDF.PdfActionNodeResetForm? value)
    {
        if (Type == "reset-form")
        {
            value = (CloudPDF.PdfActionNodeResetForm)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeGotoRemote"/> and returns true if successful.
    /// </summary>
    public bool TryAsGotoRemote(out CloudPDF.PdfActionNodeGotoRemote? value)
    {
        if (Type == "goto-remote")
        {
            value = (CloudPDF.PdfActionNodeGotoRemote)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeGotoEmbedded"/> and returns true if successful.
    /// </summary>
    public bool TryAsGotoEmbedded(out CloudPDF.PdfActionNodeGotoEmbedded? value)
    {
        if (Type == "goto-embedded")
        {
            value = (CloudPDF.PdfActionNodeGotoEmbedded)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeLaunch"/> and returns true if successful.
    /// </summary>
    public bool TryAsLaunch(out CloudPDF.PdfActionNodeLaunch? value)
    {
        if (Type == "launch")
        {
            value = (CloudPDF.PdfActionNodeLaunch)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeRendition"/> and returns true if successful.
    /// </summary>
    public bool TryAsRendition(out CloudPDF.PdfActionNodeRendition? value)
    {
        if (Type == "rendition")
        {
            value = (CloudPDF.PdfActionNodeRendition)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeSubmitForm"/> and returns true if successful.
    /// </summary>
    public bool TryAsSubmitForm(out CloudPDF.PdfActionNodeSubmitForm? value)
    {
        if (Type == "submit-form")
        {
            value = (CloudPDF.PdfActionNodeSubmitForm)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeThread"/> and returns true if successful.
    /// </summary>
    public bool TryAsThread(out CloudPDF.PdfActionNodeThread? value)
    {
        if (Type == "thread")
        {
            value = (CloudPDF.PdfActionNodeThread)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeSound"/> and returns true if successful.
    /// </summary>
    public bool TryAsSound(out CloudPDF.PdfActionNodeSound? value)
    {
        if (Type == "sound")
        {
            value = (CloudPDF.PdfActionNodeSound)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeMovie"/> and returns true if successful.
    /// </summary>
    public bool TryAsMovie(out CloudPDF.PdfActionNodeMovie? value)
    {
        if (Type == "movie")
        {
            value = (CloudPDF.PdfActionNodeMovie)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeImportData"/> and returns true if successful.
    /// </summary>
    public bool TryAsImportData(out CloudPDF.PdfActionNodeImportData? value)
    {
        if (Type == "import-data")
        {
            value = (CloudPDF.PdfActionNodeImportData)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeSetOcgState"/> and returns true if successful.
    /// </summary>
    public bool TryAsSetOcgState(out CloudPDF.PdfActionNodeSetOcgState? value)
    {
        if (Type == "set-ocg-state")
        {
            value = (CloudPDF.PdfActionNodeSetOcgState)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeTransition"/> and returns true if successful.
    /// </summary>
    public bool TryAsTransition(out CloudPDF.PdfActionNodeTransition? value)
    {
        if (Type == "transition")
        {
            value = (CloudPDF.PdfActionNodeTransition)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeGoto3DView"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoto3DView(out CloudPDF.PdfActionNodeGoto3DView? value)
    {
        if (Type == "goto-3d-view")
        {
            value = (CloudPDF.PdfActionNodeGoto3DView)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.PdfActionNodeUnknown"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknown(out CloudPDF.PdfActionNodeUnknown? value)
    {
        if (Type == "unknown")
        {
            value = (CloudPDF.PdfActionNodeUnknown)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PdfActionNode(PdfActionNode.Javascript value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Goto value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Uri value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Named value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Hide value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.ResetForm value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.GotoRemote value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.GotoEmbedded value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Launch value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Rendition value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.SubmitForm value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Thread value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Sound value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Movie value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.ImportData value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.SetOcgState value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Transition value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Goto3DView value) => new(value);

    public static implicit operator PdfActionNode(PdfActionNode.Unknown value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PdfActionNode>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PdfActionNode).IsAssignableFrom(typeToConvert);

        public override PdfActionNode Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "javascript" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeJavascript?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeJavascript"
                        ),
                "goto" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeGoto?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeGoto"),
                "uri" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeUri?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeUri"),
                "named" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeNamed?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeNamed"),
                "hide" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeHide?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeHide"),
                "reset-form" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeResetForm?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeResetForm"
                        ),
                "goto-remote" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeGotoRemote?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeGotoRemote"
                        ),
                "goto-embedded" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeGotoEmbedded?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeGotoEmbedded"
                        ),
                "launch" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeLaunch?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeLaunch"),
                "rendition" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeRendition?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeRendition"
                        ),
                "submit-form" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeSubmitForm?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeSubmitForm"
                        ),
                "thread" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeThread?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeThread"),
                "sound" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeSound?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeSound"),
                "movie" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeMovie?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeMovie"),
                "import-data" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeImportData?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeImportData"
                        ),
                "set-ocg-state" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeSetOcgState?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeSetOcgState"
                        ),
                "transition" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeTransition?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeTransition"
                        ),
                "goto-3d-view" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeGoto3DView?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.PdfActionNodeGoto3DView"
                        ),
                "unknown" => jsonWithoutDiscriminator.Deserialize<CloudPDF.PdfActionNodeUnknown?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.PdfActionNodeUnknown"),
                _ => json.Deserialize<object?>(options),
            };
            return new PdfActionNode(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionNode value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "javascript" => JsonSerializer.SerializeToNode(value.Value, options),
                    "goto" => JsonSerializer.SerializeToNode(value.Value, options),
                    "uri" => JsonSerializer.SerializeToNode(value.Value, options),
                    "named" => JsonSerializer.SerializeToNode(value.Value, options),
                    "hide" => JsonSerializer.SerializeToNode(value.Value, options),
                    "reset-form" => JsonSerializer.SerializeToNode(value.Value, options),
                    "goto-remote" => JsonSerializer.SerializeToNode(value.Value, options),
                    "goto-embedded" => JsonSerializer.SerializeToNode(value.Value, options),
                    "launch" => JsonSerializer.SerializeToNode(value.Value, options),
                    "rendition" => JsonSerializer.SerializeToNode(value.Value, options),
                    "submit-form" => JsonSerializer.SerializeToNode(value.Value, options),
                    "thread" => JsonSerializer.SerializeToNode(value.Value, options),
                    "sound" => JsonSerializer.SerializeToNode(value.Value, options),
                    "movie" => JsonSerializer.SerializeToNode(value.Value, options),
                    "import-data" => JsonSerializer.SerializeToNode(value.Value, options),
                    "set-ocg-state" => JsonSerializer.SerializeToNode(value.Value, options),
                    "transition" => JsonSerializer.SerializeToNode(value.Value, options),
                    "goto-3d-view" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unknown" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override PdfActionNode ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PdfActionNode(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionNode value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for javascript
    /// </summary>
    [Serializable]
    public struct Javascript
    {
        public Javascript(CloudPDF.PdfActionNodeJavascript value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeJavascript Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Javascript(
            CloudPDF.PdfActionNodeJavascript value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto
    /// </summary>
    [Serializable]
    public struct Goto
    {
        public Goto(CloudPDF.PdfActionNodeGoto value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeGoto Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Goto(CloudPDF.PdfActionNodeGoto value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for uri
    /// </summary>
    [Serializable]
    public struct Uri
    {
        public Uri(CloudPDF.PdfActionNodeUri value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeUri Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Uri(CloudPDF.PdfActionNodeUri value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for named
    /// </summary>
    [Serializable]
    public struct Named
    {
        public Named(CloudPDF.PdfActionNodeNamed value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeNamed Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Named(CloudPDF.PdfActionNodeNamed value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for hide
    /// </summary>
    [Serializable]
    public struct Hide
    {
        public Hide(CloudPDF.PdfActionNodeHide value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeHide Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Hide(CloudPDF.PdfActionNodeHide value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for reset-form
    /// </summary>
    [Serializable]
    public struct ResetForm
    {
        public ResetForm(CloudPDF.PdfActionNodeResetForm value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeResetForm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.ResetForm(
            CloudPDF.PdfActionNodeResetForm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto-remote
    /// </summary>
    [Serializable]
    public struct GotoRemote
    {
        public GotoRemote(CloudPDF.PdfActionNodeGotoRemote value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeGotoRemote Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.GotoRemote(
            CloudPDF.PdfActionNodeGotoRemote value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto-embedded
    /// </summary>
    [Serializable]
    public struct GotoEmbedded
    {
        public GotoEmbedded(CloudPDF.PdfActionNodeGotoEmbedded value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeGotoEmbedded Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.GotoEmbedded(
            CloudPDF.PdfActionNodeGotoEmbedded value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for launch
    /// </summary>
    [Serializable]
    public struct Launch
    {
        public Launch(CloudPDF.PdfActionNodeLaunch value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeLaunch Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Launch(CloudPDF.PdfActionNodeLaunch value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for rendition
    /// </summary>
    [Serializable]
    public struct Rendition
    {
        public Rendition(CloudPDF.PdfActionNodeRendition value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeRendition Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Rendition(
            CloudPDF.PdfActionNodeRendition value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for submit-form
    /// </summary>
    [Serializable]
    public struct SubmitForm
    {
        public SubmitForm(CloudPDF.PdfActionNodeSubmitForm value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeSubmitForm Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.SubmitForm(
            CloudPDF.PdfActionNodeSubmitForm value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for thread
    /// </summary>
    [Serializable]
    public struct Thread
    {
        public Thread(CloudPDF.PdfActionNodeThread value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeThread Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Thread(CloudPDF.PdfActionNodeThread value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for sound
    /// </summary>
    [Serializable]
    public struct Sound
    {
        public Sound(CloudPDF.PdfActionNodeSound value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeSound Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Sound(CloudPDF.PdfActionNodeSound value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for movie
    /// </summary>
    [Serializable]
    public struct Movie
    {
        public Movie(CloudPDF.PdfActionNodeMovie value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeMovie Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Movie(CloudPDF.PdfActionNodeMovie value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for import-data
    /// </summary>
    [Serializable]
    public struct ImportData
    {
        public ImportData(CloudPDF.PdfActionNodeImportData value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeImportData Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.ImportData(
            CloudPDF.PdfActionNodeImportData value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for set-ocg-state
    /// </summary>
    [Serializable]
    public struct SetOcgState
    {
        public SetOcgState(CloudPDF.PdfActionNodeSetOcgState value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeSetOcgState Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.SetOcgState(
            CloudPDF.PdfActionNodeSetOcgState value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for transition
    /// </summary>
    [Serializable]
    public struct Transition
    {
        public Transition(CloudPDF.PdfActionNodeTransition value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeTransition Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Transition(
            CloudPDF.PdfActionNodeTransition value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for goto-3d-view
    /// </summary>
    [Serializable]
    public struct Goto3DView
    {
        public Goto3DView(CloudPDF.PdfActionNodeGoto3DView value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeGoto3DView Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Goto3DView(
            CloudPDF.PdfActionNodeGoto3DView value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown
    /// </summary>
    [Serializable]
    public struct Unknown
    {
        public Unknown(CloudPDF.PdfActionNodeUnknown value)
        {
            Value = value;
        }

        internal CloudPDF.PdfActionNodeUnknown Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PdfActionNode.Unknown(
            CloudPDF.PdfActionNodeUnknown value
        ) => new(value);
    }
}
