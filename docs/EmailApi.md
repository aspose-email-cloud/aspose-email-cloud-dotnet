# Aspose.Email.Cloud.Sdk.EmailApi

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
 **request** | [**CreateEmailRequest**](CreateEmailRequest.md)| An email document and optional Storage info to specify where the file should be located | 

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

<a name="getemailattachment"></a>
# **GetEmailAttachment**

```csharp
System.IO.Stream GetEmailAttachment(GetEmailAttachmentRequest request)
```

Get email attachment by name

### Return type

**System.IO.Stream**

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
 **request** | [**SetEmailPropertyRequest**](SetEmailPropertyRequest.md)| A property that should be changed and optional Storage info to specify             where the file located | 

[[Back to top]](#) [[Back to API list]](README.md#documentation-for-api-endpoints) [[Back to Model list]](README.md#documentation-for-models) [[Back to README]](README.md)

