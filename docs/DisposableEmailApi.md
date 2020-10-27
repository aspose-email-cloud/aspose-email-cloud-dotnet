# DisposableEmailApi (EmailCloud.DisposableEmail)

Check email address is disposable operations

<a name="IsDisposable"></a>
## IsDisposable
**Descrption:** Check email address is disposable             


**Returns:** true if address is disposable

**Method call example:**
```csharp
var result = api.DisposableEmail.IsDisposable(request);
```

### Parameter: *request*

**Description:** IsDisposable method request.

**See also** parameter model documentation at [**DisposableEmailIsDisposableRequest**](DisposableEmailIsDisposableRequest.md).

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

**Description:** true if address is disposable

**Return type:** [**ValueTOfBoolean**](ValueTOfBoolean.md)

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
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new DisposableEmailIsDisposableRequest
{ 
    Address = "example@mailcatch.com"
};

// Call method:
var result = api.DisposableEmail.IsDisposable(request);

// Result example:
result = ;
```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)

<a name="IsDisposableAsync"></a>
## IsDisposableAsync

**Description:** Check email address is disposable             

Performs operation asynchronously. Not available on .NETFramework v2.0


**Returns:** true if address is disposable

**Method call example:**
```csharp
var result = await api.DisposableEmail.IsDisposableAsync(request);
```

### Parameter: *request*

**Description:** IsDisposableAsync method request.

**See also** parameter model documentation at [**DisposableEmailIsDisposableRequest**](DisposableEmailIsDisposableRequest.md).

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

**Returns:** true if address is disposable

**Return type:** [**ValueTOfBoolean**](ValueTOfBoolean.md)

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
var api = new EmailCloud(appKey, appSid);

// Prepare parameters:
var request = new DisposableEmailIsDisposableRequest
{ 
    Address = "example@mailcatch.com"
};

// Call method:
var result = await api.DisposableEmail.IsDisposableAsync(request);

result = ;

```

</details>

[[Back to top]](#) [[Back to Model list]](Models.md) [[Back to README]](README.md)
