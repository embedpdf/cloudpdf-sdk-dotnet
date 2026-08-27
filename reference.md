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
        Pon = 1,
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
        Pon = 1,
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

The returned share id IS the public share token. Mounted only when the deployment can sign (HS256 mode) — exchange mints session JWTs, so grants exist only where minting does.
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
            new TokensIssueRequest.Doc(
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
<details><summary><code>client.Doc.Annotations.<a href="/src/CloudPDF/Doc/Annotations/AnnotationsClient.cs">ListAsync</a>(ListAnnotationsRequest { ... }) -> WithRawResponseTask&lt;DocAnnotationsList200Response&gt;</code></summary>
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
        Pon = 1,
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
        Pon = 1,
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
        Pon = 1,
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
        Pon = 1,
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

## Doc Forms
<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">GetAsync</a>(GetFormsRequest { ... }) -> WithRawResponseTask&lt;DocFormsGet200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.GetAsync(new GetFormsRequest { DocId = "docId", LayerName = "layerName" });
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

**request:** `GetFormsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ExportDataAsync</a>(ExportDataFormsRequest { ... }) -> WithRawResponseTask&lt;Stream&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ExportDataAsync(
    new ExportDataFormsRequest { DocId = "docId", LayerName = "layerName" }
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

**request:** `ExportDataFormsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ImportDataAsync</a>(ImportDataFormsRequest { ... }) -> WithRawResponseTask&lt;DocFormsImportData200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ImportDataAsync(
    new ImportDataFormsRequest
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

**request:** `ImportDataFormsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Forms.<a href="/src/CloudPDF/Doc/Forms/FormsClient.cs">ResetAsync</a>(ResetFormsRequest { ... }) -> WithRawResponseTask&lt;DocFormsReset200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Forms.ResetAsync(
    new ResetFormsRequest
    {
        DocId = "docId",
        LayerName = "layerName",
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

**request:** `ResetFormsRequest` 
    
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

## Doc Metadata
<details><summary><code>client.Doc.Metadata.<a href="/src/CloudPDF/Doc/Metadata/MetadataClient.cs">GetAsync</a>(GetMetadataRequest { ... }) -> WithRawResponseTask&lt;DocMetadataGet200Response&gt;</code></summary>
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

## Doc Pages
<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">DeleteAsync</a>(DeletePagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesDelete200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.DeleteAsync(
    new DeletePagesRequest
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

**request:** `DeletePagesRequest` 
    
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

A read, not a mutation: the source document is untouched and no event is published. Body is `{"pageObjectNumbers": number[]}`; the response body is the new PDF.
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

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">InsertAsync</a>(InsertPagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesInsert200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Multipart mutation envelope: a `body` field holding `{"destIndex"?: number}` (omitted → append) plus a `resource:source` file part carrying the standalone PDF whose pages are copied in. The inserted copies get fresh page object numbers, returned in insertion order.
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
await client.Doc.Pages.InsertAsync(
    new InsertPagesRequest { DocId = "docId", LayerName = "layerName" }
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

**request:** `InsertPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">InsertBlankAsync</a>(InsertBlankPagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesInsertBlank200Response&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Body is `{"size": {"width", "height"}, "count"?, "destIndex"?}` — size in PDF points, count in [1, 100], destIndex omitted → append.
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
await client.Doc.Pages.InsertBlankAsync(
    new InsertBlankPagesRequest
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

**request:** `InsertBlankPagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">MoveAsync</a>(MovePagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesMove200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.MoveAsync(
    new MovePagesRequest
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

**request:** `MovePagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Doc.Pages.<a href="/src/CloudPDF/Doc/Pages/PagesClient.cs">RotateAsync</a>(RotatePagesRequest { ... }) -> WithRawResponseTask&lt;DocPagesRotate200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Pages.RotateAsync(
    new RotatePagesRequest
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

**request:** `RotatePagesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Doc Redactions
<details><summary><code>client.Doc.Redactions.<a href="/src/CloudPDF/Doc/Redactions/RedactionsClient.cs">ApplyAsync</a>(ApplyRedactionsRequest { ... }) -> WithRawResponseTask&lt;DocRedactionsApply200Response&gt;</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Doc.Redactions.ApplyAsync(
    new ApplyRedactionsRequest
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

**request:** `ApplyRedactionsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

