# Aspose.Email.Cloud.Sdk.DisposableEmailApi

<a name="IsDisposable"></a>
## IsDisposable

Check email address is disposable             

Returns: true if address is disposable

Method call example:
```csharp
var result = Api.DisposableEmail.IsDisposable(request);
```

### request Parameter

IsDisposable method request.

See parameter model documentation at [DisposableEmailIsDisposableRequest](DisposableEmailIsDisposableRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DisposableEmailIsDisposableRequest
{ 
    Address = "example@mailcatch.com"
};
```

</details>

### Result

*Returns:* true if address is disposable

*Return type:* [**ValueTOfBoolean**](ValueTOfBoolean.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="IsDisposableAsync"></a>
## IsDisposableAsync

Check email address is disposable             

Performs operation asynchronously. Not available on .NETFramework v2.0

Returns: true if address is disposable

Method call example:
```csharp
var result = await Api.DisposableEmail.IsDisposableAsync(request);
```

### request Parameter

IsDisposableAsync method request.

See parameter model documentation at [DisposableEmailIsDisposableRequest](DisposableEmailIsDisposableRequest.md)

<details>
    <summary>Parameter initialization example:</summary>

```csharp
var request = new DisposableEmailIsDisposableRequest
{ 
    Address = "example@mailcatch.com"
};
```

</details>

### Result

*Returns:* true if address is disposable

*Return type:* [**ValueTOfBoolean**](ValueTOfBoolean.md)

<details>
    <summary>Result example</summary>

```csharp
result = ;
```

</details>

### Complete example:

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

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
