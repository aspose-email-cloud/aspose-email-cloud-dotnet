# Reference documentation for Aspose.Email Cloud API

`EmailCloud` is the main API class. It provides an access to all of Aspose.Email Cloud functions.
`ClientSecret` and `ClientId` credentials should be obtained from [dashboard](https://dashboard.aspose.cloud/#/) to use `EmailCloud`:

```csharp
var clientSecret = "Your client secret";
var clientId = "Your client id";

var api = new EmailCloud(clientSecret, clientId);
```

All Aspose.Email Cloud functions are divided into groups and represented as `EmailCloud` fields:

API | Description
--- | -----------
[EmailCloud.**Mapi**](MapiGroup.md) | MAPI operations.
[EmailCloud.**Client**](ClientGroup.md) | Builtin Email client operations.
[EmailCloud.**Ai**](AiGroup.md) | AI powered operations.
[EmailCloud.**CloudStorage**](CloudStorageGroup.md) | Cloud file storage operations.
[EmailCloud.**Calendar**](CalendarApi_list.md) | iCalendar document operations.
[EmailCloud.**Contact**](ContactApi_list.md) | Contact document operations. Supported formats: VCard, MSG, WebDav
[EmailCloud.**Email**](EmailApi_list.md) | Email document (*.eml) operations.
[EmailCloud.**DisposableEmail**](DisposableEmailApi_list.md) | Check email address is disposable operations
[EmailCloud.**EmailConfig**](EmailConfigApi_list.md) | Email server configuration discovery.


List of all available models is available in [Models.md](Models.md) file.