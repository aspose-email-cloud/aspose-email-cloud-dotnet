# Aspose.Email.Cloud.Sdk.EmailApi

<a name="addcalendarattachment"></a>
# **AddCalendarAttachment**

```csharp
void AddCalendarAttachment(AddCalendarAttachmentRequest request)
```

Adds an attachment to iCalendar file             

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddCalendarAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **attachment** | **string**| Attachment file name in storage | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage name and folder path for calendar and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addcalendarattachment"></a>
# **AddCalendarAttachmentAsync**

```csharp
async Task AddCalendarAttachmentAsync(AddCalendarAttachmentRequest request)
```

Adds an attachment to iCalendar file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new AddCalendarAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **attachment** | **string**| Attachment file name in storage | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage name and folder path for calendar and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addcontactattachment"></a>
# **AddContactAttachment**

```csharp
void AddContactAttachment(AddContactAttachmentRequest request)
```

Add attachment to contact document             

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddContactAttachmentRequest(
    format,
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addcontactattachment"></a>
# **AddContactAttachmentAsync**

```csharp
async Task AddContactAttachmentAsync(AddContactAttachmentRequest request)
```

Add attachment to contact document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new AddContactAttachmentRequest(
    format,
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addemailattachment"></a>
# **AddEmailAttachment**

```csharp
EmailDocumentResponse AddEmailAttachment(AddEmailAttachmentRequest request)
```

Adds an attachment to Email document             

### Return type

[**EmailDocumentResponse**](EmailDocumentResponse.md)

### Request Parameters
```csharp
new AddEmailAttachmentRequest(
    attachmentName,
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentName** | **string**| Attachment file name | 
 **fileName** | **string**| Email document file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage info to specify location of email document and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addemailattachment"></a>
# **AddEmailAttachmentAsync**

```csharp
async Task<EmailDocumentResponse> AddEmailAttachmentAsync(AddEmailAttachmentRequest request)
```

Adds an attachment to Email document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDocumentResponse**](EmailDocumentResponse.md)>

### Request Parameters
```csharp
new AddEmailAttachmentRequest(
    attachmentName,
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachmentName** | **string**| Attachment file name | 
 **fileName** | **string**| Email document file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Storage info to specify location of email document and attachment files | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addmapiattachment"></a>
# **AddMapiAttachment**

```csharp
void AddMapiAttachment(AddMapiAttachmentRequest request)
```

Add attachment to document             

### Return type

void (empty response body)

### Request Parameters
```csharp
new AddMapiAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="addmapiattachment"></a>
# **AddMapiAttachmentAsync**

```csharp
async Task AddMapiAttachmentAsync(AddMapiAttachmentRequest request)
```

Add attachment to document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new AddMapiAttachmentRequest(
    name,
    attachment,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment file name | 
 **request** | [**AddAttachmentRequest**](AddAttachmentRequest.md)| Add attachment request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrocr"></a>
# **AiBcrOcr**

```csharp
ListResponseOfAiBcrOcrData AiBcrOcr(AiBcrOcrRequest request)
```

Ocr images             

### Return type

[**ListResponseOfAiBcrOcrData**](ListResponseOfAiBcrOcrData.md)

### Request Parameters
```csharp
new AiBcrOcrRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrocr"></a>
# **AiBcrOcrAsync**

```csharp
async Task<ListResponseOfAiBcrOcrData> AiBcrOcrAsync(AiBcrOcrRequest request)
```

Ocr images             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfAiBcrOcrData**](ListResponseOfAiBcrOcrData.md)>

### Request Parameters
```csharp
new AiBcrOcrRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrocrstorage"></a>
# **AiBcrOcrStorage**

```csharp
ListResponseOfAiBcrOcrData AiBcrOcrStorage(AiBcrOcrStorageRequest request)
```

Ocr images from storage             

### Return type

[**ListResponseOfAiBcrOcrData**](ListResponseOfAiBcrOcrData.md)

### Request Parameters
```csharp
new AiBcrOcrStorageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrStorageImageRq**](AiBcrStorageImageRq.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrocrstorage"></a>
# **AiBcrOcrStorageAsync**

```csharp
async Task<ListResponseOfAiBcrOcrData> AiBcrOcrStorageAsync(AiBcrOcrStorageRequest request)
```

Ocr images from storage             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfAiBcrOcrData**](ListResponseOfAiBcrOcrData.md)>

### Request Parameters
```csharp
new AiBcrOcrStorageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrStorageImageRq**](AiBcrStorageImageRq.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparse"></a>
# **AiBcrParse**

```csharp
ListResponseOfHierarchicalObject AiBcrParse(AiBcrParseRequest request)
```

Parse images to vCard properties             

### Return type

[**ListResponseOfHierarchicalObject**](ListResponseOfHierarchicalObject.md)

### Request Parameters
```csharp
new AiBcrParseRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparse"></a>
# **AiBcrParseAsync**

```csharp
async Task<ListResponseOfHierarchicalObject> AiBcrParseAsync(AiBcrParseRequest request)
```

Parse images to vCard properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfHierarchicalObject**](ListResponseOfHierarchicalObject.md)>

### Request Parameters
```csharp
new AiBcrParseRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsemodel"></a>
# **AiBcrParseModel**

```csharp
ListResponseOfContactDto AiBcrParseModel(AiBcrParseModelRequest request)
```

Parse images to vCard document models             

### Return type

[**ListResponseOfContactDto**](ListResponseOfContactDto.md)

### Request Parameters
```csharp
new AiBcrParseModelRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsemodel"></a>
# **AiBcrParseModelAsync**

```csharp
async Task<ListResponseOfContactDto> AiBcrParseModelAsync(AiBcrParseModelRequest request)
```

Parse images to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfContactDto**](ListResponseOfContactDto.md)>

### Request Parameters
```csharp
new AiBcrParseModelRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrBase64Rq**](AiBcrBase64Rq.md)| Request with base64 images data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparseocrdatamodel"></a>
# **AiBcrParseOcrDataModel**

```csharp
ListResponseOfContactDto AiBcrParseOcrDataModel(AiBcrParseOcrDataModelRequest request)
```

Parse OCR data to vCard document models             

### Return type

[**ListResponseOfContactDto**](ListResponseOfContactDto.md)

### Request Parameters
```csharp
new AiBcrParseOcrDataModelRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrParseOcrDataRq**](AiBcrParseOcrDataRq.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparseocrdatamodel"></a>
# **AiBcrParseOcrDataModelAsync**

```csharp
async Task<ListResponseOfContactDto> AiBcrParseOcrDataModelAsync(AiBcrParseOcrDataModelRequest request)
```

Parse OCR data to vCard document models             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfContactDto**](ListResponseOfContactDto.md)>

### Request Parameters
```csharp
new AiBcrParseOcrDataModelRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrParseOcrDataRq**](AiBcrParseOcrDataRq.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsestorage"></a>
# **AiBcrParseStorage**

```csharp
ListResponseOfStorageFileLocation AiBcrParseStorage(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

### Return type

[**ListResponseOfStorageFileLocation**](ListResponseOfStorageFileLocation.md)

### Request Parameters
```csharp
new AiBcrParseStorageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrParseStorageRq**](AiBcrParseStorageRq.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="aibcrparsestorage"></a>
# **AiBcrParseStorageAsync**

```csharp
async Task<ListResponseOfStorageFileLocation> AiBcrParseStorageAsync(AiBcrParseStorageRequest request)
```

Parse images from storage to vCard files             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfStorageFileLocation**](ListResponseOfStorageFileLocation.md)>

### Request Parameters
```csharp
new AiBcrParseStorageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiBcrParseStorageRq**](AiBcrParseStorageRq.md)| Request with images located on storage | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamecomplete"></a>
# **AiNameComplete**

```csharp
AiNameWeightedVariants AiNameComplete(AiNameCompleteRequest request)
```

The call proposes k most probable names for given starting characters             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### Request Parameters
```csharp
new AiNameCompleteRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to complete (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamecomplete"></a>
# **AiNameCompleteAsync**

```csharp
async Task<AiNameWeightedVariants> AiNameCompleteAsync(AiNameCompleteRequest request)
```

The call proposes k most probable names for given starting characters             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### Request Parameters
```csharp
new AiNameCompleteRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to complete (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpand"></a>
# **AiNameExpand**

```csharp
AiNameWeightedVariants AiNameExpand(AiNameExpandRequest request)
```

Expands a person's name into a list of possible alternatives using options for expanding instructions             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### Request Parameters
```csharp
new AiNameExpandRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpand"></a>
# **AiNameExpandAsync**

```csharp
async Task<AiNameWeightedVariants> AiNameExpandAsync(AiNameExpandRequest request)
```

Expands a person's name into a list of possible alternatives using options for expanding instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### Request Parameters
```csharp
new AiNameExpandRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpandparsed"></a>
# **AiNameExpandParsed**

```csharp
AiNameWeightedVariants AiNameExpandParsed(AiNameExpandParsedRequest request)
```

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions             

### Return type

[**AiNameWeightedVariants**](AiNameWeightedVariants.md)

### Request Parameters
```csharp
new AiNameExpandParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedRq**](AiNameParsedRq.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameexpandparsed"></a>
# **AiNameExpandParsedAsync**

```csharp
async Task<AiNameWeightedVariants> AiNameExpandParsedAsync(AiNameExpandParsedRequest request)
```

Expands a person's parsed name into a list of possible alternatives using options for expanding instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameWeightedVariants**](AiNameWeightedVariants.md)>

### Request Parameters
```csharp
new AiNameExpandParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedRq**](AiNameParsedRq.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformat"></a>
# **AiNameFormat**

```csharp
AiNameFormatted AiNameFormat(AiNameFormatRequest request)
```

Formats a person's name in correct case and name order using options for formatting instructions             

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

### Request Parameters
```csharp
new AiNameFormatRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    format=format,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **format** | **string**| Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (&#x3D; &#39;%t%F%m%N%L%p&#39;)     /format/FN+LN/ (&#x3D; &#39;%F%L&#39;)     /format/title+FN+LN/ (&#x3D; &#39;%t%F%L&#39;)     /format/FN+MN+LN/ (&#x3D; &#39;%F%M%N%L&#39;)     /format/title+FN+MN+LN/ (&#x3D; &#39;%t%F%M%N%L&#39;)     /format/FN+MI+LN/ (&#x3D; &#39;%F%m%N%L&#39;)     /format/title+FN+MI+LN/ (&#x3D; &#39;%t%F%m%N%L&#39;)     /format/LN/ (&#x3D; &#39;%L&#39;)     /format/title+LN/ (&#x3D; &#39;%t%L&#39;)     /format/LN+FN+MN/ (&#x3D; &#39;%L,%F%M%N&#39;)     /format/LN+title+FN+MN/ (&#x3D; &#39;%L,%t%F%M%N&#39;)     /format/LN+FN+MI/ (&#x3D; &#39;%L,%F%m%N&#39;)     /format/LN+title+FN+MI/ (&#x3D; &#39;%L,%t%F%m%N&#39;)  Custom format string - custom combination of characters and the next term placeholders:      &#39;%t&#39; - Title (prefix)     &#39;%F&#39; - First name     &#39;%f&#39; - First initial     &#39;%M&#39; - Middle name(s)     &#39;%m&#39; - Middle initial(s)     &#39;%N&#39; - Nickname     &#39;%L&#39; - Last name     &#39;%l&#39; - Last initial     &#39;%p&#39; - Postfix  If no value for format option was provided, its default value is &#39;%t%F%m%N%L%p&#39;              | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformat"></a>
# **AiNameFormatAsync**

```csharp
async Task<AiNameFormatted> AiNameFormatAsync(AiNameFormatRequest request)
```

Formats a person's name in correct case and name order using options for formatting instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

### Request Parameters
```csharp
new AiNameFormatRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    format=format,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to format (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **format** | **string**| Format of the name. Predefined format can be used by ID, or custom format can be specified. Predefined formats:      /format/default/ (&#x3D; &#39;%t%F%m%N%L%p&#39;)     /format/FN+LN/ (&#x3D; &#39;%F%L&#39;)     /format/title+FN+LN/ (&#x3D; &#39;%t%F%L&#39;)     /format/FN+MN+LN/ (&#x3D; &#39;%F%M%N%L&#39;)     /format/title+FN+MN+LN/ (&#x3D; &#39;%t%F%M%N%L&#39;)     /format/FN+MI+LN/ (&#x3D; &#39;%F%m%N%L&#39;)     /format/title+FN+MI+LN/ (&#x3D; &#39;%t%F%m%N%L&#39;)     /format/LN/ (&#x3D; &#39;%L&#39;)     /format/title+LN/ (&#x3D; &#39;%t%L&#39;)     /format/LN+FN+MN/ (&#x3D; &#39;%L,%F%M%N&#39;)     /format/LN+title+FN+MN/ (&#x3D; &#39;%L,%t%F%M%N&#39;)     /format/LN+FN+MI/ (&#x3D; &#39;%L,%F%m%N&#39;)     /format/LN+title+FN+MI/ (&#x3D; &#39;%L,%t%F%m%N&#39;)  Custom format string - custom combination of characters and the next term placeholders:      &#39;%t&#39; - Title (prefix)     &#39;%F&#39; - First name     &#39;%f&#39; - First initial     &#39;%M&#39; - Middle name(s)     &#39;%m&#39; - Middle initial(s)     &#39;%N&#39; - Nickname     &#39;%L&#39; - Last name     &#39;%l&#39; - Last initial     &#39;%p&#39; - Postfix  If no value for format option was provided, its default value is &#39;%t%F%m%N%L%p&#39;              | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformatparsed"></a>
# **AiNameFormatParsed**

```csharp
AiNameFormatted AiNameFormatParsed(AiNameFormatParsedRequest request)
```

Formats a person's parsed name in correct case and name order using options for formatting instructions             

### Return type

[**AiNameFormatted**](AiNameFormatted.md)

### Request Parameters
```csharp
new AiNameFormatParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedRq**](AiNameParsedRq.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameformatparsed"></a>
# **AiNameFormatParsedAsync**

```csharp
async Task<AiNameFormatted> AiNameFormatParsedAsync(AiNameFormatParsedRequest request)
```

Formats a person's parsed name in correct case and name order using options for formatting instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameFormatted**](AiNameFormatted.md)>

### Request Parameters
```csharp
new AiNameFormatParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedRq**](AiNameParsedRq.md)| Parsed name with options | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderize"></a>
# **AiNameGenderize**

```csharp
ListResponseOfAiNameGenderHypothesis AiNameGenderize(AiNameGenderizeRequest request)
```

Detect person's gender from name string             

### Return type

[**ListResponseOfAiNameGenderHypothesis**](ListResponseOfAiNameGenderHypothesis.md)

### Request Parameters
```csharp
new AiNameGenderizeRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderize"></a>
# **AiNameGenderizeAsync**

```csharp
async Task<ListResponseOfAiNameGenderHypothesis> AiNameGenderizeAsync(AiNameGenderizeRequest request)
```

Detect person's gender from name string             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfAiNameGenderHypothesis**](ListResponseOfAiNameGenderHypothesis.md)>

### Request Parameters
```csharp
new AiNameGenderizeRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderizeparsed"></a>
# **AiNameGenderizeParsed**

```csharp
ListResponseOfAiNameGenderHypothesis AiNameGenderizeParsed(AiNameGenderizeParsedRequest request)
```

Detect person's gender from parsed name             

### Return type

[**ListResponseOfAiNameGenderHypothesis**](ListResponseOfAiNameGenderHypothesis.md)

### Request Parameters
```csharp
new AiNameGenderizeParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedRq**](AiNameParsedRq.md)| Gender detection request data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamegenderizeparsed"></a>
# **AiNameGenderizeParsedAsync**

```csharp
async Task<ListResponseOfAiNameGenderHypothesis> AiNameGenderizeParsedAsync(AiNameGenderizeParsedRequest request)
```

Detect person's gender from parsed name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfAiNameGenderHypothesis**](ListResponseOfAiNameGenderHypothesis.md)>

### Request Parameters
```csharp
new AiNameGenderizeParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedRq**](AiNameParsedRq.md)| Gender detection request data | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematch"></a>
# **AiNameMatch**

```csharp
AiNameMatchResult AiNameMatch(AiNameMatchRequest request)
```

Compare people's names. Uses options for comparing instructions             

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

### Request Parameters
```csharp
new AiNameMatchRequest(
    name,
    otherName,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to match (required) | 
 **otherName** | **string**| Another name to match (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematch"></a>
# **AiNameMatchAsync**

```csharp
async Task<AiNameMatchResult> AiNameMatchAsync(AiNameMatchRequest request)
```

Compare people's names. Uses options for comparing instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

### Request Parameters
```csharp
new AiNameMatchRequest(
    name,
    otherName,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to match (required) | 
 **otherName** | **string**| Another name to match (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematchparsed"></a>
# **AiNameMatchParsed**

```csharp
AiNameMatchResult AiNameMatchParsed(AiNameMatchParsedRequest request)
```

Compare people's parsed names and attributes. Uses options for comparing instructions             

### Return type

[**AiNameMatchResult**](AiNameMatchResult.md)

### Request Parameters
```csharp
new AiNameMatchParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedMatchRq**](AiNameParsedMatchRq.md)| Parsed names to match | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainamematchparsed"></a>
# **AiNameMatchParsedAsync**

```csharp
async Task<AiNameMatchResult> AiNameMatchParsedAsync(AiNameMatchParsedRequest request)
```

Compare people's parsed names and attributes. Uses options for comparing instructions             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AiNameMatchResult**](AiNameMatchResult.md)>

### Request Parameters
```csharp
new AiNameMatchParsedRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AiNameParsedMatchRq**](AiNameParsedMatchRq.md)| Parsed names to match | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparse"></a>
# **AiNameParse**

```csharp
ListResponseOfAiNameComponent AiNameParse(AiNameParseRequest request)
```

Parse name to components             

### Return type

[**ListResponseOfAiNameComponent**](ListResponseOfAiNameComponent.md)

### Request Parameters
```csharp
new AiNameParseRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparse"></a>
# **AiNameParseAsync**

```csharp
async Task<ListResponseOfAiNameComponent> AiNameParseAsync(AiNameParseRequest request)
```

Parse name to components             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfAiNameComponent**](ListResponseOfAiNameComponent.md)>

### Request Parameters
```csharp
new AiNameParseRequest(
    name,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| A name to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparseemailaddress"></a>
# **AiNameParseEmailAddress**

```csharp
ListResponseOfAiNameExtracted AiNameParseEmailAddress(AiNameParseEmailAddressRequest request)
```

Parse person's name out of an email address             

### Return type

[**ListResponseOfAiNameExtracted**](ListResponseOfAiNameExtracted.md)

### Request Parameters
```csharp
new AiNameParseEmailAddressRequest(
    emailAddress,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Email address to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="ainameparseemailaddress"></a>
# **AiNameParseEmailAddressAsync**

```csharp
async Task<ListResponseOfAiNameExtracted> AiNameParseEmailAddressAsync(AiNameParseEmailAddressRequest request)
```

Parse person's name out of an email address             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfAiNameExtracted**](ListResponseOfAiNameExtracted.md)>

### Request Parameters
```csharp
new AiNameParseEmailAddressRequest(
    emailAddress,
    language=language,
    location=location,
    encoding=encoding,
    script=script,
    style=style)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailAddress** | **string**| Email address to parse (required) | 
 **language** | **string**| An ISO-639 code of the language; either 639-1 or 639-3 (e.g. \&quot;it\&quot; or \&quot;ita\&quot; for Italian)              | [optional] 
 **location** | **string**| A geographic code such as an ISO-3166 two letter country code, for example \&quot;FR\&quot; for France              | [optional] 
 **encoding** | **string**| A character encoding name | [optional] 
 **script** | **string**| A writing system code; starts with the ISO-15924 script name | [optional] 
 **style** | **string**| Name writing style. Enum, available values: Formal, Informal, Legal, Academic | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendemailmessage"></a>
# **AppendEmailMessage**

```csharp
EmailPropertyResponse AppendEmailMessage(AppendEmailMessageRequest request)
```

Adds an email from *.eml file to specified folder in email account             

### Return type

[**EmailPropertyResponse**](EmailPropertyResponse.md)

### Request Parameters
```csharp
new AppendEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AppendEmailBaseRequest**](AppendEmailBaseRequest.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendemailmessage"></a>
# **AppendEmailMessageAsync**

```csharp
async Task<EmailPropertyResponse> AppendEmailMessageAsync(AppendEmailMessageRequest request)
```

Adds an email from *.eml file to specified folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailPropertyResponse**](EmailPropertyResponse.md)>

### Request Parameters
```csharp
new AppendEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AppendEmailBaseRequest**](AppendEmailBaseRequest.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendemailmodelmessage"></a>
# **AppendEmailModelMessage**

```csharp
ValueResponse AppendEmailModelMessage(AppendEmailModelMessageRequest request)
```

Adds an email from model to specified folder in email account             

### Return type

[**ValueResponse**](ValueResponse.md)

### Request Parameters
```csharp
new AppendEmailModelMessageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AppendEmailModelRq**](AppendEmailModelRq.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendemailmodelmessage"></a>
# **AppendEmailModelMessageAsync**

```csharp
async Task<ValueResponse> AppendEmailModelMessageAsync(AppendEmailModelMessageRequest request)
```

Adds an email from model to specified folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ValueResponse**](ValueResponse.md)>

### Request Parameters
```csharp
new AppendEmailModelMessageRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**AppendEmailModelRq**](AppendEmailModelRq.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendmimemessage"></a>
# **AppendMimeMessage**

```csharp
ValueResponse AppendMimeMessage(AppendMimeMessageRequest request)
```

Adds an email from MIME to specified folder in email account             

### Return type

[**ValueResponse**](ValueResponse.md)

### Request Parameters
```csharp
new AppendMimeMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AppendEmailMimeBaseRequest**](AppendEmailMimeBaseRequest.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="appendmimemessage"></a>
# **AppendMimeMessageAsync**

```csharp
async Task<ValueResponse> AppendMimeMessageAsync(AppendMimeMessageRequest request)
```

Adds an email from MIME to specified folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ValueResponse**](ValueResponse.md)>

### Request Parameters
```csharp
new AppendMimeMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AppendEmailMimeBaseRequest**](AppendEmailMimeBaseRequest.md)| Append email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcalendar"></a>
# **ConvertCalendar**

```csharp
Stream ConvertCalendar(ConvertCalendarRequest request)
```

Converts calendar document to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ConvertCalendarRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcalendar"></a>
# **ConvertCalendarAsync**

```csharp
async Task<Stream> ConvertCalendarAsync(ConvertCalendarRequest request)
```

Converts calendar document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ConvertCalendarRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Ics, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcalendarmodeltoalternate"></a>
# **ConvertCalendarModelToAlternate**

```csharp
AlternateView ConvertCalendarModelToAlternate(ConvertCalendarModelToAlternateRequest request)
```

Convert iCalendar to AlternateView             

### Return type

[**AlternateView**](AlternateView.md)

### Request Parameters
```csharp
new ConvertCalendarModelToAlternateRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**CalendarDtoAlternateRq**](CalendarDtoAlternateRq.md)| iCalendar to AlternateView request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcalendarmodeltoalternate"></a>
# **ConvertCalendarModelToAlternateAsync**

```csharp
async Task<AlternateView> ConvertCalendarModelToAlternateAsync(ConvertCalendarModelToAlternateRequest request)
```

Convert iCalendar to AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AlternateView**](AlternateView.md)>

### Request Parameters
```csharp
new ConvertCalendarModelToAlternateRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**CalendarDtoAlternateRq**](CalendarDtoAlternateRq.md)| iCalendar to AlternateView request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcalendarmodeltofile"></a>
# **ConvertCalendarModelToFile**

```csharp
Stream ConvertCalendarModelToFile(ConvertCalendarModelToFileRequest request)
```

Converts calendar model to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ConvertCalendarModelToFileRequest(
    format,
    calendarDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Ics, Msg | 
 **calendarDto** | [**CalendarDto**](CalendarDto.md)| Calendar model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcalendarmodeltofile"></a>
# **ConvertCalendarModelToFileAsync**

```csharp
async Task<Stream> ConvertCalendarModelToFileAsync(ConvertCalendarModelToFileRequest request)
```

Converts calendar model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ConvertCalendarModelToFileRequest(
    format,
    calendarDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Ics, Msg | 
 **calendarDto** | [**CalendarDto**](CalendarDto.md)| Calendar model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcontact"></a>
# **ConvertContact**

```csharp
Stream ConvertContact(ConvertContactRequest request)
```

Converts contact document to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ConvertContactRequest(
    destinationFormat,
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationFormat** | **string**| File format to convert to Enum, available values: VCard, WebDav, Msg | 
 **format** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcontact"></a>
# **ConvertContactAsync**

```csharp
async Task<Stream> ConvertContactAsync(ConvertContactRequest request)
```

Converts contact document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ConvertContactRequest(
    destinationFormat,
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationFormat** | **string**| File format to convert to Enum, available values: VCard, WebDav, Msg | 
 **format** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcontactmodeltofile"></a>
# **ConvertContactModelToFile**

```csharp
Stream ConvertContactModelToFile(ConvertContactModelToFileRequest request)
```

Converts contact model to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ConvertContactModelToFileRequest(
    destinationFormat,
    contactDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **contactDto** | [**ContactDto**](ContactDto.md)| Contact model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertcontactmodeltofile"></a>
# **ConvertContactModelToFileAsync**

```csharp
async Task<Stream> ConvertContactModelToFileAsync(ConvertContactModelToFileRequest request)
```

Converts contact model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ConvertContactModelToFileRequest(
    destinationFormat,
    contactDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **contactDto** | [**ContactDto**](ContactDto.md)| Contact model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertemail"></a>
# **ConvertEmail**

```csharp
Stream ConvertEmail(ConvertEmailRequest request)
```

Converts email document to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ConvertEmailRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertemail"></a>
# **ConvertEmailAsync**

```csharp
async Task<Stream> ConvertEmailAsync(ConvertEmailRequest request)
```

Converts email document to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ConvertEmailRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertemailmodeltofile"></a>
# **ConvertEmailModelToFile**

```csharp
Stream ConvertEmailModelToFile(ConvertEmailModelToFileRequest request)
```

Converts Email model to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new ConvertEmailModelToFileRequest(
    destinationFormat,
    emailDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationFormat** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **emailDto** | [**EmailDto**](EmailDto.md)| Email model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="convertemailmodeltofile"></a>
# **ConvertEmailModelToFileAsync**

```csharp
async Task<Stream> ConvertEmailModelToFileAsync(ConvertEmailModelToFileRequest request)
```

Converts Email model to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new ConvertEmailModelToFileRequest(
    destinationFormat,
    emailDto)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinationFormat** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **emailDto** | [**EmailDto**](EmailDto.md)| Email model to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfile"></a>
# **CopyFile**

```csharp
void CopyFile(CopyFileRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new CopyFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfile"></a>
# **CopyFileAsync**

```csharp
async Task CopyFileAsync(CopyFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CopyFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfolder"></a>
# **CopyFolder**

```csharp
void CopyFolder(CopyFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new CopyFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="copyfolder"></a>
# **CopyFolderAsync**

```csharp
async Task CopyFolderAsync(CopyFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CopyFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcalendar"></a>
# **CreateCalendar**

```csharp
void CreateCalendar(CreateCalendarRequest request)
```

Create calendar file             

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateCalendarRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcalendar"></a>
# **CreateCalendarAsync**

```csharp
async Task CreateCalendarAsync(CreateCalendarRequest request)
```

Create calendar file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateCalendarRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Calendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcontact"></a>
# **CreateContact**

```csharp
void CreateContact(CreateContactRequest request)
```

Create contact document             

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateContactRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create contact request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createcontact"></a>
# **CreateContactAsync**

```csharp
async Task CreateContactAsync(CreateContactRequest request)
```

Create contact document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateContactRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create contact request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createemail"></a>
# **CreateEmail**

```csharp
EmailDocumentResponse CreateEmail(CreateEmailRequest request)
```

Create an email document             

### Return type

[**EmailDocumentResponse**](EmailDocumentResponse.md)

### Request Parameters
```csharp
new CreateEmailRequest(
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name in storage | 
 **request** | [**CreateEmailRequest**](CreateEmailRequest.md)| An email document and optional Storage info to specify where the file should be located              | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createemail"></a>
# **CreateEmailAsync**

```csharp
async Task<EmailDocumentResponse> CreateEmailAsync(CreateEmailRequest request)
```

Create an email document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDocumentResponse**](EmailDocumentResponse.md)>

### Request Parameters
```csharp
new CreateEmailRequest(
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name in storage | 
 **request** | [**CreateEmailRequest**](CreateEmailRequest.md)| An email document and optional Storage info to specify where the file should be located              | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createemailfolder"></a>
# **CreateEmailFolder**

```csharp
void CreateEmailFolder(CreateEmailFolderRequest request)
```

Create new folder in email account             

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateEmailFolderRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateFolderBaseRequest**](CreateFolderBaseRequest.md)| Create folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createemailfolder"></a>
# **CreateEmailFolderAsync**

```csharp
async Task CreateEmailFolderAsync(CreateEmailFolderRequest request)
```

Create new folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateEmailFolderRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateFolderBaseRequest**](CreateFolderBaseRequest.md)| Create folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createfolder"></a>
# **CreateFolder**

```csharp
void CreateFolder(CreateFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createfolder"></a>
# **CreateFolderAsync**

```csharp
async Task CreateFolderAsync(CreateFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateFolderRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createmapi"></a>
# **CreateMapi**

```csharp
void CreateMapi(CreateMapiRequest request)
```

Create new document             

### Return type

void (empty response body)

### Request Parameters
```csharp
new CreateMapiRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create document request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="createmapi"></a>
# **CreateMapiAsync**

```csharp
async Task CreateMapiAsync(CreateMapiRequest request)
```

Create new document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new CreateMapiRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Create document request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecalendarproperty"></a>
# **DeleteCalendarProperty**

```csharp
void DeleteCalendarProperty(DeleteCalendarPropertyRequest request)
```

Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteCalendarPropertyRequest(
    name,
    memberName,
    index,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **memberName** | **string**| Indexed property name | 
 **index** | **string**| Property index path | 
 **request** | [**StorageFolderLocation**](StorageFolderLocation.md)| Storage detail to specify iCalendar file location | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecalendarproperty"></a>
# **DeleteCalendarPropertyAsync**

```csharp
async Task DeleteCalendarPropertyAsync(DeleteCalendarPropertyRequest request)
```

Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteCalendarPropertyRequest(
    name,
    memberName,
    index,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **memberName** | **string**| Indexed property name | 
 **index** | **string**| Property index path | 
 **request** | [**StorageFolderLocation**](StorageFolderLocation.md)| Storage detail to specify iCalendar file location | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecontactproperty"></a>
# **DeleteContactProperty**

```csharp
void DeleteContactProperty(DeleteContactPropertyRequest request)
```

Delete property from indexed property list             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteContactPropertyRequest(
    format,
    name,
    memberName,
    index,
    folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **memberName** | **string**| Indexed property name | 
 **index** | **int?**| Property index | 
 **folder** | [**StorageFolderLocation**](StorageFolderLocation.md)| Calendar document location in storage information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletecontactproperty"></a>
# **DeleteContactPropertyAsync**

```csharp
async Task DeleteContactPropertyAsync(DeleteContactPropertyRequest request)
```

Delete property from indexed property list             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteContactPropertyRequest(
    format,
    name,
    memberName,
    index,
    folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **memberName** | **string**| Indexed property name | 
 **index** | **int?**| Property index | 
 **folder** | [**StorageFolderLocation**](StorageFolderLocation.md)| Calendar document location in storage information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailfolder"></a>
# **DeleteEmailFolder**

```csharp
void DeleteEmailFolder(DeleteEmailFolderRequest request)
```

Delete a folder in email account             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteEmailFolderRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DeleteFolderBaseRequest**](DeleteFolderBaseRequest.md)| Delete folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailfolder"></a>
# **DeleteEmailFolderAsync**

```csharp
async Task DeleteEmailFolderAsync(DeleteEmailFolderRequest request)
```

Delete a folder in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteEmailFolderRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DeleteFolderBaseRequest**](DeleteFolderBaseRequest.md)| Delete folder request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailmessage"></a>
# **DeleteEmailMessage**

```csharp
void DeleteEmailMessage(DeleteEmailMessageRequest request)
```

Delete message from email account by id             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DeleteMessageBaseRequest**](DeleteMessageBaseRequest.md)| Delete message request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailmessage"></a>
# **DeleteEmailMessageAsync**

```csharp
async Task DeleteEmailMessageAsync(DeleteEmailMessageRequest request)
```

Delete message from email account by id             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DeleteMessageBaseRequest**](DeleteMessageBaseRequest.md)| Delete message request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailthread"></a>
# **DeleteEmailThread**

```csharp
void DeleteEmailThread(DeleteEmailThreadRequest request)
```

Delete thread by id. All messages from thread will also be deleted             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteEmailThreadRequest(
    threadId,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread id | 
 **request** | [**DeleteEmailThreadAccountRq**](DeleteEmailThreadAccountRq.md)| Email account specifier | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deleteemailthread"></a>
# **DeleteEmailThreadAsync**

```csharp
async Task DeleteEmailThreadAsync(DeleteEmailThreadRequest request)
```

Delete thread by id. All messages from thread will also be deleted             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteEmailThreadRequest(
    threadId,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread id | 
 **request** | [**DeleteEmailThreadAccountRq**](DeleteEmailThreadAccountRq.md)| Email account specifier | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefile"></a>
# **DeleteFile**

```csharp
void DeleteFile(DeleteFileRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefile"></a>
# **DeleteFileAsync**

```csharp
async Task DeleteFileAsync(DeleteFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefolder"></a>
# **DeleteFolder**

```csharp
void DeleteFolder(DeleteFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteFolderRequest(
    path,
    storageName=storageName,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **recursive** | **bool?**|  | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletefolder"></a>
# **DeleteFolderAsync**

```csharp
async Task DeleteFolderAsync(DeleteFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteFolderRequest(
    path,
    storageName=storageName,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **recursive** | **bool?**|  | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiattachment"></a>
# **DeleteMapiAttachment**

```csharp
void DeleteMapiAttachment(DeleteMapiAttachmentRequest request)
```

Remove attachment from document             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteMapiAttachmentRequest(
    name,
    attachment,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **storage** | [**StorageFolderLocation**](StorageFolderLocation.md)| Document file storage location info | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiattachment"></a>
# **DeleteMapiAttachmentAsync**

```csharp
async Task DeleteMapiAttachmentAsync(DeleteMapiAttachmentRequest request)
```

Remove attachment from document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteMapiAttachmentRequest(
    name,
    attachment,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **storage** | [**StorageFolderLocation**](StorageFolderLocation.md)| Document file storage location info | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiproperties"></a>
# **DeleteMapiProperties**

```csharp
void DeleteMapiProperties(DeleteMapiPropertiesRequest request)
```

Delete document properties             

### Return type

void (empty response body)

### Request Parameters
```csharp
new DeleteMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be deleted | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="deletemapiproperties"></a>
# **DeleteMapiPropertiesAsync**

```csharp
async Task DeleteMapiPropertiesAsync(DeleteMapiPropertiesRequest request)
```

Delete document properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new DeleteMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be deleted | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="discoveremailconfig"></a>
# **DiscoverEmailConfig**

```csharp
EmailAccountConfigList DiscoverEmailConfig(DiscoverEmailConfigRequest request)
```

Discover email accounts by email address. Does not validate discovered accounts.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### Request Parameters
```csharp
new DiscoverEmailConfigRequest(
    address,
    fastProcessing=fastProcessing)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned              | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="discoveremailconfig"></a>
# **DiscoverEmailConfigAsync**

```csharp
async Task<EmailAccountConfigList> DiscoverEmailConfigAsync(DiscoverEmailConfigRequest request)
```

Discover email accounts by email address. Does not validate discovered accounts.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### Request Parameters
```csharp
new DiscoverEmailConfigRequest(
    address,
    fastProcessing=fastProcessing)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Email address | 
 **fastProcessing** | **bool?**| Turns on fast processing. All discover systems will run in parallel. First discovered result will be returned              | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="discoveremailconfigoauth"></a>
# **DiscoverEmailConfigOauth**

```csharp
EmailAccountConfigList DiscoverEmailConfigOauth(DiscoverEmailConfigOauthRequest request)
```

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### Request Parameters
```csharp
new DiscoverEmailConfigOauthRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**DiscoverEmailConfigOauth**](DiscoverEmailConfigOauth.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="discoveremailconfigoauth"></a>
# **DiscoverEmailConfigOauthAsync**

```csharp
async Task<EmailAccountConfigList> DiscoverEmailConfigOauthAsync(DiscoverEmailConfigOauthRequest request)
```

Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### Request Parameters
```csharp
new DiscoverEmailConfigOauthRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**DiscoverEmailConfigOauth**](DiscoverEmailConfigOauth.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="discoveremailconfigpassword"></a>
# **DiscoverEmailConfigPassword**

```csharp
EmailAccountConfigList DiscoverEmailConfigPassword(DiscoverEmailConfigPasswordRequest request)
```

Discover email accounts by email address. Validates discovered accounts using login and password.             

### Return type

[**EmailAccountConfigList**](EmailAccountConfigList.md)

### Request Parameters
```csharp
new DiscoverEmailConfigPasswordRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**DiscoverEmailConfigPassword**](DiscoverEmailConfigPassword.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="discoveremailconfigpassword"></a>
# **DiscoverEmailConfigPasswordAsync**

```csharp
async Task<EmailAccountConfigList> DiscoverEmailConfigPasswordAsync(DiscoverEmailConfigPasswordRequest request)
```

Discover email accounts by email address. Validates discovered accounts using login and password.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailAccountConfigList**](EmailAccountConfigList.md)>

### Request Parameters
```csharp
new DiscoverEmailConfigPasswordRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**DiscoverEmailConfigPassword**](DiscoverEmailConfigPassword.md)| Discover email configuration request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="downloadfile"></a>
# **DownloadFile**

```csharp
Stream DownloadFile(DownloadFileRequest request)
```



### Return type

**Stream**

### Request Parameters
```csharp
new DownloadFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="downloadfile"></a>
# **DownloadFileAsync**

```csharp
async Task<Stream> DownloadFileAsync(DownloadFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new DownloadFileRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailmessage"></a>
# **FetchEmailMessage**

```csharp
MimeResponse FetchEmailMessage(FetchEmailMessageRequest request)
```

Fetch message mime from email account             

### Return type

[**MimeResponse**](MimeResponse.md)

### Request Parameters
```csharp
new FetchEmailMessageRequest(
    messageId,
    firstAccount,
    secondAccount=secondAccount,
    folder=folder,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailmessage"></a>
# **FetchEmailMessageAsync**

```csharp
async Task<MimeResponse> FetchEmailMessageAsync(FetchEmailMessageRequest request)
```

Fetch message mime from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**MimeResponse**](MimeResponse.md)>

### Request Parameters
```csharp
new FetchEmailMessageRequest(
    messageId,
    firstAccount,
    secondAccount=secondAccount,
    folder=folder,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailmodel"></a>
# **FetchEmailModel**

```csharp
EmailDto FetchEmailModel(FetchEmailModelRequest request)
```

Fetch message model from email account             

### Return type

[**EmailDto**](EmailDto.md)

### Request Parameters
```csharp
new FetchEmailModelRequest(
    messageId,
    firstAccount,
    secondAccount=secondAccount,
    folder=folder,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailmodel"></a>
# **FetchEmailModelAsync**

```csharp
async Task<EmailDto> FetchEmailModelAsync(FetchEmailModelRequest request)
```

Fetch message model from email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### Request Parameters
```csharp
new FetchEmailModelRequest(
    messageId,
    firstAccount,
    secondAccount=secondAccount,
    folder=folder,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| Message identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **folder** | **string**| Account folder to fetch from (should be specified for some protocols such as IMAP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailthreadmessages"></a>
# **FetchEmailThreadMessages**

```csharp
ListResponseOfEmailDto FetchEmailThreadMessages(FetchEmailThreadMessagesRequest request)
```

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

### Return type

[**ListResponseOfEmailDto**](ListResponseOfEmailDto.md)

### Request Parameters
```csharp
new FetchEmailThreadMessagesRequest(
    threadId,
    firstAccount,
    secondAccount=secondAccount,
    folder=folder,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **folder** | **string**| Specifies account folder to get thread from              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="fetchemailthreadmessages"></a>
# **FetchEmailThreadMessagesAsync**

```csharp
async Task<ListResponseOfEmailDto> FetchEmailThreadMessagesAsync(FetchEmailThreadMessagesRequest request)
```

Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfEmailDto**](ListResponseOfEmailDto.md)>

### Request Parameters
```csharp
new FetchEmailThreadMessagesRequest(
    threadId,
    firstAccount,
    secondAccount=secondAccount,
    folder=folder,
    storage=storage,
    storageFolder=storageFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **folder** | **string**| Specifies account folder to get thread from              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendar"></a>
# **GetCalendar**

```csharp
HierarchicalObject GetCalendar(GetCalendarRequest request)
```

Get calendar file properties             

### Return type

[**HierarchicalObject**](HierarchicalObject.md)

### Request Parameters
```csharp
new GetCalendarRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendar"></a>
# **GetCalendarAsync**

```csharp
async Task<HierarchicalObject> GetCalendarAsync(GetCalendarRequest request)
```

Get calendar file properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**HierarchicalObject**](HierarchicalObject.md)>

### Request Parameters
```csharp
new GetCalendarRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarasfile"></a>
# **GetCalendarAsFile**

```csharp
Stream GetCalendarAsFile(GetCalendarAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new GetCalendarAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **format** | **string**| File format Enum, available values: Ics, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarasfile"></a>
# **GetCalendarAsFileAsync**

```csharp
async Task<Stream> GetCalendarAsFileAsync(GetCalendarAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetCalendarAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **format** | **string**| File format Enum, available values: Ics, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarattachment"></a>
# **GetCalendarAttachment**

```csharp
Stream GetCalendarAttachment(GetCalendarAttachmentRequest request)
```

Get iCalendar document attachment by name             

### Return type

**Stream**

### Request Parameters
```csharp
new GetCalendarAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarattachment"></a>
# **GetCalendarAttachmentAsync**

```csharp
async Task<Stream> GetCalendarAttachmentAsync(GetCalendarAttachmentRequest request)
```

Get iCalendar document attachment by name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetCalendarAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarfileasmodel"></a>
# **GetCalendarFileAsModel**

```csharp
CalendarDto GetCalendarFileAsModel(GetCalendarFileAsModelRequest request)
```

Converts calendar document to a model representation             

### Return type

[**CalendarDto**](CalendarDto.md)

### Request Parameters
```csharp
new GetCalendarFileAsModelRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarfileasmodel"></a>
# **GetCalendarFileAsModelAsync**

```csharp
async Task<CalendarDto> GetCalendarFileAsModelAsync(GetCalendarFileAsModelRequest request)
```

Converts calendar document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### Request Parameters
```csharp
new GetCalendarFileAsModelRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarlist"></a>
# **GetCalendarList**

```csharp
ListResponseOfHierarchicalObjectResponse GetCalendarList(GetCalendarListRequest request)
```

Get iCalendar files list in folder on storage             

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetCalendarListRequest(
    folder,
    itemsPerPage,
    pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | 
 **pageNumber** | **int?**| Page number | 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarlist"></a>
# **GetCalendarListAsync**

```csharp
async Task<ListResponseOfHierarchicalObjectResponse> GetCalendarListAsync(GetCalendarListRequest request)
```

Get iCalendar files list in folder on storage             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetCalendarListRequest(
    folder,
    itemsPerPage,
    pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | 
 **pageNumber** | **int?**| Page number | 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarmodel"></a>
# **GetCalendarModel**

```csharp
CalendarDto GetCalendarModel(GetCalendarModelRequest request)
```

Get calendar file             

### Return type

[**CalendarDto**](CalendarDto.md)

### Request Parameters
```csharp
new GetCalendarModelRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarmodel"></a>
# **GetCalendarModelAsync**

```csharp
async Task<CalendarDto> GetCalendarModelAsync(GetCalendarModelRequest request)
```

Get calendar file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDto**](CalendarDto.md)>

### Request Parameters
```csharp
new GetCalendarModelRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarmodelasalternate"></a>
# **GetCalendarModelAsAlternate**

```csharp
AlternateView GetCalendarModelAsAlternate(GetCalendarModelAsAlternateRequest request)
```

Get iCalendar from storage as AlternateView             

### Return type

[**AlternateView**](AlternateView.md)

### Request Parameters
```csharp
new GetCalendarModelAsAlternateRequest(
    name,
    calendarAction,
    sequenceId=sequenceId,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarmodelasalternate"></a>
# **GetCalendarModelAsAlternateAsync**

```csharp
async Task<AlternateView> GetCalendarModelAsAlternateAsync(GetCalendarModelAsAlternateRequest request)
```

Get iCalendar from storage as AlternateView             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**AlternateView**](AlternateView.md)>

### Request Parameters
```csharp
new GetCalendarModelAsAlternateRequest(
    name,
    calendarAction,
    sequenceId=sequenceId,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **calendarAction** | **string**| iCalendar method type Enum, available values: Create, Update, Cancel | 
 **sequenceId** | **string**| The sequence id | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarmodellist"></a>
# **GetCalendarModelList**

```csharp
CalendarDtoList GetCalendarModelList(GetCalendarModelListRequest request)
```

Get iCalendar list from storage folder             

### Return type

[**CalendarDtoList**](CalendarDtoList.md)

### Request Parameters
```csharp
new GetCalendarModelListRequest(
    folder,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcalendarmodellist"></a>
# **GetCalendarModelListAsync**

```csharp
async Task<CalendarDtoList> GetCalendarModelListAsync(GetCalendarModelListRequest request)
```

Get iCalendar list from storage folder             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**CalendarDtoList**](CalendarDtoList.md)>

### Request Parameters
```csharp
new GetCalendarModelListRequest(
    folder,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactasfile"></a>
# **GetContactAsFile**

```csharp
Stream GetContactAsFile(GetContactAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new GetContactAsFileRequest(
    fileName,
    destinationFormat,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **destinationFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **format** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactasfile"></a>
# **GetContactAsFileAsync**

```csharp
async Task<Stream> GetContactAsFileAsync(GetContactAsFileRequest request)
```

Converts calendar document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetContactAsFileRequest(
    fileName,
    destinationFormat,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Calendar document file name | 
 **destinationFormat** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **format** | **string**| File format to convert from Enum, available values: VCard, WebDav, Msg | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactattachment"></a>
# **GetContactAttachment**

```csharp
Stream GetContactAttachment(GetContactAttachmentRequest request)
```

Get attachment file by name             

### Return type

**Stream**

### Request Parameters
```csharp
new GetContactAttachmentRequest(
    format,
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactattachment"></a>
# **GetContactAttachmentAsync**

```csharp
async Task<Stream> GetContactAttachmentAsync(GetContactAttachmentRequest request)
```

Get attachment file by name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetContactAttachmentRequest(
    format,
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactfileasmodel"></a>
# **GetContactFileAsModel**

```csharp
ContactDto GetContactFileAsModel(GetContactFileAsModelRequest request)
```

Converts contact document to a model representation             

### Return type

[**ContactDto**](ContactDto.md)

### Request Parameters
```csharp
new GetContactFileAsModelRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactfileasmodel"></a>
# **GetContactFileAsModelAsync**

```csharp
async Task<ContactDto> GetContactFileAsModelAsync(GetContactFileAsModelRequest request)
```

Converts contact document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### Request Parameters
```csharp
new GetContactFileAsModelRequest(
    format,
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format Enum, available values: VCard, WebDav, Msg | 
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactlist"></a>
# **GetContactList**

```csharp
ListResponseOfHierarchicalObjectResponse GetContactList(GetContactListRequest request)
```

Get contact list from storage folder             

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetContactListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactlist"></a>
# **GetContactListAsync**

```csharp
async Task<ListResponseOfHierarchicalObjectResponse> GetContactListAsync(GetContactListRequest request)
```

Get contact list from storage folder             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetContactListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactmodel"></a>
# **GetContactModel**

```csharp
ContactDto GetContactModel(GetContactModelRequest request)
```

Get contact document.             

### Return type

[**ContactDto**](ContactDto.md)

### Request Parameters
```csharp
new GetContactModelRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactmodel"></a>
# **GetContactModelAsync**

```csharp
async Task<ContactDto> GetContactModelAsync(GetContactModelRequest request)
```

Get contact document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDto**](ContactDto.md)>

### Request Parameters
```csharp
new GetContactModelRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactmodellist"></a>
# **GetContactModelList**

```csharp
ContactDtoList GetContactModelList(GetContactModelListRequest request)
```

Get contact list from storage folder.             

### Return type

[**ContactDtoList**](ContactDtoList.md)

### Request Parameters
```csharp
new GetContactModelListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactmodellist"></a>
# **GetContactModelListAsync**

```csharp
async Task<ContactDtoList> GetContactModelListAsync(GetContactModelListRequest request)
```

Get contact list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ContactDtoList**](ContactDtoList.md)>

### Request Parameters
```csharp
new GetContactModelListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactproperties"></a>
# **GetContactProperties**

```csharp
HierarchicalObject GetContactProperties(GetContactPropertiesRequest request)
```

Get contact document properties             

### Return type

[**HierarchicalObject**](HierarchicalObject.md)

### Request Parameters
```csharp
new GetContactPropertiesRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getcontactproperties"></a>
# **GetContactPropertiesAsync**

```csharp
async Task<HierarchicalObject> GetContactPropertiesAsync(GetContactPropertiesRequest request)
```

Get contact document properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**HierarchicalObject**](HierarchicalObject.md)>

### Request Parameters
```csharp
new GetContactPropertiesRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getdiscusage"></a>
# **GetDiscUsage**

```csharp
DiscUsage GetDiscUsage(GetDiscUsageRequest request)
```



### Return type

[**DiscUsage**](DiscUsage.md)

### Request Parameters
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getdiscusage"></a>
# **GetDiscUsageAsync**

```csharp
async Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**DiscUsage**](DiscUsage.md)>

### Request Parameters
```csharp
new GetDiscUsageRequest(
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemail"></a>
# **GetEmail**

```csharp
EmailDocument GetEmail(GetEmailRequest request)
```

Get email document             

### Return type

[**EmailDocument**](EmailDocument.md)

### Request Parameters
```csharp
new GetEmailRequest(
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name in storage | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemail"></a>
# **GetEmailAsync**

```csharp
async Task<EmailDocument> GetEmailAsync(GetEmailRequest request)
```

Get email document             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDocument**](EmailDocument.md)>

### Request Parameters
```csharp
new GetEmailRequest(
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name in storage | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailasfile"></a>
# **GetEmailAsFile**

```csharp
Stream GetEmailAsFile(GetEmailAsFileRequest request)
```

Converts email document from storage to specified format and returns as file             

### Return type

**Stream**

### Request Parameters
```csharp
new GetEmailAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name | 
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailasfile"></a>
# **GetEmailAsFileAsync**

```csharp
async Task<Stream> GetEmailAsFileAsync(GetEmailAsFileRequest request)
```

Converts email document from storage to specified format and returns as file             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetEmailAsFileRequest(
    fileName,
    format,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| Email document file name | 
 **format** | **string**| File format Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailattachment"></a>
# **GetEmailAttachment**

```csharp
Stream GetEmailAttachment(GetEmailAttachmentRequest request)
```

Get email attachment by name             

### Return type

**Stream**

### Request Parameters
```csharp
new GetEmailAttachmentRequest(
    attachment,
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachment** | **string**| Attachment name | 
 **fileName** | **string**| Email document file name | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailattachment"></a>
# **GetEmailAttachmentAsync**

```csharp
async Task<Stream> GetEmailAttachmentAsync(GetEmailAttachmentRequest request)
```

Get email attachment by name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetEmailAttachmentRequest(
    attachment,
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attachment** | **string**| Attachment name | 
 **fileName** | **string**| Email document file name | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailclientaccount"></a>
# **GetEmailClientAccount**

```csharp
EmailClientAccount GetEmailClientAccount(GetEmailClientAccountRequest request)
```

Get email client account from storage             

### Return type

[**EmailClientAccount**](EmailClientAccount.md)

### Request Parameters
```csharp
new GetEmailClientAccountRequest(
    name,
    folder,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | 
 **storage** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailclientaccount"></a>
# **GetEmailClientAccountAsync**

```csharp
async Task<EmailClientAccount> GetEmailClientAccountAsync(GetEmailClientAccountRequest request)
```

Get email client account from storage             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailClientAccount**](EmailClientAccount.md)>

### Request Parameters
```csharp
new GetEmailClientAccountRequest(
    name,
    folder,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | 
 **storage** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailclientmultiaccount"></a>
# **GetEmailClientMultiAccount**

```csharp
EmailClientMultiAccount GetEmailClientMultiAccount(GetEmailClientMultiAccountRequest request)
```

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

### Return type

[**EmailClientMultiAccount**](EmailClientMultiAccount.md)

### Request Parameters
```csharp
new GetEmailClientMultiAccountRequest(
    name,
    folder,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | 
 **storage** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailclientmultiaccount"></a>
# **GetEmailClientMultiAccountAsync**

```csharp
async Task<EmailClientMultiAccount> GetEmailClientMultiAccountAsync(GetEmailClientMultiAccountRequest request)
```

Get email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailClientMultiAccount**](EmailClientMultiAccount.md)>

### Request Parameters
```csharp
new GetEmailClientMultiAccountRequest(
    name,
    folder,
    storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| File name on storage | 
 **folder** | **string**| Folder on storage | 
 **storage** | **string**| Storage name | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailfileasmodel"></a>
# **GetEmailFileAsModel**

```csharp
EmailDto GetEmailFileAsModel(GetEmailFileAsModelRequest request)
```

Converts email document to a model representation             

### Return type

[**EmailDto**](EmailDto.md)

### Request Parameters
```csharp
new GetEmailFileAsModelRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailfileasmodel"></a>
# **GetEmailFileAsModelAsync**

```csharp
async Task<EmailDto> GetEmailFileAsModelAsync(GetEmailFileAsModelRequest request)
```

Converts email document to a model representation             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### Request Parameters
```csharp
new GetEmailFileAsModelRequest(
    file)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| File to convert | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailmodel"></a>
# **GetEmailModel**

```csharp
EmailDto GetEmailModel(GetEmailModelRequest request)
```

Get email document.             

### Return type

[**EmailDto**](EmailDto.md)

### Request Parameters
```csharp
new GetEmailModelRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **name** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailmodel"></a>
# **GetEmailModelAsync**

```csharp
async Task<EmailDto> GetEmailModelAsync(GetEmailModelRequest request)
```

Get email document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDto**](EmailDto.md)>

### Request Parameters
```csharp
new GetEmailModelRequest(
    format,
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **name** | **string**| Email document file name. | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailmodellist"></a>
# **GetEmailModelList**

```csharp
EmailDtoList GetEmailModelList(GetEmailModelListRequest request)
```

Get email list from storage folder.             

### Return type

[**EmailDtoList**](EmailDtoList.md)

### Request Parameters
```csharp
new GetEmailModelListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailmodellist"></a>
# **GetEmailModelListAsync**

```csharp
async Task<EmailDtoList> GetEmailModelListAsync(GetEmailModelListRequest request)
```

Get email list from storage folder.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailDtoList**](EmailDtoList.md)>

### Request Parameters
```csharp
new GetEmailModelListRequest(
    format,
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Email document format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **folder** | **string**| Path to folder in storage. | [optional] 
 **storage** | **string**| Storage name. | [optional] 
 **itemsPerPage** | **int?**| Count of items on page. | [optional] [default to 10]
 **pageNumber** | **int?**| Page number. | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailproperty"></a>
# **GetEmailProperty**

```csharp
EmailPropertyResponse GetEmailProperty(GetEmailPropertyRequest request)
```

Get an email document property by its name             

### Return type

[**EmailPropertyResponse**](EmailPropertyResponse.md)

### Request Parameters
```csharp
new GetEmailPropertyRequest(
    propertyName,
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| A property name | 
 **fileName** | **string**| Email document file name | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getemailproperty"></a>
# **GetEmailPropertyAsync**

```csharp
async Task<EmailPropertyResponse> GetEmailPropertyAsync(GetEmailPropertyRequest request)
```

Get an email document property by its name             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailPropertyResponse**](EmailPropertyResponse.md)>

### Request Parameters
```csharp
new GetEmailPropertyRequest(
    propertyName,
    fileName,
    storage=storage,
    folder=folder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| A property name | 
 **fileName** | **string**| Email document file name | 
 **storage** | **string**| Storage name | [optional] 
 **folder** | **string**| Path to folder in storage | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileversions"></a>
# **GetFileVersions**

```csharp
FileVersions GetFileVersions(GetFileVersionsRequest request)
```



### Return type

[**FileVersions**](FileVersions.md)

### Request Parameters
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileversions"></a>
# **GetFileVersionsAsync**

```csharp
async Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FileVersions**](FileVersions.md)>

### Request Parameters
```csharp
new GetFileVersionsRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileslist"></a>
# **GetFilesList**

```csharp
FilesList GetFilesList(GetFilesListRequest request)
```



### Return type

[**FilesList**](FilesList.md)

### Request Parameters
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getfileslist"></a>
# **GetFilesListAsync**

```csharp
async Task<FilesList> GetFilesListAsync(GetFilesListRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FilesList**](FilesList.md)>

### Request Parameters
```csharp
new GetFilesListRequest(
    path,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachment"></a>
# **GetMapiAttachment**

```csharp
Stream GetMapiAttachment(GetMapiAttachmentRequest request)
```

Get document attachment as file stream             

### Return type

**Stream**

### Request Parameters
```csharp
new GetMapiAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachment"></a>
# **GetMapiAttachmentAsync**

```csharp
async Task<Stream> GetMapiAttachmentAsync(GetMapiAttachmentRequest request)
```

Get document attachment as file stream             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

**Task<Stream>**

### Request Parameters
```csharp
new GetMapiAttachmentRequest(
    name,
    attachment,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **attachment** | **string**| Attachment name or index | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachments"></a>
# **GetMapiAttachments**

```csharp
ListResponseOfString GetMapiAttachments(GetMapiAttachmentsRequest request)
```

Get document attachment list             

### Return type

[**ListResponseOfString**](ListResponseOfString.md)

### Request Parameters
```csharp
new GetMapiAttachmentsRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiattachments"></a>
# **GetMapiAttachmentsAsync**

```csharp
async Task<ListResponseOfString> GetMapiAttachmentsAsync(GetMapiAttachmentsRequest request)
```

Get document attachment list             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfString**](ListResponseOfString.md)>

### Request Parameters
```csharp
new GetMapiAttachmentsRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapilist"></a>
# **GetMapiList**

```csharp
ListResponseOfHierarchicalObjectResponse GetMapiList(GetMapiListRequest request)
```

Get document list from storage folder             

### Return type

[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetMapiListRequest(
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapilist"></a>
# **GetMapiListAsync**

```csharp
async Task<ListResponseOfHierarchicalObjectResponse> GetMapiListAsync(GetMapiListRequest request)
```

Get document list from storage folder             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfHierarchicalObjectResponse**](ListResponseOfHierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetMapiListRequest(
    folder=folder,
    storage=storage,
    itemsPerPage=itemsPerPage,
    pageNumber=pageNumber)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 
 **itemsPerPage** | **int?**| Count of items on page | [optional] [default to 10]
 **pageNumber** | **int?**| Page number | [optional] [default to 0]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiproperties"></a>
# **GetMapiProperties**

```csharp
HierarchicalObjectResponse GetMapiProperties(GetMapiPropertiesRequest request)
```

Get document properties             

### Return type

[**HierarchicalObjectResponse**](HierarchicalObjectResponse.md)

### Request Parameters
```csharp
new GetMapiPropertiesRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="getmapiproperties"></a>
# **GetMapiPropertiesAsync**

```csharp
async Task<HierarchicalObjectResponse> GetMapiPropertiesAsync(GetMapiPropertiesRequest request)
```

Get document properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**HierarchicalObjectResponse**](HierarchicalObjectResponse.md)>

### Request Parameters
```csharp
new GetMapiPropertiesRequest(
    name,
    folder=folder,
    storage=storage)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **folder** | **string**| Path to folder in storage | [optional] 
 **storage** | **string**| Storage name | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="isemailaddressdisposable"></a>
# **IsEmailAddressDisposable**

```csharp
ValueTOfBoolean IsEmailAddressDisposable(IsEmailAddressDisposableRequest request)
```

Check email address is disposable             

### Return type

[**ValueTOfBoolean**](ValueTOfBoolean.md)

### Request Parameters
```csharp
new IsEmailAddressDisposableRequest(
    address)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| An email address to check | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="isemailaddressdisposable"></a>
# **IsEmailAddressDisposableAsync**

```csharp
async Task<ValueTOfBoolean> IsEmailAddressDisposableAsync(IsEmailAddressDisposableRequest request)
```

Check email address is disposable             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ValueTOfBoolean**](ValueTOfBoolean.md)>

### Request Parameters
```csharp
new IsEmailAddressDisposableRequest(
    address)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| An email address to check | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailfolders"></a>
# **ListEmailFolders**

```csharp
ListResponseOfMailServerFolder ListEmailFolders(ListEmailFoldersRequest request)
```

Get folders list in email account             

### Return type

[**ListResponseOfMailServerFolder**](ListResponseOfMailServerFolder.md)

### Request Parameters
```csharp
new ListEmailFoldersRequest(
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    parentFolder=parentFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailfolders"></a>
# **ListEmailFoldersAsync**

```csharp
async Task<ListResponseOfMailServerFolder> ListEmailFoldersAsync(ListEmailFoldersRequest request)
```

Get folders list in email account             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ListResponseOfMailServerFolder**](ListResponseOfMailServerFolder.md)>

### Request Parameters
```csharp
new ListEmailFoldersRequest(
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    parentFolder=parentFolder)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **parentFolder** | **string**| Folder in which subfolders should be listed | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailmessages"></a>
# **ListEmailMessages**

```csharp
ListResponseOfString ListEmailMessages(ListEmailMessagesRequest request)
```

Get messages from folder, filtered by query             

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

### Return type

[**ListResponseOfString**](ListResponseOfString.md)

### Request Parameters
```csharp
new ListEmailMessagesRequest(
    folder,
    queryString,
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **queryString** | **string**| A MailQuery search string | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailmessages"></a>
# **ListEmailMessagesAsync**

```csharp
async Task<ListResponseOfString> ListEmailMessagesAsync(ListEmailMessagesRequest request)
```

Get messages from folder, filtered by query             

Performs operation asynchronously. Not available on .NETFramework v2.0

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

### Return type

Task<[**ListResponseOfString**](ListResponseOfString.md)>

### Request Parameters
```csharp
new ListEmailMessagesRequest(
    folder,
    queryString,
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **queryString** | **string**| A MailQuery search string | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailmodels"></a>
# **ListEmailModels**

```csharp
ListResponseOfEmailDto ListEmailModels(ListEmailModelsRequest request)
```

Get messages from folder, filtered by query             

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

### Return type

[**ListResponseOfEmailDto**](ListResponseOfEmailDto.md)

### Request Parameters
```csharp
new ListEmailModelsRequest(
    folder,
    firstAccount,
    queryString=queryString,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **firstAccount** | **string**| Email account | 
 **queryString** | **string**| A MailQuery search string | [optional] 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailmodels"></a>
# **ListEmailModelsAsync**

```csharp
async Task<ListResponseOfEmailDto> ListEmailModelsAsync(ListEmailModelsRequest request)
```

Get messages from folder, filtered by query             

Performs operation asynchronously. Not available on .NETFramework v2.0

The query string should have the following view.      The example of a simple expression:       '<Field name>' <Comparison operator> '<Field value>',  where &lt;Field Name&gt; - the name of a message field through which filtering is made, &lt;Comparison operator&gt; - comparison operators, as their name implies, allow to compare message field and specified value, &lt;Field value&gt; - value to be compared with a message field.      The number of simple expressions can make a compound one, ex.:     (<Simple expression 1> & <Simple expression 2>) | <Simple expression 3     >,  where \"&amp;\" - logical-AND operator, \"|\" - logical-OR operator      At present the following values are allowed as a field name (<Field name>):  \"To\" - represents a TO field of message, \"Text\" - represents string in the header or body of the message, \"Bcc\" - represents a BCC field of message, \"Body\" - represents a string in the body of message, \"Cc\" - represents a CC field of message, \"From\" - represents a From field of message, \"Subject\" - represents a string in the subject of message, \"InternalDate\" - represents an internal date of message, \"SentDate\" - represents a sent date of message      Additionally, the following field names are allowed for IMAP-protocol:  \"Answered\" - represents an /Answered flag of message \"Seen\" - represents a /Seen flag of message \"Flagged\" - represents a /Flagged flag of message \"Draft\" - represents a /Draft flag of message \"Deleted\" - represents a Deleted/ flag of message \"Recent\" - represents a Deleted/ flag of message \"MessageSize\" - represents a size (in bytes) of message      Additionally, the following field names are allowed for Exchange:  \"IsRead\" - Indicates whether the message has been read \"HasAttachment\" - Indicates whether or not the message has attachments \"IsSubmitted\" - Indicates whether the message has been submitted to the Outbox \"ContentClass\" - represents a content class of item      Additionally, the following field names are allowed for pst/ost files:  \"MessageClass\" - Represents a message class \"ContainerClass\" - Represents a folder container class \"Importance\" - Represents a message importance \"MessageSize\" - represents a size (in bytes) of message \"FolderName\" - represents a folder name \"ContentsCount\" - represents a total number of items in the folder \"UnreadContentsCount\" - represents the number of unread items in the folder. \"Subfolders\" - Indicates whether or not the folder has subfolders \"Read\" - the message is marked as having been read \"HasAttachment\" - the message has at least one attachment \"Unsent\" - the message is still being composed \"Unmodified\" - the message has not been modified since it was first saved (if unsent) or it was delivered (if sent) \"FromMe\" - the user receiving the message was also the user who sent the message \"Resend\" - the message includes a request for a resend operation with a non-delivery report \"NotifyRead\" - the user who sent the message has requested notification when a recipient first reads it \"NotifyUnread\" - the user who sent the message has requested notification when a recipient deletes it before reading or the Message object expires \"EverRead\" - the message has been read at least once      The field value (<Field value>) can take the following values:     For text fields - any string,     For date type fields - the string of \"d-MMM-yyy\" format, ex. \"10-Feb-2009\",     For flags (fields of boolean type) - either \"True\", or \"False\"              

### Return type

Task<[**ListResponseOfEmailDto**](ListResponseOfEmailDto.md)>

### Request Parameters
```csharp
new ListEmailModelsRequest(
    folder,
    firstAccount,
    queryString=queryString,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    recursive=recursive)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account | 
 **firstAccount** | **string**| Email account | 
 **queryString** | **string**| A MailQuery search string | [optional] 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **recursive** | **bool?**| Specifies that should message be searched in subfolders recursively | [optional] [default to false]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailthreads"></a>
# **ListEmailThreads**

```csharp
EmailThreadList ListEmailThreads(ListEmailThreadsRequest request)
```

Get message threads from folder. All messages are partly fetched (without email body and other fields)             

### Return type

[**EmailThreadList**](EmailThreadList.md)

### Request Parameters
```csharp
new ListEmailThreadsRequest(
    folder,
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    updateFolderCache=updateFolderCache,
    messagesCacheLimit=messagesCacheLimit)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account.              | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **updateFolderCache** | **bool?**| This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              | [optional] [default to true]
 **messagesCacheLimit** | **int?**| Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              | [optional] [default to 200]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="listemailthreads"></a>
# **ListEmailThreadsAsync**

```csharp
async Task<EmailThreadList> ListEmailThreadsAsync(ListEmailThreadsRequest request)
```

Get message threads from folder. All messages are partly fetched (without email body and other fields)             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailThreadList**](EmailThreadList.md)>

### Request Parameters
```csharp
new ListEmailThreadsRequest(
    folder,
    firstAccount,
    secondAccount=secondAccount,
    storage=storage,
    storageFolder=storageFolder,
    updateFolderCache=updateFolderCache,
    messagesCacheLimit=messagesCacheLimit)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folder** | **string**| A folder in email account.              | 
 **firstAccount** | **string**| Email account | 
 **secondAccount** | **string**| Additional email account (for example, firstAccount could be IMAP, and second one could be SMTP)              | [optional] 
 **storage** | **string**| Storage name where account file(s) located | [optional] 
 **storageFolder** | **string**| Folder in storage where account file(s) located | [optional] 
 **updateFolderCache** | **bool?**| This parameter is only used in accounts with CacheFile. If true - get new messages and update threads cache for given folder. If false, get only threads from cache without any calls to an email account              | [optional] [default to true]
 **messagesCacheLimit** | **int?**| Limit messages cache size if CacheFile is used. Ignored in accounts without limits support              | [optional] [default to 200]

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="moveemailmessage"></a>
# **MoveEmailMessage**

```csharp
void MoveEmailMessage(MoveEmailMessageRequest request)
```

Move message to another folder             

### Return type

void (empty response body)

### Request Parameters
```csharp
new MoveEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MoveEmailMessageRq**](MoveEmailMessageRq.md)| Email account, folder and message specifier | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="moveemailmessage"></a>
# **MoveEmailMessageAsync**

```csharp
async Task MoveEmailMessageAsync(MoveEmailMessageRequest request)
```

Move message to another folder             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MoveEmailMessageRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**MoveEmailMessageRq**](MoveEmailMessageRq.md)| Email account, folder and message specifier | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="moveemailthread"></a>
# **MoveEmailThread**

```csharp
void MoveEmailThread(MoveEmailThreadRequest request)
```

Move thread to another folder             

### Return type

void (empty response body)

### Request Parameters
```csharp
new MoveEmailThreadRequest(
    threadId,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **request** | [**MoveEmailThreadRq**](MoveEmailThreadRq.md)| Move thread request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="moveemailthread"></a>
# **MoveEmailThreadAsync**

```csharp
async Task MoveEmailThreadAsync(MoveEmailThreadRequest request)
```

Move thread to another folder             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MoveEmailThreadRequest(
    threadId,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread identifier | 
 **request** | [**MoveEmailThreadRq**](MoveEmailThreadRq.md)| Move thread request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefile"></a>
# **MoveFile**

```csharp
void MoveFile(MoveFileRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new MoveFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefile"></a>
# **MoveFileAsync**

```csharp
async Task MoveFileAsync(MoveFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MoveFileRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefolder"></a>
# **MoveFolder**

```csharp
void MoveFolder(MoveFolderRequest request)
```



### Return type

void (empty response body)

### Request Parameters
```csharp
new MoveFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="movefolder"></a>
# **MoveFolderAsync**

```csharp
async Task MoveFolderAsync(MoveFolderRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new MoveFolderRequest(
    srcPath,
    destPath,
    srcStorageName=srcStorageName,
    destStorageName=destStorageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**|  | 
 **destPath** | **string**|  | 
 **srcStorageName** | **string**|  | [optional] 
 **destStorageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="objectexists"></a>
# **ObjectExists**

```csharp
ObjectExist ObjectExists(ObjectExistsRequest request)
```



### Return type

[**ObjectExist**](ObjectExist.md)

### Request Parameters
```csharp
new ObjectExistsRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="objectexists"></a>
# **ObjectExistsAsync**

```csharp
async Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**ObjectExist**](ObjectExist.md)>

### Request Parameters
```csharp
new ObjectExistsRequest(
    path,
    storageName=storageName,
    versionId=versionId)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **storageName** | **string**|  | [optional] 
 **versionId** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savecalendarmodel"></a>
# **SaveCalendarModel**

```csharp
void SaveCalendarModel(SaveCalendarModelRequest request)
```

Save iCalendar             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveCalendarModelRequest(
    name,
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **rq** | [**StorageModelRqOfCalendarDto**](StorageModelRqOfCalendarDto.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savecalendarmodel"></a>
# **SaveCalendarModelAsync**

```csharp
async Task SaveCalendarModelAsync(SaveCalendarModelRequest request)
```

Save iCalendar             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveCalendarModelRequest(
    name,
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **rq** | [**StorageModelRqOfCalendarDto**](StorageModelRqOfCalendarDto.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savecontactmodel"></a>
# **SaveContactModel**

```csharp
void SaveContactModel(SaveContactModelRequest request)
```

Save contact.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveContactModelRequest(
    format,
    name,
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name. | 
 **rq** | [**StorageModelRqOfContactDto**](StorageModelRqOfContactDto.md)| Create contact request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savecontactmodel"></a>
# **SaveContactModelAsync**

```csharp
async Task SaveContactModelAsync(SaveContactModelRequest request)
```

Save contact.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveContactModelRequest(
    format,
    name,
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format. Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name. | 
 **rq** | [**StorageModelRqOfContactDto**](StorageModelRqOfContactDto.md)| Create contact request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="saveemailclientaccount"></a>
# **SaveEmailClientAccount**

```csharp
void SaveEmailClientAccount(SaveEmailClientAccountRequest request)
```

Create email client account file (*.account) with any of supported credentials             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveEmailClientAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StorageFileRqOfEmailClientAccount**](StorageFileRqOfEmailClientAccount.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="saveemailclientaccount"></a>
# **SaveEmailClientAccountAsync**

```csharp
async Task SaveEmailClientAccountAsync(SaveEmailClientAccountRequest request)
```

Create email client account file (*.account) with any of supported credentials             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveEmailClientAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StorageFileRqOfEmailClientAccount**](StorageFileRqOfEmailClientAccount.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="saveemailclientmultiaccount"></a>
# **SaveEmailClientMultiAccount**

```csharp
void SaveEmailClientMultiAccount(SaveEmailClientMultiAccountRequest request)
```

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveEmailClientMultiAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StorageFileRqOfEmailClientMultiAccount**](StorageFileRqOfEmailClientMultiAccount.md)| Email accounts information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="saveemailclientmultiaccount"></a>
# **SaveEmailClientMultiAccountAsync**

```csharp
async Task SaveEmailClientMultiAccountAsync(SaveEmailClientMultiAccountRequest request)
```

Create email client multi account file (*.multi.account). Will respond error if file extension is not \".multi.account\".             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveEmailClientMultiAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**StorageFileRqOfEmailClientMultiAccount**](StorageFileRqOfEmailClientMultiAccount.md)| Email accounts information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="saveemailmodel"></a>
# **SaveEmailModel**

```csharp
void SaveEmailModel(SaveEmailModelRequest request)
```

Save email document.             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveEmailModelRequest(
    format,
    name,
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **name** | **string**| Email document file name in storage. | 
 **rq** | [**StorageModelRqOfEmailDto**](StorageModelRqOfEmailDto.md)| Calendar properties update request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="saveemailmodel"></a>
# **SaveEmailModelAsync**

```csharp
async Task SaveEmailModelAsync(SaveEmailModelRequest request)
```

Save email document.             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveEmailModelRequest(
    format,
    name,
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| File format. Enum, available values: Eml, Msg, MsgUnicode, Mhtml, Html | 
 **name** | **string**| Email document file name in storage. | 
 **rq** | [**StorageModelRqOfEmailDto**](StorageModelRqOfEmailDto.md)| Calendar properties update request. | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savemailaccount"></a>
# **SaveMailAccount**

```csharp
void SaveMailAccount(SaveMailAccountRequest request)
```

Create email account file (*.account) with login/password authentication             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveMailAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveEmailAccountRequest**](SaveEmailAccountRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savemailaccount"></a>
# **SaveMailAccountAsync**

```csharp
async Task SaveMailAccountAsync(SaveMailAccountRequest request)
```

Create email account file (*.account) with login/password authentication             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveMailAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveEmailAccountRequest**](SaveEmailAccountRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savemailoauthaccount"></a>
# **SaveMailOAuthAccount**

```csharp
void SaveMailOAuthAccount(SaveMailOAuthAccountRequest request)
```

Create email account file (*.account) with OAuth             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SaveMailOAuthAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveOAuthEmailAccountRequest**](SaveOAuthEmailAccountRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="savemailoauthaccount"></a>
# **SaveMailOAuthAccountAsync**

```csharp
async Task SaveMailOAuthAccountAsync(SaveMailOAuthAccountRequest request)
```

Create email account file (*.account) with OAuth             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SaveMailOAuthAccountRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SaveOAuthEmailAccountRequest**](SaveOAuthEmailAccountRequest.md)| Email account information | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemail"></a>
# **SendEmail**

```csharp
void SendEmail(SendEmailRequest request)
```

Send an email from *.eml file located on storage             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SendEmailRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendEmailBaseRequest**](SendEmailBaseRequest.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemail"></a>
# **SendEmailAsync**

```csharp
async Task SendEmailAsync(SendEmailRequest request)
```

Send an email from *.eml file located on storage             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SendEmailRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendEmailBaseRequest**](SendEmailBaseRequest.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemailmime"></a>
# **SendEmailMime**

```csharp
void SendEmailMime(SendEmailMimeRequest request)
```

Send an email specified by MIME in request             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SendEmailMimeRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendEmailMimeBaseRequest**](SendEmailMimeBaseRequest.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemailmime"></a>
# **SendEmailMimeAsync**

```csharp
async Task SendEmailMimeAsync(SendEmailMimeRequest request)
```

Send an email specified by MIME in request             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SendEmailMimeRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SendEmailMimeBaseRequest**](SendEmailMimeBaseRequest.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemailmodel"></a>
# **SendEmailModel**

```csharp
void SendEmailModel(SendEmailModelRequest request)
```

Send an email specified by model in request             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SendEmailModelRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**SendEmailModelRq**](SendEmailModelRq.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="sendemailmodel"></a>
# **SendEmailModelAsync**

```csharp
async Task SendEmailModelAsync(SendEmailModelRequest request)
```

Send an email specified by model in request             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SendEmailModelRequest(
    rq)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rq** | [**SendEmailModelRq**](SendEmailModelRq.md)| Send email request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailproperty"></a>
# **SetEmailProperty**

```csharp
EmailPropertyResponse SetEmailProperty(SetEmailPropertyRequest request)
```

Set email document property value             

### Return type

[**EmailPropertyResponse**](EmailPropertyResponse.md)

### Request Parameters
```csharp
new SetEmailPropertyRequest(
    propertyName,
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| A property name that should be changed | 
 **fileName** | **string**| Email document file name | 
 **request** | [**SetEmailPropertyRequest**](SetEmailPropertyRequest.md)| A property that should be changed and optional Storage info to specify where the file located              | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailproperty"></a>
# **SetEmailPropertyAsync**

```csharp
async Task<EmailPropertyResponse> SetEmailPropertyAsync(SetEmailPropertyRequest request)
```

Set email document property value             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**EmailPropertyResponse**](EmailPropertyResponse.md)>

### Request Parameters
```csharp
new SetEmailPropertyRequest(
    propertyName,
    fileName,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **propertyName** | **string**| A property name that should be changed | 
 **fileName** | **string**| Email document file name | 
 **request** | [**SetEmailPropertyRequest**](SetEmailPropertyRequest.md)| A property that should be changed and optional Storage info to specify where the file located              | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailreadflag"></a>
# **SetEmailReadFlag**

```csharp
void SetEmailReadFlag(SetEmailReadFlagRequest request)
```

Sets \"Message is read\" flag             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SetEmailReadFlagRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetMessageReadFlagAccountBaseRequest**](SetMessageReadFlagAccountBaseRequest.md)| Message is read request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailreadflag"></a>
# **SetEmailReadFlagAsync**

```csharp
async Task SetEmailReadFlagAsync(SetEmailReadFlagRequest request)
```

Sets \"Message is read\" flag             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SetEmailReadFlagRequest(
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetMessageReadFlagAccountBaseRequest**](SetMessageReadFlagAccountBaseRequest.md)| Message is read request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailthreadreadflag"></a>
# **SetEmailThreadReadFlag**

```csharp
void SetEmailThreadReadFlag(SetEmailThreadReadFlagRequest request)
```

Mark all messages in thread as read or unread             

### Return type

void (empty response body)

### Request Parameters
```csharp
new SetEmailThreadReadFlagRequest(
    threadId,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread id | 
 **request** | [**EmailThreadReadFlagRq**](EmailThreadReadFlagRq.md)| Email account specifier and IsRead flag | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="setemailthreadreadflag"></a>
# **SetEmailThreadReadFlagAsync**

```csharp
async Task SetEmailThreadReadFlagAsync(SetEmailThreadReadFlagRequest request)
```

Mark all messages in thread as read or unread             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new SetEmailThreadReadFlagRequest(
    threadId,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **threadId** | **string**| Thread id | 
 **request** | [**EmailThreadReadFlagRq**](EmailThreadReadFlagRq.md)| Email account specifier and IsRead flag | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="storageexists"></a>
# **StorageExists**

```csharp
StorageExist StorageExists(StorageExistsRequest request)
```



### Return type

[**StorageExist**](StorageExist.md)

### Request Parameters
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="storageexists"></a>
# **StorageExistsAsync**

```csharp
async Task<StorageExist> StorageExistsAsync(StorageExistsRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**StorageExist**](StorageExist.md)>

### Request Parameters
```csharp
new StorageExistsRequest(
    storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**|  | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecalendarproperties"></a>
# **UpdateCalendarProperties**

```csharp
void UpdateCalendarProperties(UpdateCalendarPropertiesRequest request)
```

Update calendar file properties             

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateCalendarPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecalendarproperties"></a>
# **UpdateCalendarPropertiesAsync**

```csharp
async Task UpdateCalendarPropertiesAsync(UpdateCalendarPropertiesRequest request)
```

Update calendar file properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new UpdateCalendarPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| iCalendar file name in storage | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Calendar properties update request | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecontactproperties"></a>
# **UpdateContactProperties**

```csharp
void UpdateContactProperties(UpdateContactPropertiesRequest request)
```

Update contact document properties             

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateContactPropertiesRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatecontactproperties"></a>
# **UpdateContactPropertiesAsync**

```csharp
async Task UpdateContactPropertiesAsync(UpdateContactPropertiesRequest request)
```

Update contact document properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new UpdateContactPropertiesRequest(
    format,
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Contact document format Enum, available values: VCard, WebDav, Msg | 
 **name** | **string**| Contact document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatemapiproperties"></a>
# **UpdateMapiProperties**

```csharp
void UpdateMapiProperties(UpdateMapiPropertiesRequest request)
```

Update document properties             

### Return type

void (empty response body)

### Request Parameters
```csharp
new UpdateMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="updatemapiproperties"></a>
# **UpdateMapiPropertiesAsync**

```csharp
async Task UpdateMapiPropertiesAsync(UpdateMapiPropertiesRequest request)
```

Update document properties             

Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task (empty response body)

### Request Parameters
```csharp
new UpdateMapiPropertiesRequest(
    name,
    request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Document file name | 
 **request** | [**HierarchicalObjectRequest**](HierarchicalObjectRequest.md)| Properties that should be updated/added | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="uploadfile"></a>
# **UploadFile**

```csharp
FilesUploadResult UploadFile(UploadFileRequest request)
```



### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### Request Parameters
```csharp
new UploadFileRequest(
    path,
    file,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

<a name="uploadfile"></a>
# **UploadFileAsync**

```csharp
async Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request)
```



Performs operation asynchronously. Not available on .NETFramework v2.0

### Return type

Task<[**FilesUploadResult**](FilesUploadResult.md)>

### Request Parameters
```csharp
new UploadFileRequest(
    path,
    file,
    storageName=storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**|  | [optional] 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

