# Aspose.Email.Cloud.Sdk.DisposableEmailApi

<a name="IsDisposable"></a>
# IsDisposable

Check email address is disposable             

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DisposableEmailIsDisposableRequest
{ 
    Address = "example@mailcatch.com"
};

// Call method:
var result = Api.DisposableEmail.IsDisposable(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| An email address to check | 

### Return type

[**ValueTOfBoolean**](ValueTOfBoolean.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="IsDisposableAsync"></a>
# IsDisposableAsync

Check email address is disposable             

Performs operation asynchronously. Not available on .NETFramework v2.0

<details>
    <summary>Method call example:</summary>

```csharp
// Prepare parameters:
var request = new DisposableEmailIsDisposableRequest
{ 
    Address = "example@mailcatch.com"
};

// Call method:
var result = await Api.DisposableEmail.IsDisposableAsync(request);

// Result example:
result = ;
```

</details>

### request Parameter


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| An email address to check | 

### Return type

[**ValueTOfBoolean**](ValueTOfBoolean.md)

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
