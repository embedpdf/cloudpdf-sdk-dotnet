// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatch.JsonConverter))]
[Serializable]
public record AnnotationPatch
{
    internal AnnotationPatch(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Highlight"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Highlight value)
    {
        Subtype = "highlight";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Underline"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Underline value)
    {
        Subtype = "underline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Squiggly"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Squiggly value)
    {
        Subtype = "squiggly";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Strikeout"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Strikeout value)
    {
        Subtype = "strikeout";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Circle"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Circle value)
    {
        Subtype = "circle";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Square"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Square value)
    {
        Subtype = "square";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Polygon"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Polygon value)
    {
        Subtype = "polygon";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Polyline"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Polyline value)
    {
        Subtype = "polyline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Line"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Line value)
    {
        Subtype = "line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Link"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Link value)
    {
        Subtype = "link";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Ink"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Ink value)
    {
        Subtype = "ink";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.FreeText"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.FreeText value)
    {
        Subtype = "free-text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Caret"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Caret value)
    {
        Subtype = "caret";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Text"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Text value)
    {
        Subtype = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Stamp"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Stamp value)
    {
        Subtype = "stamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.FileAttachment"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.FileAttachment value)
    {
        Subtype = "file-attachment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Widget"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Widget value)
    {
        Subtype = "widget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Redact"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Redact value)
    {
        Subtype = "redact";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AnnotationPatch with <see cref="AnnotationPatch.Popup"/>.
    /// </summary>
    public AnnotationPatch(AnnotationPatch.Popup value)
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
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchHighlight"/> if <see cref="Subtype"/> is 'highlight', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'highlight'.</exception>
    public CloudPDF.AnnotationPatchHighlight AsHighlight() =>
        IsHighlight
            ? (CloudPDF.AnnotationPatchHighlight)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'highlight'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchUnderline"/> if <see cref="Subtype"/> is 'underline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'underline'.</exception>
    public CloudPDF.AnnotationPatchUnderline AsUnderline() =>
        IsUnderline
            ? (CloudPDF.AnnotationPatchUnderline)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'underline'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchSquiggly"/> if <see cref="Subtype"/> is 'squiggly', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'squiggly'.</exception>
    public CloudPDF.AnnotationPatchSquiggly AsSquiggly() =>
        IsSquiggly
            ? (CloudPDF.AnnotationPatchSquiggly)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'squiggly'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchStrikeout"/> if <see cref="Subtype"/> is 'strikeout', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'strikeout'.</exception>
    public CloudPDF.AnnotationPatchStrikeout AsStrikeout() =>
        IsStrikeout
            ? (CloudPDF.AnnotationPatchStrikeout)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'strikeout'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchCircle"/> if <see cref="Subtype"/> is 'circle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'circle'.</exception>
    public CloudPDF.AnnotationPatchCircle AsCircle() =>
        IsCircle
            ? (CloudPDF.AnnotationPatchCircle)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'circle'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchSquare"/> if <see cref="Subtype"/> is 'square', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'square'.</exception>
    public CloudPDF.AnnotationPatchSquare AsSquare() =>
        IsSquare
            ? (CloudPDF.AnnotationPatchSquare)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'square'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchPolygon"/> if <see cref="Subtype"/> is 'polygon', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polygon'.</exception>
    public CloudPDF.AnnotationPatchPolygon AsPolygon() =>
        IsPolygon
            ? (CloudPDF.AnnotationPatchPolygon)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'polygon'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchPolyline"/> if <see cref="Subtype"/> is 'polyline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polyline'.</exception>
    public CloudPDF.AnnotationPatchPolyline AsPolyline() =>
        IsPolyline
            ? (CloudPDF.AnnotationPatchPolyline)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'polyline'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchLine"/> if <see cref="Subtype"/> is 'line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'line'.</exception>
    public CloudPDF.AnnotationPatchLine AsLine() =>
        IsLine
            ? (CloudPDF.AnnotationPatchLine)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'line'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchLink"/> if <see cref="Subtype"/> is 'link', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'link'.</exception>
    public CloudPDF.AnnotationPatchLink AsLink() =>
        IsLink
            ? (CloudPDF.AnnotationPatchLink)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'link'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchInk"/> if <see cref="Subtype"/> is 'ink', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'ink'.</exception>
    public CloudPDF.AnnotationPatchInk AsInk() =>
        IsInk
            ? (CloudPDF.AnnotationPatchInk)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'ink'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchFreeText"/> if <see cref="Subtype"/> is 'free-text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'free-text'.</exception>
    public CloudPDF.AnnotationPatchFreeText AsFreeText() =>
        IsFreeText
            ? (CloudPDF.AnnotationPatchFreeText)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'free-text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchCaret"/> if <see cref="Subtype"/> is 'caret', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'caret'.</exception>
    public CloudPDF.AnnotationPatchCaret AsCaret() =>
        IsCaret
            ? (CloudPDF.AnnotationPatchCaret)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'caret'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchText"/> if <see cref="Subtype"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'text'.</exception>
    public CloudPDF.AnnotationPatchText AsText() =>
        IsText
            ? (CloudPDF.AnnotationPatchText)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchStamp"/> if <see cref="Subtype"/> is 'stamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'stamp'.</exception>
    public CloudPDF.AnnotationPatchStamp AsStamp() =>
        IsStamp
            ? (CloudPDF.AnnotationPatchStamp)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'stamp'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchFileAttachment"/> if <see cref="Subtype"/> is 'file-attachment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'file-attachment'.</exception>
    public CloudPDF.AnnotationPatchFileAttachment AsFileAttachment() =>
        IsFileAttachment
            ? (CloudPDF.AnnotationPatchFileAttachment)Value!
            : throw new global::System.Exception(
                "AnnotationPatch.Subtype is not 'file-attachment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.WidgetPatch"/> if <see cref="Subtype"/> is 'widget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'widget'.</exception>
    public CloudPDF.WidgetPatch AsWidget() =>
        IsWidget
            ? (CloudPDF.WidgetPatch)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'widget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchRedact"/> if <see cref="Subtype"/> is 'redact', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'redact'.</exception>
    public CloudPDF.AnnotationPatchRedact AsRedact() =>
        IsRedact
            ? (CloudPDF.AnnotationPatchRedact)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'redact'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPatchPopup"/> if <see cref="Subtype"/> is 'popup', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'popup'.</exception>
    public CloudPDF.AnnotationPatchPopup AsPopup() =>
        IsPopup
            ? (CloudPDF.AnnotationPatchPopup)Value!
            : throw new global::System.Exception("AnnotationPatch.Subtype is not 'popup'");

    public T Match<T>(
        Func<CloudPDF.AnnotationPatchHighlight, T> onHighlight,
        Func<CloudPDF.AnnotationPatchUnderline, T> onUnderline,
        Func<CloudPDF.AnnotationPatchSquiggly, T> onSquiggly,
        Func<CloudPDF.AnnotationPatchStrikeout, T> onStrikeout,
        Func<CloudPDF.AnnotationPatchCircle, T> onCircle,
        Func<CloudPDF.AnnotationPatchSquare, T> onSquare,
        Func<CloudPDF.AnnotationPatchPolygon, T> onPolygon,
        Func<CloudPDF.AnnotationPatchPolyline, T> onPolyline,
        Func<CloudPDF.AnnotationPatchLine, T> onLine,
        Func<CloudPDF.AnnotationPatchLink, T> onLink,
        Func<CloudPDF.AnnotationPatchInk, T> onInk,
        Func<CloudPDF.AnnotationPatchFreeText, T> onFreeText,
        Func<CloudPDF.AnnotationPatchCaret, T> onCaret,
        Func<CloudPDF.AnnotationPatchText, T> onText,
        Func<CloudPDF.AnnotationPatchStamp, T> onStamp,
        Func<CloudPDF.AnnotationPatchFileAttachment, T> onFileAttachment,
        Func<CloudPDF.WidgetPatch, T> onWidget,
        Func<CloudPDF.AnnotationPatchRedact, T> onRedact,
        Func<CloudPDF.AnnotationPatchPopup, T> onPopup,
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
        Action<CloudPDF.AnnotationPatchHighlight> onHighlight,
        Action<CloudPDF.AnnotationPatchUnderline> onUnderline,
        Action<CloudPDF.AnnotationPatchSquiggly> onSquiggly,
        Action<CloudPDF.AnnotationPatchStrikeout> onStrikeout,
        Action<CloudPDF.AnnotationPatchCircle> onCircle,
        Action<CloudPDF.AnnotationPatchSquare> onSquare,
        Action<CloudPDF.AnnotationPatchPolygon> onPolygon,
        Action<CloudPDF.AnnotationPatchPolyline> onPolyline,
        Action<CloudPDF.AnnotationPatchLine> onLine,
        Action<CloudPDF.AnnotationPatchLink> onLink,
        Action<CloudPDF.AnnotationPatchInk> onInk,
        Action<CloudPDF.AnnotationPatchFreeText> onFreeText,
        Action<CloudPDF.AnnotationPatchCaret> onCaret,
        Action<CloudPDF.AnnotationPatchText> onText,
        Action<CloudPDF.AnnotationPatchStamp> onStamp,
        Action<CloudPDF.AnnotationPatchFileAttachment> onFileAttachment,
        Action<CloudPDF.WidgetPatch> onWidget,
        Action<CloudPDF.AnnotationPatchRedact> onRedact,
        Action<CloudPDF.AnnotationPatchPopup> onPopup,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchHighlight"/> and returns true if successful.
    /// </summary>
    public bool TryAsHighlight(out CloudPDF.AnnotationPatchHighlight? value)
    {
        if (Subtype == "highlight")
        {
            value = (CloudPDF.AnnotationPatchHighlight)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchUnderline"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnderline(out CloudPDF.AnnotationPatchUnderline? value)
    {
        if (Subtype == "underline")
        {
            value = (CloudPDF.AnnotationPatchUnderline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchSquiggly"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquiggly(out CloudPDF.AnnotationPatchSquiggly? value)
    {
        if (Subtype == "squiggly")
        {
            value = (CloudPDF.AnnotationPatchSquiggly)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchStrikeout"/> and returns true if successful.
    /// </summary>
    public bool TryAsStrikeout(out CloudPDF.AnnotationPatchStrikeout? value)
    {
        if (Subtype == "strikeout")
        {
            value = (CloudPDF.AnnotationPatchStrikeout)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchCircle"/> and returns true if successful.
    /// </summary>
    public bool TryAsCircle(out CloudPDF.AnnotationPatchCircle? value)
    {
        if (Subtype == "circle")
        {
            value = (CloudPDF.AnnotationPatchCircle)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchSquare"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquare(out CloudPDF.AnnotationPatchSquare? value)
    {
        if (Subtype == "square")
        {
            value = (CloudPDF.AnnotationPatchSquare)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchPolygon"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolygon(out CloudPDF.AnnotationPatchPolygon? value)
    {
        if (Subtype == "polygon")
        {
            value = (CloudPDF.AnnotationPatchPolygon)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchPolyline"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolyline(out CloudPDF.AnnotationPatchPolyline? value)
    {
        if (Subtype == "polyline")
        {
            value = (CloudPDF.AnnotationPatchPolyline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchLine"/> and returns true if successful.
    /// </summary>
    public bool TryAsLine(out CloudPDF.AnnotationPatchLine? value)
    {
        if (Subtype == "line")
        {
            value = (CloudPDF.AnnotationPatchLine)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchLink"/> and returns true if successful.
    /// </summary>
    public bool TryAsLink(out CloudPDF.AnnotationPatchLink? value)
    {
        if (Subtype == "link")
        {
            value = (CloudPDF.AnnotationPatchLink)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchInk"/> and returns true if successful.
    /// </summary>
    public bool TryAsInk(out CloudPDF.AnnotationPatchInk? value)
    {
        if (Subtype == "ink")
        {
            value = (CloudPDF.AnnotationPatchInk)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchFreeText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFreeText(out CloudPDF.AnnotationPatchFreeText? value)
    {
        if (Subtype == "free-text")
        {
            value = (CloudPDF.AnnotationPatchFreeText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchCaret"/> and returns true if successful.
    /// </summary>
    public bool TryAsCaret(out CloudPDF.AnnotationPatchCaret? value)
    {
        if (Subtype == "caret")
        {
            value = (CloudPDF.AnnotationPatchCaret)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudPDF.AnnotationPatchText? value)
    {
        if (Subtype == "text")
        {
            value = (CloudPDF.AnnotationPatchText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchStamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsStamp(out CloudPDF.AnnotationPatchStamp? value)
    {
        if (Subtype == "stamp")
        {
            value = (CloudPDF.AnnotationPatchStamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchFileAttachment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFileAttachment(out CloudPDF.AnnotationPatchFileAttachment? value)
    {
        if (Subtype == "file-attachment")
        {
            value = (CloudPDF.AnnotationPatchFileAttachment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.WidgetPatch"/> and returns true if successful.
    /// </summary>
    public bool TryAsWidget(out CloudPDF.WidgetPatch? value)
    {
        if (Subtype == "widget")
        {
            value = (CloudPDF.WidgetPatch)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchRedact"/> and returns true if successful.
    /// </summary>
    public bool TryAsRedact(out CloudPDF.AnnotationPatchRedact? value)
    {
        if (Subtype == "redact")
        {
            value = (CloudPDF.AnnotationPatchRedact)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPatchPopup"/> and returns true if successful.
    /// </summary>
    public bool TryAsPopup(out CloudPDF.AnnotationPatchPopup? value)
    {
        if (Subtype == "popup")
        {
            value = (CloudPDF.AnnotationPatchPopup)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AnnotationPatch(AnnotationPatch.Highlight value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Underline value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Squiggly value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Strikeout value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Circle value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Square value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Polygon value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Polyline value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Line value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Link value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Ink value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.FreeText value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Caret value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Text value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Stamp value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.FileAttachment value) =>
        new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Widget value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Redact value) => new(value);

    public static implicit operator AnnotationPatch(AnnotationPatch.Popup value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AnnotationPatch>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AnnotationPatch).IsAssignableFrom(typeToConvert);

        public override AnnotationPatch Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchHighlight?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchHighlight"
                        ),
                "underline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchUnderline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchUnderline"
                        ),
                "squiggly" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchSquiggly?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchSquiggly"
                        ),
                "strikeout" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchStrikeout?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchStrikeout"
                        ),
                "circle" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchCircle?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationPatchCircle"
                    ),
                "square" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchSquare?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationPatchSquare"
                    ),
                "polygon" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchPolygon?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationPatchPolygon"
                    ),
                "polyline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchPolyline?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchPolyline"
                        ),
                "line" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchLine?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchLine"),
                "link" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchLink?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchLink"),
                "ink" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchInk?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchInk"),
                "free-text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchFreeText?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchFreeText"
                        ),
                "caret" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchCaret?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchCaret"),
                "text" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchText?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchText"),
                "stamp" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchStamp?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchStamp"),
                "file-attachment" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchFileAttachment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationPatchFileAttachment"
                        ),
                "widget" => json.Deserialize<CloudPDF.WidgetPatch?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.WidgetPatch"),
                "redact" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchRedact?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize CloudPDF.AnnotationPatchRedact"
                    ),
                "popup" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPatchPopup?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPatchPopup"),
                _ => json.Deserialize<object?>(options),
            };
            return new AnnotationPatch(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatch value,
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

        public override AnnotationPatch ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new AnnotationPatch(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatch value,
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
        public Highlight(CloudPDF.AnnotationPatchHighlight value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchHighlight Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Highlight(
            CloudPDF.AnnotationPatchHighlight value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for underline
    /// </summary>
    [Serializable]
    public struct Underline
    {
        public Underline(CloudPDF.AnnotationPatchUnderline value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchUnderline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Underline(
            CloudPDF.AnnotationPatchUnderline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for squiggly
    /// </summary>
    [Serializable]
    public struct Squiggly
    {
        public Squiggly(CloudPDF.AnnotationPatchSquiggly value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchSquiggly Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Squiggly(
            CloudPDF.AnnotationPatchSquiggly value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for strikeout
    /// </summary>
    [Serializable]
    public struct Strikeout
    {
        public Strikeout(CloudPDF.AnnotationPatchStrikeout value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchStrikeout Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Strikeout(
            CloudPDF.AnnotationPatchStrikeout value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for circle
    /// </summary>
    [Serializable]
    public struct Circle
    {
        public Circle(CloudPDF.AnnotationPatchCircle value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchCircle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Circle(
            CloudPDF.AnnotationPatchCircle value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for square
    /// </summary>
    [Serializable]
    public struct Square
    {
        public Square(CloudPDF.AnnotationPatchSquare value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchSquare Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Square(
            CloudPDF.AnnotationPatchSquare value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polygon
    /// </summary>
    [Serializable]
    public struct Polygon
    {
        public Polygon(CloudPDF.AnnotationPatchPolygon value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchPolygon Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Polygon(
            CloudPDF.AnnotationPatchPolygon value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polyline
    /// </summary>
    [Serializable]
    public struct Polyline
    {
        public Polyline(CloudPDF.AnnotationPatchPolyline value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchPolyline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Polyline(
            CloudPDF.AnnotationPatchPolyline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for line
    /// </summary>
    [Serializable]
    public struct Line
    {
        public Line(CloudPDF.AnnotationPatchLine value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchLine Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Line(CloudPDF.AnnotationPatchLine value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for link
    /// </summary>
    [Serializable]
    public struct Link
    {
        public Link(CloudPDF.AnnotationPatchLink value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchLink Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Link(CloudPDF.AnnotationPatchLink value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for ink
    /// </summary>
    [Serializable]
    public struct Ink
    {
        public Ink(CloudPDF.AnnotationPatchInk value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchInk Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Ink(CloudPDF.AnnotationPatchInk value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for free-text
    /// </summary>
    [Serializable]
    public struct FreeText
    {
        public FreeText(CloudPDF.AnnotationPatchFreeText value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchFreeText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.FreeText(
            CloudPDF.AnnotationPatchFreeText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for caret
    /// </summary>
    [Serializable]
    public struct Caret
    {
        public Caret(CloudPDF.AnnotationPatchCaret value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchCaret Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Caret(
            CloudPDF.AnnotationPatchCaret value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudPDF.AnnotationPatchText value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Text(CloudPDF.AnnotationPatchText value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for stamp
    /// </summary>
    [Serializable]
    public struct Stamp
    {
        public Stamp(CloudPDF.AnnotationPatchStamp value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchStamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Stamp(
            CloudPDF.AnnotationPatchStamp value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for file-attachment
    /// </summary>
    [Serializable]
    public struct FileAttachment
    {
        public FileAttachment(CloudPDF.AnnotationPatchFileAttachment value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchFileAttachment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.FileAttachment(
            CloudPDF.AnnotationPatchFileAttachment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for widget
    /// </summary>
    [Serializable]
    public struct Widget
    {
        public Widget(CloudPDF.WidgetPatch value)
        {
            Value = value;
        }

        internal CloudPDF.WidgetPatch Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Widget(CloudPDF.WidgetPatch value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for redact
    /// </summary>
    [Serializable]
    public struct Redact
    {
        public Redact(CloudPDF.AnnotationPatchRedact value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchRedact Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Redact(
            CloudPDF.AnnotationPatchRedact value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for popup
    /// </summary>
    [Serializable]
    public struct Popup
    {
        public Popup(CloudPDF.AnnotationPatchPopup value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPatchPopup Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator AnnotationPatch.Popup(
            CloudPDF.AnnotationPatchPopup value
        ) => new(value);
    }
}
