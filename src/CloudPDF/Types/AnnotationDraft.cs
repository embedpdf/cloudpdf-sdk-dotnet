// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraft.JsonConverter))]
[Serializable]
public record AnnotationDraft
{
    internal AnnotationDraft(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Highlight"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Highlight value)
    {
        Subtype = "highlight";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Underline"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Underline value)
    {
        Subtype = "underline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Squiggly"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Squiggly value)
    {
        Subtype = "squiggly";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Strikeout"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Strikeout value)
    {
        Subtype = "strikeout";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Circle"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Circle value)
    {
        Subtype = "circle";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Square"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Square value)
    {
        Subtype = "square";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Polygon"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Polygon value)
    {
        Subtype = "polygon";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Polyline"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Polyline value)
    {
        Subtype = "polyline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Line"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Line value)
    {
        Subtype = "line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Link"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Link value)
    {
        Subtype = "link";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Ink"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Ink value)
    {
        Subtype = "ink";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.FreeText"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.FreeText value)
    {
        Subtype = "free-text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Caret"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Caret value)
    {
        Subtype = "caret";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Text"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Text value)
    {
        Subtype = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Stamp"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Stamp value)
    {
        Subtype = "stamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.FileAttachment"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.FileAttachment value)
    {
        Subtype = "file-attachment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Widget"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Widget value)
    {
        Subtype = "widget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Redact"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Redact value)
    {
        Subtype = "redact";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationDraft with <see cref="AnnotationDraft.Popup"/>.
    /// </summary>
    public AnnotationDraft(AnnotationDraft.Popup value)
    {
        Subtype = "popup";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("subtype")]
    public string Subtype { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "highlight"
    /// </summary>
    public bool IsHighlight => Subtype == "highlight";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "underline"
    /// </summary>
    public bool IsUnderline => Subtype == "underline";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "squiggly"
    /// </summary>
    public bool IsSquiggly => Subtype == "squiggly";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "strikeout"
    /// </summary>
    public bool IsStrikeout => Subtype == "strikeout";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "circle"
    /// </summary>
    public bool IsCircle => Subtype == "circle";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "square"
    /// </summary>
    public bool IsSquare => Subtype == "square";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "polygon"
    /// </summary>
    public bool IsPolygon => Subtype == "polygon";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "polyline"
    /// </summary>
    public bool IsPolyline => Subtype == "polyline";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "line"
    /// </summary>
    public bool IsLine => Subtype == "line";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "link"
    /// </summary>
    public bool IsLink => Subtype == "link";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "ink"
    /// </summary>
    public bool IsInk => Subtype == "ink";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "free-text"
    /// </summary>
    public bool IsFreeText => Subtype == "free-text";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "caret"
    /// </summary>
    public bool IsCaret => Subtype == "caret";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "text"
    /// </summary>
    public bool IsText => Subtype == "text";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "stamp"
    /// </summary>
    public bool IsStamp => Subtype == "stamp";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "file-attachment"
    /// </summary>
    public bool IsFileAttachment => Subtype == "file-attachment";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "widget"
    /// </summary>
    public bool IsWidget => Subtype == "widget";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "redact"
    /// </summary>
    public bool IsRedact => Subtype == "redact";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "popup"
    /// </summary>
    public bool IsPopup => Subtype == "popup";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftHighlight"/> if <see cref="Subtype"/> is 'highlight', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'highlight'.</exception>
    public CloudPDF.AnnotationDraftHighlight AsHighlight() =>
        IsHighlight
            ? (CloudPDF.AnnotationDraftHighlight)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'highlight'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftUnderline"/> if <see cref="Subtype"/> is 'underline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'underline'.</exception>
    public CloudPDF.AnnotationDraftUnderline AsUnderline() =>
        IsUnderline
            ? (CloudPDF.AnnotationDraftUnderline)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'underline'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftSquiggly"/> if <see cref="Subtype"/> is 'squiggly', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'squiggly'.</exception>
    public CloudPDF.AnnotationDraftSquiggly AsSquiggly() =>
        IsSquiggly
            ? (CloudPDF.AnnotationDraftSquiggly)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'squiggly'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftStrikeout"/> if <see cref="Subtype"/> is 'strikeout', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'strikeout'.</exception>
    public CloudPDF.AnnotationDraftStrikeout AsStrikeout() =>
        IsStrikeout
            ? (CloudPDF.AnnotationDraftStrikeout)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'strikeout'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftCircle"/> if <see cref="Subtype"/> is 'circle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'circle'.</exception>
    public CloudPDF.AnnotationDraftCircle AsCircle() =>
        IsCircle
            ? (CloudPDF.AnnotationDraftCircle)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'circle'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftSquare"/> if <see cref="Subtype"/> is 'square', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'square'.</exception>
    public CloudPDF.AnnotationDraftSquare AsSquare() =>
        IsSquare
            ? (CloudPDF.AnnotationDraftSquare)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'square'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPolygon"/> if <see cref="Subtype"/> is 'polygon', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polygon'.</exception>
    public CloudPDF.AnnotationDraftPolygon AsPolygon() =>
        IsPolygon
            ? (CloudPDF.AnnotationDraftPolygon)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'polygon'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPolyline"/> if <see cref="Subtype"/> is 'polyline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polyline'.</exception>
    public CloudPDF.AnnotationDraftPolyline AsPolyline() =>
        IsPolyline
            ? (CloudPDF.AnnotationDraftPolyline)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'polyline'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftLine"/> if <see cref="Subtype"/> is 'line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'line'.</exception>
    public CloudPDF.AnnotationDraftLine AsLine() =>
        IsLine
            ? (CloudPDF.AnnotationDraftLine)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'line'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftLink"/> if <see cref="Subtype"/> is 'link', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'link'.</exception>
    public CloudPDF.AnnotationDraftLink AsLink() =>
        IsLink
            ? (CloudPDF.AnnotationDraftLink)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'link'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftInk"/> if <see cref="Subtype"/> is 'ink', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'ink'.</exception>
    public CloudPDF.AnnotationDraftInk AsInk() =>
        IsInk
            ? (CloudPDF.AnnotationDraftInk)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'ink'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftFreeText"/> if <see cref="Subtype"/> is 'free-text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'free-text'.</exception>
    public CloudPDF.AnnotationDraftFreeText AsFreeText() =>
        IsFreeText
            ? (CloudPDF.AnnotationDraftFreeText)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'free-text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftCaret"/> if <see cref="Subtype"/> is 'caret', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'caret'.</exception>
    public CloudPDF.AnnotationDraftCaret AsCaret() =>
        IsCaret
            ? (CloudPDF.AnnotationDraftCaret)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'caret'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftText"/> if <see cref="Subtype"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'text'.</exception>
    public CloudPDF.AnnotationDraftText AsText() =>
        IsText
            ? (CloudPDF.AnnotationDraftText)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftStamp"/> if <see cref="Subtype"/> is 'stamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'stamp'.</exception>
    public CloudPDF.AnnotationDraftStamp AsStamp() =>
        IsStamp
            ? (CloudPDF.AnnotationDraftStamp)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'stamp'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftFileAttachment"/> if <see cref="Subtype"/> is 'file-attachment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'file-attachment'.</exception>
    public CloudPDF.AnnotationDraftFileAttachment AsFileAttachment() =>
        IsFileAttachment
            ? (CloudPDF.AnnotationDraftFileAttachment)Value!
            : throw new global::System.Exception(
                "AnnotationDraft.Subtype is not 'file-attachment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftWidget"/> if <see cref="Subtype"/> is 'widget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'widget'.</exception>
    public CloudPDF.AnnotationDraftWidget AsWidget() =>
        IsWidget
            ? (CloudPDF.AnnotationDraftWidget)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'widget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftRedact"/> if <see cref="Subtype"/> is 'redact', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'redact'.</exception>
    public CloudPDF.AnnotationDraftRedact AsRedact() =>
        IsRedact
            ? (CloudPDF.AnnotationDraftRedact)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'redact'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationDraftPopup"/> if <see cref="Subtype"/> is 'popup', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'popup'.</exception>
    public CloudPDF.AnnotationDraftPopup AsPopup() =>
        IsPopup
            ? (CloudPDF.AnnotationDraftPopup)Value!
            : throw new global::System.Exception("AnnotationDraft.Subtype is not 'popup'");

    public T Match<T>(
        Func<CloudPDF.AnnotationDraftHighlight, T> onHighlight,
        Func<CloudPDF.AnnotationDraftUnderline, T> onUnderline,
        Func<CloudPDF.AnnotationDraftSquiggly, T> onSquiggly,
        Func<CloudPDF.AnnotationDraftStrikeout, T> onStrikeout,
        Func<CloudPDF.AnnotationDraftCircle, T> onCircle,
        Func<CloudPDF.AnnotationDraftSquare, T> onSquare,
        Func<CloudPDF.AnnotationDraftPolygon, T> onPolygon,
        Func<CloudPDF.AnnotationDraftPolyline, T> onPolyline,
        Func<CloudPDF.AnnotationDraftLine, T> onLine,
        Func<CloudPDF.AnnotationDraftLink, T> onLink,
        Func<CloudPDF.AnnotationDraftInk, T> onInk,
        Func<CloudPDF.AnnotationDraftFreeText, T> onFreeText,
        Func<CloudPDF.AnnotationDraftCaret, T> onCaret,
        Func<CloudPDF.AnnotationDraftText, T> onText,
        Func<CloudPDF.AnnotationDraftStamp, T> onStamp,
        Func<CloudPDF.AnnotationDraftFileAttachment, T> onFileAttachment,
        Func<CloudPDF.AnnotationDraftWidget, T> onWidget,
        Func<CloudPDF.AnnotationDraftRedact, T> onRedact,
        Func<CloudPDF.AnnotationDraftPopup, T> onPopup,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "highlight" => onHighlight(AsHighlight()),
            "underline" => onUnderline(AsUnderline()),
            "squiggly" => onSquiggly(AsSquiggly()),
            "strikeout" => onStrikeout(AsStrikeout()),
            "circle" => onCircle(AsCircle()),
            "square" => onSquare(AsSquare()),
            "polygon" => onPolygon(AsPolygon()),
            "polyline" => onPolyline(AsPolyline()),
            "line" => onLine(AsLine()),
            "link" => onLink(AsLink()),
            "ink" => onInk(AsInk()),
            "free-text" => onFreeText(AsFreeText()),
            "caret" => onCaret(AsCaret()),
            "text" => onText(AsText()),
            "stamp" => onStamp(AsStamp()),
            "file-attachment" => onFileAttachment(AsFileAttachment()),
            "widget" => onWidget(AsWidget()),
            "redact" => onRedact(AsRedact()),
            "popup" => onPopup(AsPopup()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.AnnotationDraftHighlight> onHighlight,
        Action<CloudPDF.AnnotationDraftUnderline> onUnderline,
        Action<CloudPDF.AnnotationDraftSquiggly> onSquiggly,
        Action<CloudPDF.AnnotationDraftStrikeout> onStrikeout,
        Action<CloudPDF.AnnotationDraftCircle> onCircle,
        Action<CloudPDF.AnnotationDraftSquare> onSquare,
        Action<CloudPDF.AnnotationDraftPolygon> onPolygon,
        Action<CloudPDF.AnnotationDraftPolyline> onPolyline,
        Action<CloudPDF.AnnotationDraftLine> onLine,
        Action<CloudPDF.AnnotationDraftLink> onLink,
        Action<CloudPDF.AnnotationDraftInk> onInk,
        Action<CloudPDF.AnnotationDraftFreeText> onFreeText,
        Action<CloudPDF.AnnotationDraftCaret> onCaret,
        Action<CloudPDF.AnnotationDraftText> onText,
        Action<CloudPDF.AnnotationDraftStamp> onStamp,
        Action<CloudPDF.AnnotationDraftFileAttachment> onFileAttachment,
        Action<CloudPDF.AnnotationDraftWidget> onWidget,
        Action<CloudPDF.AnnotationDraftRedact> onRedact,
        Action<CloudPDF.AnnotationDraftPopup> onPopup,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
            case "highlight":
                onHighlight(AsHighlight());
                break;
            case "underline":
                onUnderline(AsUnderline());
                break;
            case "squiggly":
                onSquiggly(AsSquiggly());
                break;
            case "strikeout":
                onStrikeout(AsStrikeout());
                break;
            case "circle":
                onCircle(AsCircle());
                break;
            case "square":
                onSquare(AsSquare());
                break;
            case "polygon":
                onPolygon(AsPolygon());
                break;
            case "polyline":
                onPolyline(AsPolyline());
                break;
            case "line":
                onLine(AsLine());
                break;
            case "link":
                onLink(AsLink());
                break;
            case "ink":
                onInk(AsInk());
                break;
            case "free-text":
                onFreeText(AsFreeText());
                break;
            case "caret":
                onCaret(AsCaret());
                break;
            case "text":
                onText(AsText());
                break;
            case "stamp":
                onStamp(AsStamp());
                break;
            case "file-attachment":
                onFileAttachment(AsFileAttachment());
                break;
            case "widget":
                onWidget(AsWidget());
                break;
            case "redact":
                onRedact(AsRedact());
                break;
            case "popup":
                onPopup(AsPopup());
                break;
            default:
                onUnknown_(Subtype, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftHighlight"/> and returns true if successful.
    /// </summary>
    public bool TryAsHighlight(out CloudPDF.AnnotationDraftHighlight? value)
    {
        if (Subtype == "highlight")
        {
            value = (CloudPDF.AnnotationDraftHighlight)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftUnderline"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnderline(out CloudPDF.AnnotationDraftUnderline? value)
    {
        if (Subtype == "underline")
        {
            value = (CloudPDF.AnnotationDraftUnderline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftSquiggly"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquiggly(out CloudPDF.AnnotationDraftSquiggly? value)
    {
        if (Subtype == "squiggly")
        {
            value = (CloudPDF.AnnotationDraftSquiggly)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftStrikeout"/> and returns true if successful.
    /// </summary>
    public bool TryAsStrikeout(out CloudPDF.AnnotationDraftStrikeout? value)
    {
        if (Subtype == "strikeout")
        {
            value = (CloudPDF.AnnotationDraftStrikeout)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftCircle"/> and returns true if successful.
    /// </summary>
    public bool TryAsCircle(out CloudPDF.AnnotationDraftCircle? value)
    {
        if (Subtype == "circle")
        {
            value = (CloudPDF.AnnotationDraftCircle)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftSquare"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquare(out CloudPDF.AnnotationDraftSquare? value)
    {
        if (Subtype == "square")
        {
            value = (CloudPDF.AnnotationDraftSquare)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPolygon"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolygon(out CloudPDF.AnnotationDraftPolygon? value)
    {
        if (Subtype == "polygon")
        {
            value = (CloudPDF.AnnotationDraftPolygon)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPolyline"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolyline(out CloudPDF.AnnotationDraftPolyline? value)
    {
        if (Subtype == "polyline")
        {
            value = (CloudPDF.AnnotationDraftPolyline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftLine"/> and returns true if successful.
    /// </summary>
    public bool TryAsLine(out CloudPDF.AnnotationDraftLine? value)
    {
        if (Subtype == "line")
        {
            value = (CloudPDF.AnnotationDraftLine)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftLink"/> and returns true if successful.
    /// </summary>
    public bool TryAsLink(out CloudPDF.AnnotationDraftLink? value)
    {
        if (Subtype == "link")
        {
            value = (CloudPDF.AnnotationDraftLink)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftInk"/> and returns true if successful.
    /// </summary>
    public bool TryAsInk(out CloudPDF.AnnotationDraftInk? value)
    {
        if (Subtype == "ink")
        {
            value = (CloudPDF.AnnotationDraftInk)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftFreeText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFreeText(out CloudPDF.AnnotationDraftFreeText? value)
    {
        if (Subtype == "free-text")
        {
            value = (CloudPDF.AnnotationDraftFreeText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftCaret"/> and returns true if successful.
    /// </summary>
    public bool TryAsCaret(out CloudPDF.AnnotationDraftCaret? value)
    {
        if (Subtype == "caret")
        {
            value = (CloudPDF.AnnotationDraftCaret)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudPDF.AnnotationDraftText? value)
    {
        if (Subtype == "text")
        {
            value = (CloudPDF.AnnotationDraftText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftStamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsStamp(out CloudPDF.AnnotationDraftStamp? value)
    {
        if (Subtype == "stamp")
        {
            value = (CloudPDF.AnnotationDraftStamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftFileAttachment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFileAttachment(out CloudPDF.AnnotationDraftFileAttachment? value)
    {
        if (Subtype == "file-attachment")
        {
            value = (CloudPDF.AnnotationDraftFileAttachment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsWidget(out CloudPDF.AnnotationDraftWidget? value)
    {
        if (Subtype == "widget")
        {
            value = (CloudPDF.AnnotationDraftWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftRedact"/> and returns true if successful.
    /// </summary>
    public bool TryAsRedact(out CloudPDF.AnnotationDraftRedact? value)
    {
        if (Subtype == "redact")
        {
            value = (CloudPDF.AnnotationDraftRedact)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationDraftPopup"/> and returns true if successful.
    /// </summary>
    public bool TryAsPopup(out CloudPDF.AnnotationDraftPopup? value)
    {
        if (Subtype == "popup")
        {
            value = (CloudPDF.AnnotationDraftPopup)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationDraft(AnnotationDraft.Highlight value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Underline value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Squiggly value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Strikeout value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Circle value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Square value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Polygon value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Polyline value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Line value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Link value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Ink value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.FreeText value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Caret value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Text value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Stamp value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.FileAttachment value) =>
        new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Widget value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Redact value) => new(value);

    public static implicit operator AnnotationDraft(AnnotationDraft.Popup value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationDraft>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationDraft).IsAssignableFrom(typeToConvert);

        public override AnnotationDraft Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("subtype", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'subtype'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'subtype' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'subtype' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'subtype' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("subtype");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "highlight" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftHighlight?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftHighlight"
                        ),
                "underline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftUnderline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftUnderline"
                        ),
                "squiggly" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftSquiggly?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftSquiggly"
                        ),
                "strikeout" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftStrikeout?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftStrikeout"
                        ),
                "circle" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftCircle?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationDraftCircle"
                    ),
                "square" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftSquare?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationDraftSquare"
                    ),
                "polygon" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftPolygon?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationDraftPolygon"
                    ),
                "polyline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftPolyline?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftPolyline"
                        ),
                "line" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftLine?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftLine"),
                "link" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftLink?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftLink"),
                "ink" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftInk?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftInk"),
                "free-text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftFreeText?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftFreeText"
                        ),
                "caret" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftCaret?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftCaret"),
                "text" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftText?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftText"),
                "stamp" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftStamp?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftStamp"),
                "file-attachment" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftFileAttachment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationDraftFileAttachment"
                        ),
                "widget" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftWidget?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationDraftWidget"
                    ),
                "redact" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftRedact?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationDraftRedact"
                    ),
                "popup" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationDraftPopup?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationDraftPopup"),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationDraft(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraft value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "highlight" => JsonSerializer.SerializeToNode(value.Value, options),
                    "underline" => JsonSerializer.SerializeToNode(value.Value, options),
                    "squiggly" => JsonSerializer.SerializeToNode(value.Value, options),
                    "strikeout" => JsonSerializer.SerializeToNode(value.Value, options),
                    "circle" => JsonSerializer.SerializeToNode(value.Value, options),
                    "square" => JsonSerializer.SerializeToNode(value.Value, options),
                    "polygon" => JsonSerializer.SerializeToNode(value.Value, options),
                    "polyline" => JsonSerializer.SerializeToNode(value.Value, options),
                    "line" => JsonSerializer.SerializeToNode(value.Value, options),
                    "link" => JsonSerializer.SerializeToNode(value.Value, options),
                    "ink" => JsonSerializer.SerializeToNode(value.Value, options),
                    "free-text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "caret" => JsonSerializer.SerializeToNode(value.Value, options),
                    "text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "stamp" => JsonSerializer.SerializeToNode(value.Value, options),
                    "file-attachment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "widget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "redact" => JsonSerializer.SerializeToNode(value.Value, options),
                    "popup" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override AnnotationDraft ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationDraft(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraft value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Subtype);
        }
    }

    /// <summary>
    /// Discriminated union type for highlight
    /// </summary>
    [Serializable]
    public struct Highlight
    {
        public Highlight(CloudPDF.AnnotationDraftHighlight value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftHighlight Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Highlight(
            CloudPDF.AnnotationDraftHighlight value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for underline
    /// </summary>
    [Serializable]
    public struct Underline
    {
        public Underline(CloudPDF.AnnotationDraftUnderline value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftUnderline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Underline(
            CloudPDF.AnnotationDraftUnderline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for squiggly
    /// </summary>
    [Serializable]
    public struct Squiggly
    {
        public Squiggly(CloudPDF.AnnotationDraftSquiggly value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftSquiggly Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Squiggly(
            CloudPDF.AnnotationDraftSquiggly value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for strikeout
    /// </summary>
    [Serializable]
    public struct Strikeout
    {
        public Strikeout(CloudPDF.AnnotationDraftStrikeout value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftStrikeout Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Strikeout(
            CloudPDF.AnnotationDraftStrikeout value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for circle
    /// </summary>
    [Serializable]
    public struct Circle
    {
        public Circle(CloudPDF.AnnotationDraftCircle value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftCircle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Circle(
            CloudPDF.AnnotationDraftCircle value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for square
    /// </summary>
    [Serializable]
    public struct Square
    {
        public Square(CloudPDF.AnnotationDraftSquare value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftSquare Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Square(
            CloudPDF.AnnotationDraftSquare value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polygon
    /// </summary>
    [Serializable]
    public struct Polygon
    {
        public Polygon(CloudPDF.AnnotationDraftPolygon value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPolygon Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Polygon(
            CloudPDF.AnnotationDraftPolygon value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polyline
    /// </summary>
    [Serializable]
    public struct Polyline
    {
        public Polyline(CloudPDF.AnnotationDraftPolyline value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPolyline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Polyline(
            CloudPDF.AnnotationDraftPolyline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for line
    /// </summary>
    [Serializable]
    public struct Line
    {
        public Line(CloudPDF.AnnotationDraftLine value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftLine Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Line(CloudPDF.AnnotationDraftLine value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for link
    /// </summary>
    [Serializable]
    public struct Link
    {
        public Link(CloudPDF.AnnotationDraftLink value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftLink Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Link(CloudPDF.AnnotationDraftLink value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for ink
    /// </summary>
    [Serializable]
    public struct Ink
    {
        public Ink(CloudPDF.AnnotationDraftInk value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftInk Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Ink(CloudPDF.AnnotationDraftInk value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for free-text
    /// </summary>
    [Serializable]
    public struct FreeText
    {
        public FreeText(CloudPDF.AnnotationDraftFreeText value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftFreeText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.FreeText(
            CloudPDF.AnnotationDraftFreeText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for caret
    /// </summary>
    [Serializable]
    public struct Caret
    {
        public Caret(CloudPDF.AnnotationDraftCaret value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftCaret Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Caret(
            CloudPDF.AnnotationDraftCaret value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudPDF.AnnotationDraftText value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Text(CloudPDF.AnnotationDraftText value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for stamp
    /// </summary>
    [Serializable]
    public struct Stamp
    {
        public Stamp(CloudPDF.AnnotationDraftStamp value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftStamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Stamp(
            CloudPDF.AnnotationDraftStamp value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for file-attachment
    /// </summary>
    [Serializable]
    public struct FileAttachment
    {
        public FileAttachment(CloudPDF.AnnotationDraftFileAttachment value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftFileAttachment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.FileAttachment(
            CloudPDF.AnnotationDraftFileAttachment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for widget
    /// </summary>
    [Serializable]
    public struct Widget
    {
        public Widget(CloudPDF.AnnotationDraftWidget value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Widget(
            CloudPDF.AnnotationDraftWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for redact
    /// </summary>
    [Serializable]
    public struct Redact
    {
        public Redact(CloudPDF.AnnotationDraftRedact value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftRedact Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Redact(
            CloudPDF.AnnotationDraftRedact value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for popup
    /// </summary>
    [Serializable]
    public struct Popup
    {
        public Popup(CloudPDF.AnnotationDraftPopup value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationDraftPopup Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationDraft.Popup(
            CloudPDF.AnnotationDraftPopup value
        ) => new(value);
    }
}
