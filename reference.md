# Reference
## Deployment
<details><summary><code>client.Deployment.<a href="/src/CloudPDF/Deployment/DeploymentClient.cs">LicenseStatusAsync</a>() -> WithRawResponseTask&lt;DeploymentLicenseStatusResponse&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Deployment.LicenseStatusAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc
<details><summary><code>client.Doc.<a href="/src/CloudPDF/Doc/DocClient.cs">HeadAsync</a>(HeadDocRequest { ... }) -> WithRawResponseTask&lt;DocHead200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.HeadAsync(new HeadDocRequest { DocId = "docId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HeadDocRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.<a href="/src/CloudPDF/Doc/DocClient.cs">ChangesAsync</a>(DocChangesRequest { ... }) -> WithRawResponseTask&lt;DocChanges200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Each change stands on its own and names itself by `opId`: a refused change rolls back alone, and the answer lists every change in order, applied with its result or refused with its error. Asked again under its `opId`, a change gets the same answer, refusals included; a different change under an answered `opId` is refused (IdempotencyKeyReused). `{ opId, undoOf }` undoes an earlier change of the caller, here or in an earlier request; an undo leaves alone what was changed since, and the undo of an undo redoes. A redaction, a flatten, a form repair or a completed signature ends undo for the changes before it (UndoUnavailable). Each op is checked against its own capability: annotation ops need `doc.annotate.modify`, form values `doc.forms.fill`, form structure `doc.forms.modify`, metadata `doc.metadata.modify`, outline `doc.outline.modify`, pages `doc.pages.assemble`, embedded files `doc.attachments.modify`. Bytes (a stamp's drawing, an attached file, a signature's artwork, a PDF whose pages come in) travel as multipart: a JSON `body` part, each op naming its files by role as `resources: { <role>: '<key>' }`, and each file as the part `resource:<key>`. At most 64 changes per request and 512 ops per change.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.ChangesAsync(
    new DocChangesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        Changes = new List<DocChangesRequestChangesItem>()
        {
            new DocChangesRequestChangesItem { OpId = "opId" },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocChangesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.<a href="/src/CloudPDF/Doc/DocClient.cs">DownloadAsync</a>(DownloadDocRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.DownloadAsync(new DownloadDocRequest { DocId = "docId", LayerName = "layerName" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DownloadDocRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.<a href="/src/CloudPDF/Doc/DocClient.cs">ManifestAsync</a>(ManifestDocRequest { ... }) -> WithRawResponseTask&lt;DocManifest200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.ManifestAsync(new ManifestDocRequest { DocId = "docId", LayerName = "layerName" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ManifestDocRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.<a href="/src/CloudPDF/Doc/DocClient.cs">RenderAsync</a>(RenderDocRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Render parameters (viewport, format) pass as flat dotted query keys, e.g. `?viewport.kind=width&viewport.width=800`; the full grammar is documented with the viewer.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.RenderAsync(
    new RenderDocRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RenderDocRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.<a href="/src/CloudPDF/Doc/DocClient.cs">TextAsync</a>(TextDocRequest { ... }) -> WithRawResponseTask&lt;DocText200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.TextAsync(
    new TextDocRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TextDocRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Shares
<details><summary><code>client.Shares.<a href="/src/CloudPDF/Shares/SharesClient.cs">ExchangeAsync</a>(SharesExchangeRequest { ... }) -> WithRawResponseTask&lt;SharesExchange200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Unauthenticated, but requires a browser Origin header, checked against the grant allowlist. Unknown, revoked, and disabled tokens are indistinguishable (404). Passphrase-protected grants return 422 SharePasswordRequired until `password` is supplied. Mounted only when the deployment can sign (HS256 mode).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.ExchangeAsync(new SharesExchangeRequest { ShareToken = "shareToken" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SharesExchangeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Shares.<a href="/src/CloudPDF/Shares/SharesClient.cs">ListAsync</a>(ListSharesRequest { ... }) -> WithRawResponseTask&lt;SharesList200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.ListAsync(new ListSharesRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSharesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Shares.<a href="/src/CloudPDF/Shares/SharesClient.cs">CreateAsync</a>(SharesCreateRequest { ... }) -> WithRawResponseTask&lt;SharesCreate200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

The returned share id is the public share token. Mounted only when the deployment can sign (HS256 mode) — exchange mints session JWTs, so grants exist only where minting does.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.CreateAsync(
    new SharesCreateRequest
    {
        TenantId = "tenantId",
        DocId = "docId",
        Scope = new List<string>() { "scope" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SharesCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Shares.<a href="/src/CloudPDF/Shares/SharesClient.cs">GetAsync</a>(GetSharesRequest { ... }) -> WithRawResponseTask&lt;SharesGet200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.GetAsync(new GetSharesRequest { TenantId = "tenantId", ShareId = "shareId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetSharesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Shares.<a href="/src/CloudPDF/Shares/SharesClient.cs">DeleteAsync</a>(DeleteSharesRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.DeleteAsync(
    new DeleteSharesRequest { TenantId = "tenantId", ShareId = "shareId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteSharesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Shares.<a href="/src/CloudPDF/Shares/SharesClient.cs">UpdateAsync</a>(SharesUpdateRequest { ... }) -> WithRawResponseTask&lt;SharesUpdate200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Shares.UpdateAsync(
    new SharesUpdateRequest { TenantId = "tenantId", ShareId = "shareId" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SharesUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tenants
<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">ListAsync</a>(ListTenantsRequest { ... }) -> WithRawResponseTask&lt;TenantsList200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.ListAsync(new ListTenantsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListTenantsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">CreateAsync</a>(TenantsCreateRequest { ... }) -> WithRawResponseTask&lt;TenantsCreate200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.CreateAsync(new TenantsCreateRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TenantsCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">GetAsync</a>(GetTenantsRequest { ... }) -> WithRawResponseTask&lt;TenantsGet200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.GetAsync(new GetTenantsRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetTenantsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">DeleteAsync</a>(DeleteTenantsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Destroys the tenant and everything in its namespace — documents, layers, stored bytes, audit history. Irreversible.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.DeleteAsync(new DeleteTenantsRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteTenantsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">ResumeAsync</a>(ResumeTenantsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.ResumeAsync(new ResumeTenantsRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ResumeTenantsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">SuspendAsync</a>(TenantsSuspendRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Instantly reversible with resume. The API token is exempt, so a suspended tenant can still be inspected, exported, resumed, or deleted.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.SuspendAsync(new TenantsSuspendRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TenantsSuspendRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tenants.<a href="/src/CloudPDF/Tenants/TenantsClient.cs">UsageAsync</a>(UsageTenantsRequest { ... }) -> WithRawResponseTask&lt;TenantsUsage200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Facts only — no limits or billing state. Views count share exchanges plus authorized /v1/access grants, deduplicated across the two.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tenants.UsageAsync(new UsageTenantsRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UsageTenantsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Documents
<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">ListAsync</a>(ListDocumentsRequest { ... }) -> WithRawResponseTask&lt;DocumentsList200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.ListAsync(new ListDocumentsRequest { TenantId = "tenantId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">GetAsync</a>(GetDocumentsRequest { ... }) -> WithRawResponseTask&lt;DocumentsGet200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.GetAsync(new GetDocumentsRequest { TenantId = "tenantId", Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">DeleteAsync</a>(DeleteDocumentsRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.DeleteAsync(new DeleteDocumentsRequest { TenantId = "tenantId", Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">CommitAsync</a>(DocumentsCommitRequest { ... }) -> WithRawResponseTask&lt;DocumentsCommit200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.CommitAsync(
    new DocumentsCommitRequest
    {
        TenantId = "tenantId",
        Id = "id",
        Sha256 = "sha256",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsCommitRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">DownloadAsync</a>(DownloadDocumentsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.DownloadAsync(
    new DownloadDocumentsRequest { TenantId = "tenantId", Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DownloadDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">ThumbnailAsync</a>(ThumbnailDocumentsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.ThumbnailAsync(
    new ThumbnailDocumentsRequest { TenantId = "tenantId", Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ThumbnailDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">UploadProxyAsync</a>(UploadProxyDocumentsRequest { ... }) -> WithRawResponseTask&lt;DocumentsUploadProxy200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

This bounded origin-mediated fallback must only be used after documents.init returns upload.kind=proxy. Auto mode prefers a presigned object-store PUT whenever available.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.UploadProxyAsync(
    new UploadProxyDocumentsRequest { TenantId = "tenantId", Id = "id" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UploadProxyDocumentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">ImportFromAsync</a>(DocumentsImportFromRequest { ... }) -> WithRawResponseTask&lt;DocumentsImportFrom200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Default mode is synchronous and bounded: the response returns only after the transfer verified and committed (or failed). mode=async (connection sources only) answers 202 immediately and an in-process worker performs the transfer with leased, fenced retries; poll the document until ready/failed. The deployment import policy gates scheme, network range, and size; sources must declare a length. CloudPDF copies and owns the bytes — the source is never referenced in place. A 502 marks a retryable upstream failure: retry with the same idempotencyKey to resume the same document. URL sources are capabilities and never echoed back. Connection sources name operator-registered storage (bucket/prefix scope, allowed credential classes, and tenant bindings are deployment configuration); `revision` is provider-interpreted (S3 VersionId, GCS generation, Azure version id).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.ImportFromAsync(
    new DocumentsImportFromRequest
    {
        TenantId = "tenantId",
        Source = new DocumentsImportFromRequestSource(
            new DocumentsImportFromRequestSource.Url(
                new DocumentsImportFromRequestSourceUrl { Url = "url" }
            )
        ),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsImportFromRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Documents.<a href="/src/CloudPDF/Documents/DocumentsClient.cs">InitAsync</a>(DocumentsInitRequest { ... }) -> WithRawResponseTask&lt;DocumentsInit200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Documents.InitAsync(
    new DocumentsInitRequest
    {
        TenantId = "tenantId",
        ContentLength = 1.1,
        ContentSha256 = "contentSha256",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocumentsInitRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Tokens
<details><summary><code>client.Tokens.<a href="/src/CloudPDF/Tokens/TokensClient.cs">IssueAsync</a>(IssueTokensRequest { ... }) -> WithRawResponseTask&lt;TokensIssue200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

kind "tenant" requires the API token — authority mints only downward. Mounted only when the deployment can sign (HS256 mode); asymmetric deployments mint with their own private key.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.IssueAsync(
    new IssueTokensRequest
    {
        TenantId = "tenantId",
        Body = new TokensIssueRequest(
            new CloudPDF.TokensIssueRequest.Doc(
                new TokensIssueRequestDoc
                {
                    Sub = "sub",
                    DocId = "docId",
                    Scope = new List<string>() { "scope" },
                    ExpiresIn = 1,
                }
            )
        ),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IssueTokensRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Tokens.<a href="/src/CloudPDF/Tokens/TokensClient.cs">RevokeAsync</a>(TokensRevokeRequest { ... }) -> WithRawResponseTask</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Mounted only when the deployment enables token revocation.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Tokens.RevokeAsync(new TokensRevokeRequest { TenantId = "tenantId", Jti = "jti" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `TokensRevokeRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Annotations
<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ListAllAsync</a>(ListAllAnnotationsRequest { ... }) -> WithRawResponseTask&lt;AnnotationList&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Returns one entry per page plus the audit-log cursor for reconciling subsequent document events. Page order is unspecified; join by `page` (a `PageRef`) when display order matters.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.ListAllAsync(
    new ListAllAnnotationsRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAllAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ListAsync</a>(ListAnnotationsRequest { ... }) -> WithRawResponseTask&lt;AnnotationList&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.ListAsync(
    new ListAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">CreateAsync</a>(CreateAnnotationsRequest { ... }) -> WithRawResponseTask&lt;DocAnnotationsCreate200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Doc JWTs may instead carry collab scopes (annotations:create:self, …) that refine per-annotation authorship rules; the API token is exempt from both.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.CreateAsync(
    new CreateAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CreateAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">DeleteAsync</a>(DeleteAnnotationsRequest { ... }) -> WithRawResponseTask&lt;DocAnnotationsDelete200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.DeleteAsync(
    new DeleteAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        AnnotKey = "annotKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">UpdateAsync</a>(UpdateAnnotationsRequest { ... }) -> WithRawResponseTask&lt;DocAnnotationsUpdate200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.UpdateAsync(
    new UpdateAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        AnnotKey = "annotKey",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `UpdateAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ReadAppearanceAsync</a>(ReadAppearanceAnnotationsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.ReadAppearanceAsync(
    new ReadAppearanceAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        AnnotKey = "annotKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReadAppearanceAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ReadFileAsync</a>(ReadFileAnnotationsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A file that decodes past the server's limit is refused (PayloadTooLarge).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.ReadFileAsync(
    new ReadFileAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        AnnotKey = "annotKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReadFileAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ExportAppearanceAsync</a>(ExportAppearanceAnnotationsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.ExportAppearanceAsync(
    new ExportAppearanceAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        Body = new Dictionary<string, object?>()
        {
            {
                "string",
                new Dictionary<object, object?>() { { "key", "value" } }
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExportAppearanceAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">FlattenAsync</a>(FlattenAnnotationsRequest { ... }) -> WithRawResponseTask&lt;DocAnnotationsFlatten200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.FlattenAsync(
    new FlattenAnnotationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FlattenAnnotationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ReorderAsync</a>(DocAnnotationsReorderRequest { ... }) -> WithRawResponseTask&lt;DocAnnotationsReorder200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Annotations.ReorderAsync(
    new DocAnnotationsReorderRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        Refs = new List<AnnotationRef>()
        {
            new AnnotationRef(
                new AnnotationRef.ObjectNumber(
                    new AnnotationRefObjectNumber
                    {
                        Page = new PageRef { Kind = PageRefKind.ObjectNumber, ObjectNumber = 1 },
                        ObjectNumber = 1,
                    }
                )
            ),
        },
        Position = AnnotationPositionZero.Start,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocAnnotationsReorderRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Attachments
<details><summary><code>client.Doc.Attachments.<a href="/src/CloudPDF/Doc/Attachments/AttachmentsClient.cs">DownloadAsync</a>(DownloadAttachmentsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A file that decodes past the server's limit is refused (PayloadTooLarge).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Attachments.DownloadAsync(
    new DownloadAttachmentsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        FileKey = "fileKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DownloadAttachmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Attachments.<a href="/src/CloudPDF/Doc/Attachments/AttachmentsClient.cs">ListAsync</a>(ListAttachmentsRequest { ... }) -> WithRawResponseTask&lt;AttachmentList&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A file-attachment annotation's file is listed with the annotation; read its bytes with `doc.annotations.readFile`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Attachments.ListAsync(
    new ListAttachmentsRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListAttachmentsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Forms
<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ListAsync</a>(ListFormsRequest { ... }) -> WithRawResponseTask&lt;DocFormsList200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ListAsync(new ListFormsRequest { DocId = "docId", LayerName = "layerName" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListFormsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ReorderCalculationsAsync</a>(DocFormsReorderCalculationsRequest { ... }) -> WithRawResponseTask&lt;DocFormsReorderCalculations200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ReorderCalculationsAsync(
    new DocFormsReorderCalculationsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        Fields = new List<FormFieldRef>()
        {
            new FormFieldRef(
                new FormFieldRef.ObjectNumber(new FormFieldRefObjectNumber { ObjectNumber = 1 })
            ),
        },
        Position = FieldPositionZero.Start,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocFormsReorderCalculationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">SetValueAsync</a>(SetValueFormsRequest { ... }) -> WithRawResponseTask&lt;DocFormsSetValue200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.SetValueAsync(
    new SetValueFormsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        FieldKey = "fieldKey",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SetValueFormsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ResetAsync</a>(DocFormsResetRequest { ... }) -> WithRawResponseTask&lt;DocFormsReset200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ResetAsync(
    new DocFormsResetRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocFormsResetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">DeleteWidgetAsync</a>(DeleteWidgetFormsRequest { ... }) -> WithRawResponseTask&lt;DocFormsDeleteWidget200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.DeleteWidgetAsync(
    new DeleteWidgetFormsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        AnnotKey = "annotKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DeleteWidgetFormsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">UpdateWidgetAsync</a>(DocFormsUpdateWidgetRequest { ... }) -> WithRawResponseTask&lt;DocFormsUpdateWidget200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.UpdateWidgetAsync(
    new DocFormsUpdateWidgetRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        AnnotKey = "annotKey",
        Patch = new WidgetPatch(),
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocFormsUpdateWidgetRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ReorderWidgetsAsync</a>(DocFormsReorderWidgetsRequest { ... }) -> WithRawResponseTask&lt;DocFormsReorderWidgets200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ReorderWidgetsAsync(
    new DocFormsReorderWidgetsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
        Widgets = new List<AnnotationRef>()
        {
            new AnnotationRef(
                new AnnotationRef.ObjectNumber(
                    new AnnotationRefObjectNumber
                    {
                        Page = new PageRef { Kind = PageRefKind.ObjectNumber, ObjectNumber = 1 },
                        ObjectNumber = 1,
                    }
                )
            ),
        },
        Position = AnnotationPositionZero.Start,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocFormsReorderWidgetsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Metadata
<details><summary><code>client.Doc.Metadata.<a href="/src/CloudPDF/Doc/Metadata/MetadataClient.cs">GetAsync</a>(GetMetadataRequest { ... }) -> WithRawResponseTask&lt;DocumentMetadata&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Metadata.GetAsync(
    new GetMetadataRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetMetadataRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Outline
<details><summary><code>client.Doc.Outline.<a href="/src/CloudPDF/Doc/Outline/OutlineClient.cs">GetAsync</a>(GetOutlineRequest { ... }) -> WithRawResponseTask&lt;DocumentOutline&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Outline.GetAsync(
    new GetOutlineRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetOutlineRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Pages
<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">SetScaleAsync</a>(DocPagesSetScaleRequest { ... }) -> WithRawResponseTask&lt;DocPagesSetScale200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.SetScaleAsync(
    new DocPagesSetScaleRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocPagesSetScaleRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">ViewportsAsync</a>(ViewportsPagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesViewports200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.ViewportsAsync(
    new ViewportsPagesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        PageKey = "pageKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ViewportsPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">ExtractAsync</a>(ExtractPagesRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

A read, not a mutation: the source document is untouched and no event is published. Body is `{"pages": PageRef[], "flatten"?: {"usage"?: "display" | "print"}, "includeAnnotations"?: boolean, "includeFormFields"?: boolean}`; the response body is the new PDF. With `flatten` the copy is the pages as they draw for `usage` (`"print"`: a print copy): the annotations and form fields painted in, nothing interactive left, layers in their state for the usage. A flattened copy takes `doc.download` or `doc.download.flattened`, and paints only what the caller may read; `includeAnnotations` and `includeFormFields` choose what it paints, and are refused without `flatten`.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.ExtractAsync(
    new ExtractPagesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        Body = new Dictionary<string, object?>()
        {
            {
                "string",
                new Dictionary<object, object?>() { { "key", "value" } }
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ExtractPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">FlattenAsync</a>(FlattenPagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesFlatten200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.FlattenAsync(
    new FlattenPagesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `FlattenPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">SetNameAsync</a>(SetNamePagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesSetName200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.SetNameAsync(
    new SetNamePagesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SetNamePagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">RemoveNameAsync</a>(RemoveNamePagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesRemoveName200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.RemoveNameAsync(
    new RemoveNamePagesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        Body = new Dictionary<string, object?>() { { "key", "value" } },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RemoveNamePagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Redactions
<details><summary><code>client.Doc.Redactions.<a href="/src/CloudPDF/Doc/Redactions/RedactionsClient.cs">ApplyAsync</a>(DocRedactionsApplyRequest { ... }) -> WithRawResponseTask&lt;DocRedactionsApply200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Redactions.ApplyAsync(
    new DocRedactionsApplyRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocRedactionsApplyRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Signatures
<details><summary><code>client.Doc.Signatures.<a href="/src/CloudPDF/Doc/Signatures/SignaturesClient.cs">ListAsync</a>(ListSignaturesRequest { ... }) -> WithRawResponseTask&lt;DocSignaturesList200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Describes the bytes the layer is over: the base version's signatures plus the layer's own edits as the last revision. Signed bytes (contents, digests, revision prefixes) are served per base version under /versions.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Signatures.ListAsync(
    new ListSignaturesRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListSignaturesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Signatures.<a href="/src/CloudPDF/Doc/Signatures/SignaturesClient.cs">CancelAsync</a>(CancelSignaturesRequest { ... }) -> WithRawResponseTask&lt;DocSignaturesCancel200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Signatures.CancelAsync(
    new CancelSignaturesRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        SigningId = "signingId",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `CancelSignaturesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Signatures.<a href="/src/CloudPDF/Doc/Signatures/SignaturesClient.cs">CompleteAsync</a>(DocSignaturesCompleteRequest { ... }) -> WithRawResponseTask&lt;DocSignaturesComplete200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

`cms` is the detached CMS over the prepared digest, base64. `expectedVersion` must be what prepare returned. Idempotent by signing id: the same CMS again answers `already-completed`. Every layer of the document then sits over the new version; refetch the manifest after a completion.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Signatures.CompleteAsync(
    new DocSignaturesCompleteRequest
    {
        DocId = "docId",
        LayerName = "layerName",
        SigningId = "signingId",
        Cms = "cms",
        ExpectedVersion = new DocSignaturesCompleteRequestExpectedVersion
        {
            BaseSha256 = "baseSha256",
            EditsVersion = 1,
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DocSignaturesCompleteRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Signatures.<a href="/src/CloudPDF/Doc/Signatures/SignaturesClient.cs">AnalysisAsync</a>(AnalysisSignaturesRequest { ... }) -> WithRawResponseTask&lt;DocSignaturesAnalysis200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exactly one of `since.signature=<index>` or `since.revision=<index>`; the layer's pending edits are the end. `level=fill|annotate|lta|none` evaluates exploratorily and never becomes a verdict. For history between two base revisions use the version analysis.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Signatures.AnalysisAsync(
    new AnalysisSignaturesRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnalysisSignaturesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Signatures.<a href="/src/CloudPDF/Doc/Signatures/SignaturesClient.cs">PrepareAsync</a>(PrepareSignaturesRequest { ... }) -> WithRawResponseTask&lt;DocSignaturesPrepare200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Multipart: a JSON `body` part (field, subFilter, digest, contentsSize, signer, certify, lock), naming the appearance PDF it may carry as `resources: { appearance: '<key>' }`, and that PDF as the part `resource:<key>`. A certification (`certify.permission`) additionally requires `doc.sign.certify`. The layer is read-only until the signing completes, is cancelled, or expires (15 minutes). A layer behind the document head cannot sign (StaleBase).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Signatures.PrepareAsync(
    new PrepareSignaturesRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PrepareSignaturesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Versions
<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">ListAsync</a>(ListVersionsRequest { ... }) -> WithRawResponseTask&lt;DocVersionsList200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Every completed signature publishes a new version. Never cached: the list grows.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.ListAsync(new ListVersionsRequest { DocId = "docId" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">AnalysisAsync</a>(AnalysisVersionsRequest { ... }) -> WithRawResponseTask&lt;DocVersionsAnalysis200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Exactly one of `since.signature` / `since.revision`; `until=<revision>` defaults to the last. The same answer for every layer and every caller.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.AnalysisAsync(
    new AnalysisVersionsRequest { DocId = "docId", Sha = "sha" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AnalysisVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">DownloadAsync</a>(DownloadVersionsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.DownloadAsync(
    new DownloadVersionsRequest { DocId = "docId", Sha = "sha" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DownloadVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">RevisionAsync</a>(RevisionVersionsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.RevisionAsync(
    new RevisionVersionsRequest
    {
        DocId = "docId",
        Sha = "sha",
        Index = 1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `RevisionVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">SignaturesAsync</a>(SignaturesVersionsRequest { ... }) -> WithRawResponseTask&lt;DocVersionsSignatures200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.SignaturesAsync(
    new SignaturesVersionsRequest { DocId = "docId", Sha = "sha" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SignaturesVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">SignatureContentsAsync</a>(SignatureContentsVersionsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

`fieldKey` is the field's fully qualified name, token-text encoded (the same encoding attachment keys use).
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.SignatureContentsAsync(
    new SignatureContentsVersionsRequest
    {
        DocId = "docId",
        Sha = "sha",
        FieldKey = "fieldKey",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SignatureContentsVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Versions.<a href="/src/CloudPDF/Doc/Versions/VersionsClient.cs">SignatureDigestAsync</a>(SignatureDigestVersionsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

What a CMS verifier compares its message digest to.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Versions.SignatureDigestAsync(
    new SignatureDigestVersionsRequest
    {
        DocId = "docId",
        Sha = "sha",
        FieldKey = "fieldKey",
        Algorithm = SignatureDigestVersionsRequestAlgorithm.Sha1,
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `SignatureDigestVersionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Metadata Custom
<details><summary><code>client.Doc.Metadata.Custom.<a href="/src/CloudPDF/Doc/Metadata/Custom/CustomClient.cs">GetAsync</a>(GetCustomRequest { ... }) -> WithRawResponseTask&lt;Dictionary&lt;string, string&gt;&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Metadata.Custom.GetAsync(
    new GetCustomRequest { DocId = "docId", LayerName = "layerName" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `GetCustomRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

