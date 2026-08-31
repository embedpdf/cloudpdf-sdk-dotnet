using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Annotations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "pageState": {
                "pageObjectNumber": 1,
                "revision": {
                  "docSessionId": "docSessionId",
                  "pageObjectNumber": 1,
                  "generation": 1
                },
                "weakAnnotationState": {
                  "kind": "unknown"
                }
              },
              "annotations": [
                {
                  "subtype": "highlight",
                  "ref": {
                    "kind": "objectNumber",
                    "pageObjectNumber": 1,
                    "annotObjectNumber": 1
                  },
                  "pageObjectNumber": 1,
                  "index": 1,
                  "identityQuality": "durable",
                  "nm": "nm",
                  "flags": {
                    "invisible": true,
                    "hidden": true,
                    "print": true,
                    "noZoom": true,
                    "noRotate": true,
                    "noView": true,
                    "readOnly": true,
                    "locked": true,
                    "toggleNoView": true,
                    "lockedContents": true
                  },
                  "rect": {
                    "left": 1.1,
                    "bottom": 1.1,
                    "right": 1.1,
                    "top": 1.1
                  },
                  "contents": "contents",
                  "subject": "subject",
                  "author": "author",
                  "created": "2024-01-15T09:30:00.000Z",
                  "modified": "2024-01-15T09:30:00.000Z",
                  "blendMode": "normal",
                  "inReplyTo": {
                    "kind": "objectNumber",
                    "pageObjectNumber": 1,
                    "annotObjectNumber": 1
                  },
                  "replyType": "reply",
                  "userId": "userId",
                  "groupId": "groupId",
                  "createdBy": "createdBy",
                  "updatedBy": "updatedBy",
                  "actions": {
                    "activate": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "cursorEnter": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "cursorExit": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "mouseDown": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "mouseUp": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "focus": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "blur": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageOpen": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageClose": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageVisible": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageInvisible": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    }
                  },
                  "color": {
                    "r": 255,
                    "g": 255,
                    "b": 255
                  },
                  "opacity": 1,
                  "quadPoints": [
                    {
                      "p1": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p2": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p3": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p4": {
                        "x": 1.1,
                        "y": 1.1
                      }
                    },
                    {
                      "p1": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p2": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p3": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p4": {
                        "x": 1.1,
                        "y": 1.1
                      }
                    }
                  ]
                },
                {
                  "subtype": "highlight",
                  "ref": {
                    "kind": "objectNumber",
                    "pageObjectNumber": 1,
                    "annotObjectNumber": 1
                  },
                  "pageObjectNumber": 1,
                  "index": 1,
                  "identityQuality": "durable",
                  "nm": "nm",
                  "flags": {
                    "invisible": true,
                    "hidden": true,
                    "print": true,
                    "noZoom": true,
                    "noRotate": true,
                    "noView": true,
                    "readOnly": true,
                    "locked": true,
                    "toggleNoView": true,
                    "lockedContents": true
                  },
                  "rect": {
                    "left": 1.1,
                    "bottom": 1.1,
                    "right": 1.1,
                    "top": 1.1
                  },
                  "contents": "contents",
                  "subject": "subject",
                  "author": "author",
                  "created": "2024-01-15T09:30:00.000Z",
                  "modified": "2024-01-15T09:30:00.000Z",
                  "blendMode": "normal",
                  "inReplyTo": {
                    "kind": "objectNumber",
                    "pageObjectNumber": 1,
                    "annotObjectNumber": 1
                  },
                  "replyType": "reply",
                  "userId": "userId",
                  "groupId": "groupId",
                  "createdBy": "createdBy",
                  "updatedBy": "updatedBy",
                  "actions": {
                    "activate": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "cursorEnter": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "cursorExit": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "mouseDown": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "mouseUp": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "focus": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "blur": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageOpen": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageClose": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageVisible": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    },
                    "pageInvisible": {
                      "root": {
                        "type": "unknown",
                        "subtype": "subtype",
                        "script": "script",
                        "next": [
                          {
                            "key": "value"
                          },
                          {
                            "key": "value"
                          }
                        ]
                      },
                      "incomplete": true,
                      "warningFlags": 1,
                      "warnings": [
                        "cycle-dropped",
                        "cycle-dropped"
                      ]
                    }
                  },
                  "color": {
                    "r": 255,
                    "g": 255,
                    "b": 255
                  },
                  "opacity": 1,
                  "quadPoints": [
                    {
                      "p1": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p2": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p3": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p4": {
                        "x": 1.1,
                        "y": 1.1
                      }
                    },
                    {
                      "p1": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p2": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p3": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p4": {
                        "x": 1.1,
                        "y": 1.1
                      }
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/annotations/pages/1/items")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Annotations.ListAsync(
            new ListAnnotationsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "pageState": {
                "pageObjectNumber": 1,
                "revision": {
                  "docSessionId": "docSessionId",
                  "pageObjectNumber": 1,
                  "generation": 1
                },
                "weakAnnotationState": {
                  "kind": "unknown"
                }
              },
              "annotations": [
                {
                  "subtype": "highlight",
                  "ref": {
                    "kind": "objectNumber",
                    "pageObjectNumber": 1,
                    "annotObjectNumber": 1
                  },
                  "pageObjectNumber": 1,
                  "index": 1,
                  "identityQuality": "durable",
                  "nm": "nm",
                  "flags": {
                    "invisible": true,
                    "hidden": true,
                    "print": true,
                    "noZoom": true,
                    "noRotate": true,
                    "noView": true,
                    "readOnly": true,
                    "locked": true,
                    "toggleNoView": true,
                    "lockedContents": true
                  },
                  "rect": {
                    "left": 1.1,
                    "bottom": 1.1,
                    "right": 1.1,
                    "top": 1.1
                  },
                  "contents": "contents",
                  "subject": "subject",
                  "author": "author",
                  "created": "2024-01-15T09:30:00.000Z",
                  "modified": "2024-01-15T09:30:00.000Z",
                  "blendMode": "normal",
                  "inReplyTo": {
                    "kind": "objectNumber",
                    "pageObjectNumber": 1,
                    "annotObjectNumber": 1
                  },
                  "replyType": "reply",
                  "userId": "userId",
                  "groupId": "groupId",
                  "createdBy": "createdBy",
                  "updatedBy": "updatedBy",
                  "color": {
                    "r": 1,
                    "g": 1,
                    "b": 1
                  },
                  "opacity": 1.1,
                  "quadPoints": [
                    {
                      "p1": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p2": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p3": {
                        "x": 1.1,
                        "y": 1.1
                      },
                      "p4": {
                        "x": 1.1,
                        "y": 1.1
                      }
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/annotations/pages/1/items")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Annotations.ListAsync(
            new ListAnnotationsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
