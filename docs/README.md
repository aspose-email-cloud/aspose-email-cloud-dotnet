## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*EmailApi* | [**AddCalendarAttachment**](EmailApi.md#addcalendarattachment) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file             
*EmailApi* | [**AddCalendarAttachmentAsync**](EmailApi.md#addcalendarattachmentasync) | **PUT** /email/Calendar/{name}/attachments/{attachment} | Adds an attachment to iCalendar file             . Not available on .NETFramework v2.0
*EmailApi* | [**AddContactAttachment**](EmailApi.md#addcontactattachment) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document             
*EmailApi* | [**AddContactAttachmentAsync**](EmailApi.md#addcontactattachmentasync) | **PUT** /email/Contact/{format}/{name}/attachments/{attachment} | Add attachment to contact document             . Not available on .NETFramework v2.0
*EmailApi* | [**AddEmailAttachment**](EmailApi.md#addemailattachment) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document             
*EmailApi* | [**AddEmailAttachmentAsync**](EmailApi.md#addemailattachmentasync) | **POST** /email/{fileName}/attachments/{attachmentName} | Adds an attachment to Email document             . Not available on .NETFramework v2.0
*EmailApi* | [**AddMapiAttachment**](EmailApi.md#addmapiattachment) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document             
*EmailApi* | [**AddMapiAttachmentAsync**](EmailApi.md#addmapiattachmentasync) | **PUT** /email/Mapi/{name}/attachments/{attachment} | Add attachment to document             . Not available on .NETFramework v2.0
*EmailApi* | [**AiBcrOcr**](EmailApi.md#aibcrocr) | **POST** /email/AiBcr/ocr | Ocr images             
*EmailApi* | [**AiBcrOcrAsync**](EmailApi.md#aibcrocrasync) | **POST** /email/AiBcr/ocr | Ocr images             . Not available on .NETFramework v2.0
*EmailApi* | [**AiBcrOcrStorage**](EmailApi.md#aibcrocrstorage) | **POST** /email/AiBcr/ocr-storage | Ocr images from storage             
*EmailApi* | [**AiBcrOcrStorageAsync**](EmailApi.md#aibcrocrstorageasync) | **POST** /email/AiBcr/ocr-storage | Ocr images from storage             . Not available on .NETFramework v2.0
*EmailApi* | [**AiBcrParse**](EmailApi.md#aibcrparse) | **POST** /email/AiBcr/parse | Parse images to vCard properties             
*EmailApi* | [**AiBcrParseAsync**](EmailApi.md#aibcrparseasync) | **POST** /email/AiBcr/parse | Parse images to vCard properties             . Not available on .NETFramework v2.0
*EmailApi* | [**AiBcrParseModel**](EmailApi.md#aibcrparsemodel) | **POST** /email/AiBcr/parse-model | Parse images to vCard document models             
*EmailApi* | [**AiBcrParseModelAsync**](EmailApi.md#aibcrparsemodelasync) | **POST** /email/AiBcr/parse-model | Parse images to vCard document models             . Not available on .NETFramework v2.0
*EmailApi* | [**AiBcrParseOcrDataModel**](EmailApi.md#aibcrparseocrdatamodel) | **POST** /email/AiBcr/parse-ocr-data-model | Parse OCR data to vCard document models             
*EmailApi* | [**AiBcrParseOcrDataModelAsync**](EmailApi.md#aibcrparseocrdatamodelasync) | **POST** /email/AiBcr/parse-ocr-data-model | Parse OCR data to vCard document models             . Not available on .NETFramework v2.0
*EmailApi* | [**AiBcrParseStorage**](EmailApi.md#aibcrparsestorage) | **POST** /email/AiBcr/parse-storage | Parse images from storage to vCard files             
*EmailApi* | [**AiBcrParseStorageAsync**](EmailApi.md#aibcrparsestorageasync) | **POST** /email/AiBcr/parse-storage | Parse images from storage to vCard files             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameComplete**](EmailApi.md#ainamecomplete) | **GET** /email/AiName/complete | The call proposes k most probable names for given starting characters             
*EmailApi* | [**AiNameCompleteAsync**](EmailApi.md#ainamecompleteasync) | **GET** /email/AiName/complete | The call proposes k most probable names for given starting characters             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameExpand**](EmailApi.md#ainameexpand) | **GET** /email/AiName/expand | Expands a person&#39;s name into a list of possible alternatives using options for expanding instructions             
*EmailApi* | [**AiNameExpandAsync**](EmailApi.md#ainameexpandasync) | **GET** /email/AiName/expand | Expands a person&#39;s name into a list of possible alternatives using options for expanding instructions             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameExpandParsed**](EmailApi.md#ainameexpandparsed) | **POST** /email/AiName/expand-parsed | Expands a person&#39;s parsed name into a list of possible alternatives using options for expanding instructions             
*EmailApi* | [**AiNameExpandParsedAsync**](EmailApi.md#ainameexpandparsedasync) | **POST** /email/AiName/expand-parsed | Expands a person&#39;s parsed name into a list of possible alternatives using options for expanding instructions             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameFormat**](EmailApi.md#ainameformat) | **GET** /email/AiName/format | Formats a person&#39;s name in correct case and name order using options for formatting instructions             
*EmailApi* | [**AiNameFormatAsync**](EmailApi.md#ainameformatasync) | **GET** /email/AiName/format | Formats a person&#39;s name in correct case and name order using options for formatting instructions             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameFormatParsed**](EmailApi.md#ainameformatparsed) | **POST** /email/AiName/format-parsed | Formats a person&#39;s parsed name in correct case and name order using options for formatting instructions             
*EmailApi* | [**AiNameFormatParsedAsync**](EmailApi.md#ainameformatparsedasync) | **POST** /email/AiName/format-parsed | Formats a person&#39;s parsed name in correct case and name order using options for formatting instructions             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameGenderize**](EmailApi.md#ainamegenderize) | **GET** /email/AiName/genderize | Detect person&#39;s gender from name string             
*EmailApi* | [**AiNameGenderizeAsync**](EmailApi.md#ainamegenderizeasync) | **GET** /email/AiName/genderize | Detect person&#39;s gender from name string             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameGenderizeParsed**](EmailApi.md#ainamegenderizeparsed) | **POST** /email/AiName/genderize-parsed | Detect person&#39;s gender from parsed name             
*EmailApi* | [**AiNameGenderizeParsedAsync**](EmailApi.md#ainamegenderizeparsedasync) | **POST** /email/AiName/genderize-parsed | Detect person&#39;s gender from parsed name             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameMatch**](EmailApi.md#ainamematch) | **GET** /email/AiName/match | Compare people&#39;s names. Uses options for comparing instructions             
*EmailApi* | [**AiNameMatchAsync**](EmailApi.md#ainamematchasync) | **GET** /email/AiName/match | Compare people&#39;s names. Uses options for comparing instructions             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameMatchParsed**](EmailApi.md#ainamematchparsed) | **POST** /email/AiName/match-parsed | Compare people&#39;s parsed names and attributes. Uses options for comparing instructions             
*EmailApi* | [**AiNameMatchParsedAsync**](EmailApi.md#ainamematchparsedasync) | **POST** /email/AiName/match-parsed | Compare people&#39;s parsed names and attributes. Uses options for comparing instructions             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameParse**](EmailApi.md#ainameparse) | **GET** /email/AiName/parse | Parse name to components             
*EmailApi* | [**AiNameParseAsync**](EmailApi.md#ainameparseasync) | **GET** /email/AiName/parse | Parse name to components             . Not available on .NETFramework v2.0
*EmailApi* | [**AiNameParseEmailAddress**](EmailApi.md#ainameparseemailaddress) | **GET** /email/AiName/parse-email-address | Parse person&#39;s name out of an email address             
*EmailApi* | [**AiNameParseEmailAddressAsync**](EmailApi.md#ainameparseemailaddressasync) | **GET** /email/AiName/parse-email-address | Parse person&#39;s name out of an email address             . Not available on .NETFramework v2.0
*EmailApi* | [**AppendEmailMessage**](EmailApi.md#appendemailmessage) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account             
*EmailApi* | [**AppendEmailMessageAsync**](EmailApi.md#appendemailmessageasync) | **PUT** /email/client/Append | Adds an email from *.eml file to specified folder in email account             . Not available on .NETFramework v2.0
*EmailApi* | [**AppendEmailModelMessage**](EmailApi.md#appendemailmodelmessage) | **PUT** /email/client/AppendModel | Adds an email from model to specified folder in email account             
*EmailApi* | [**AppendEmailModelMessageAsync**](EmailApi.md#appendemailmodelmessageasync) | **PUT** /email/client/AppendModel | Adds an email from model to specified folder in email account             . Not available on .NETFramework v2.0
*EmailApi* | [**AppendMimeMessage**](EmailApi.md#appendmimemessage) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account             
*EmailApi* | [**AppendMimeMessageAsync**](EmailApi.md#appendmimemessageasync) | **PUT** /email/client/AppendMime | Adds an email from MIME to specified folder in email account             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertCalendar**](EmailApi.md#convertcalendar) | **PUT** /email/CalendarModel/convert/{format} | Converts calendar document to specified format and returns as file             
*EmailApi* | [**ConvertCalendarAsync**](EmailApi.md#convertcalendarasync) | **PUT** /email/CalendarModel/convert/{format} | Converts calendar document to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertCalendarModelToAlternate**](EmailApi.md#convertcalendarmodeltoalternate) | **PUT** /email/CalendarModel/as-alternate | Convert iCalendar to AlternateView             
*EmailApi* | [**ConvertCalendarModelToAlternateAsync**](EmailApi.md#convertcalendarmodeltoalternateasync) | **PUT** /email/CalendarModel/as-alternate | Convert iCalendar to AlternateView             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertCalendarModelToFile**](EmailApi.md#convertcalendarmodeltofile) | **PUT** /email/CalendarModel/model-as-file/{format} | Converts calendar model to specified format and returns as file             
*EmailApi* | [**ConvertCalendarModelToFileAsync**](EmailApi.md#convertcalendarmodeltofileasync) | **PUT** /email/CalendarModel/model-as-file/{format} | Converts calendar model to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertCalendarModelToMapiModel**](EmailApi.md#convertcalendarmodeltomapimodel) | **PUT** /email/CalendarModel/model-as-mapi-model | Convert CalendarDto to MapiCalendarDto             
*EmailApi* | [**ConvertCalendarModelToMapiModelAsync**](EmailApi.md#convertcalendarmodeltomapimodelasync) | **PUT** /email/CalendarModel/model-as-mapi-model | Convert CalendarDto to MapiCalendarDto             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertContact**](EmailApi.md#convertcontact) | **PUT** /email/ContactModel/{format}/convert/{destinationFormat} | Converts contact document to specified format and returns as file             
*EmailApi* | [**ConvertContactAsync**](EmailApi.md#convertcontactasync) | **PUT** /email/ContactModel/{format}/convert/{destinationFormat} | Converts contact document to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertContactModelToFile**](EmailApi.md#convertcontactmodeltofile) | **PUT** /email/ContactModel/model-as-file/{destinationFormat} | Converts contact model to specified format and returns as file             
*EmailApi* | [**ConvertContactModelToFileAsync**](EmailApi.md#convertcontactmodeltofileasync) | **PUT** /email/ContactModel/model-as-file/{destinationFormat} | Converts contact model to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertContactModelToMapiModel**](EmailApi.md#convertcontactmodeltomapimodel) | **PUT** /email/ContactModel/model-as-mapi-model | Convert contact model to MAPI model contact representation             
*EmailApi* | [**ConvertContactModelToMapiModelAsync**](EmailApi.md#convertcontactmodeltomapimodelasync) | **PUT** /email/ContactModel/model-as-mapi-model | Convert contact model to MAPI model contact representation             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertEmail**](EmailApi.md#convertemail) | **PUT** /email/convert/{format} | Converts email document to specified format and returns as file             
*EmailApi* | [**ConvertEmailAsync**](EmailApi.md#convertemailasync) | **PUT** /email/convert/{format} | Converts email document to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertEmailModelToFile**](EmailApi.md#convertemailmodeltofile) | **PUT** /email/model/model-as-file/{destinationFormat} | Converts Email model to specified format and returns as file             
*EmailApi* | [**ConvertEmailModelToFileAsync**](EmailApi.md#convertemailmodeltofileasync) | **PUT** /email/model/model-as-file/{destinationFormat} | Converts Email model to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertEmailModelToMapiModel**](EmailApi.md#convertemailmodeltomapimodel) | **PUT** /email/model/model-as-mapi-model | Converts Email model to MAPI model message representation             
*EmailApi* | [**ConvertEmailModelToMapiModelAsync**](EmailApi.md#convertemailmodeltomapimodelasync) | **PUT** /email/model/model-as-mapi-model | Converts Email model to MAPI model message representation             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertMapiCalendarModelToCalendarModel**](EmailApi.md#convertmapicalendarmodeltocalendarmodel) | **PUT** /email/MapiCalendar/model-as-calendar-model | Converts MAPI calendar model to CalendarDto model             
*EmailApi* | [**ConvertMapiCalendarModelToCalendarModelAsync**](EmailApi.md#convertmapicalendarmodeltocalendarmodelasync) | **PUT** /email/MapiCalendar/model-as-calendar-model | Converts MAPI calendar model to CalendarDto model             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertMapiCalendarModelToFile**](EmailApi.md#convertmapicalendarmodeltofile) | **PUT** /email/MapiCalendar/model-as-file/{destinationFormat} | Converts MAPI calendar model to specified format and returns as file             
*EmailApi* | [**ConvertMapiCalendarModelToFileAsync**](EmailApi.md#convertmapicalendarmodeltofileasync) | **PUT** /email/MapiCalendar/model-as-file/{destinationFormat} | Converts MAPI calendar model to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertMapiContactModelToContactModel**](EmailApi.md#convertmapicontactmodeltocontactmodel) | **PUT** /email/MapiContact/model-as-contact-model | Converts MAPI contact model to Contact model             
*EmailApi* | [**ConvertMapiContactModelToContactModelAsync**](EmailApi.md#convertmapicontactmodeltocontactmodelasync) | **PUT** /email/MapiContact/model-as-contact-model | Converts MAPI contact model to Contact model             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertMapiContactModelToFile**](EmailApi.md#convertmapicontactmodeltofile) | **PUT** /email/MapiContact/model-as-file/{destinationFormat} | Converts MAPI contact model to specified format and returns as file             
*EmailApi* | [**ConvertMapiContactModelToFileAsync**](EmailApi.md#convertmapicontactmodeltofileasync) | **PUT** /email/MapiContact/model-as-file/{destinationFormat} | Converts MAPI contact model to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertMapiMessageModelToEmailModel**](EmailApi.md#convertmapimessagemodeltoemailmodel) | **PUT** /email/MapiMessage/model-as-email-model | Converts MAPI message model to EmailDto model             
*EmailApi* | [**ConvertMapiMessageModelToEmailModelAsync**](EmailApi.md#convertmapimessagemodeltoemailmodelasync) | **PUT** /email/MapiMessage/model-as-email-model | Converts MAPI message model to EmailDto model             . Not available on .NETFramework v2.0
*EmailApi* | [**ConvertMapiMessageModelToFile**](EmailApi.md#convertmapimessagemodeltofile) | **PUT** /email/MapiMessage/model-as-file/{destinationFormat} | Converts MAPI message model to specified format and returns as file             
*EmailApi* | [**ConvertMapiMessageModelToFileAsync**](EmailApi.md#convertmapimessagemodeltofileasync) | **PUT** /email/MapiMessage/model-as-file/{destinationFormat} | Converts MAPI message model to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**CopyFile**](EmailApi.md#copyfile) | **PUT** /email/storage/file/copy/{srcPath} | 
*EmailApi* | [**CopyFileAsync**](EmailApi.md#copyfileasync) | **PUT** /email/storage/file/copy/{srcPath} | 
*EmailApi* | [**CopyFolder**](EmailApi.md#copyfolder) | **PUT** /email/storage/folder/copy/{srcPath} | 
*EmailApi* | [**CopyFolderAsync**](EmailApi.md#copyfolderasync) | **PUT** /email/storage/folder/copy/{srcPath} | 
*EmailApi* | [**CreateCalendar**](EmailApi.md#createcalendar) | **PUT** /email/Calendar/{name} | Create calendar file             
*EmailApi* | [**CreateCalendarAsync**](EmailApi.md#createcalendarasync) | **PUT** /email/Calendar/{name} | Create calendar file             . Not available on .NETFramework v2.0
*EmailApi* | [**CreateContact**](EmailApi.md#createcontact) | **PUT** /email/Contact/{format}/{name} | Create contact document             
*EmailApi* | [**CreateContactAsync**](EmailApi.md#createcontactasync) | **PUT** /email/Contact/{format}/{name} | Create contact document             . Not available on .NETFramework v2.0
*EmailApi* | [**CreateEmail**](EmailApi.md#createemail) | **PUT** /email/{fileName} | Create an email document             
*EmailApi* | [**CreateEmailAsync**](EmailApi.md#createemailasync) | **PUT** /email/{fileName} | Create an email document             . Not available on .NETFramework v2.0
*EmailApi* | [**CreateEmailFolder**](EmailApi.md#createemailfolder) | **PUT** /email/client/CreateFolder | Create new folder in email account             
*EmailApi* | [**CreateEmailFolderAsync**](EmailApi.md#createemailfolderasync) | **PUT** /email/client/CreateFolder | Create new folder in email account             . Not available on .NETFramework v2.0
*EmailApi* | [**CreateFolder**](EmailApi.md#createfolder) | **PUT** /email/storage/folder/{path} | 
*EmailApi* | [**CreateFolderAsync**](EmailApi.md#createfolderasync) | **PUT** /email/storage/folder/{path} | 
*EmailApi* | [**CreateMapi**](EmailApi.md#createmapi) | **PUT** /email/Mapi/{name} | Create new document             
*EmailApi* | [**CreateMapiAsync**](EmailApi.md#createmapiasync) | **PUT** /email/Mapi/{name} | Create new document             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteCalendarProperty**](EmailApi.md#deletecalendarproperty) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}             
*EmailApi* | [**DeleteCalendarPropertyAsync**](EmailApi.md#deletecalendarpropertyasync) | **DELETE** /email/Calendar/{name}/properties/{memberName}/{index} | Deletes indexed property by index and name. To delete Reminder attachment, use path ReminderAttachment/{ReminderIndex}/{AttachmentIndex}             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteContactProperty**](EmailApi.md#deletecontactproperty) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list             
*EmailApi* | [**DeleteContactPropertyAsync**](EmailApi.md#deletecontactpropertyasync) | **DELETE** /email/Contact/{format}/{name}/properties/{memberName}/{index} | Delete property from indexed property list             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteEmailFolder**](EmailApi.md#deleteemailfolder) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account             
*EmailApi* | [**DeleteEmailFolderAsync**](EmailApi.md#deleteemailfolderasync) | **DELETE** /email/client/DeleteFolder | Delete a folder in email account             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteEmailMessage**](EmailApi.md#deleteemailmessage) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id             
*EmailApi* | [**DeleteEmailMessageAsync**](EmailApi.md#deleteemailmessageasync) | **DELETE** /email/client/DeleteMessage | Delete message from email account by id             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteEmailThread**](EmailApi.md#deleteemailthread) | **DELETE** /email/client/threads/{threadId} | Delete thread by id. All messages from thread will also be deleted             
*EmailApi* | [**DeleteEmailThreadAsync**](EmailApi.md#deleteemailthreadasync) | **DELETE** /email/client/threads/{threadId} | Delete thread by id. All messages from thread will also be deleted             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteFile**](EmailApi.md#deletefile) | **DELETE** /email/storage/file/{path} | 
*EmailApi* | [**DeleteFileAsync**](EmailApi.md#deletefileasync) | **DELETE** /email/storage/file/{path} | 
*EmailApi* | [**DeleteFolder**](EmailApi.md#deletefolder) | **DELETE** /email/storage/folder/{path} | 
*EmailApi* | [**DeleteFolderAsync**](EmailApi.md#deletefolderasync) | **DELETE** /email/storage/folder/{path} | 
*EmailApi* | [**DeleteMapiAttachment**](EmailApi.md#deletemapiattachment) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document             
*EmailApi* | [**DeleteMapiAttachmentAsync**](EmailApi.md#deletemapiattachmentasync) | **DELETE** /email/Mapi/{name}/attachments/{attachment} | Remove attachment from document             . Not available on .NETFramework v2.0
*EmailApi* | [**DeleteMapiProperties**](EmailApi.md#deletemapiproperties) | **DELETE** /email/Mapi/{name}/properties | Delete document properties             
*EmailApi* | [**DeleteMapiPropertiesAsync**](EmailApi.md#deletemapipropertiesasync) | **DELETE** /email/Mapi/{name}/properties | Delete document properties             . Not available on .NETFramework v2.0
*EmailApi* | [**DiscoverEmailConfig**](EmailApi.md#discoveremailconfig) | **GET** /email/config/discover | Discover email accounts by email address. Does not validate discovered accounts.             
*EmailApi* | [**DiscoverEmailConfigAsync**](EmailApi.md#discoveremailconfigasync) | **GET** /email/config/discover | Discover email accounts by email address. Does not validate discovered accounts.             . Not available on .NETFramework v2.0
*EmailApi* | [**DiscoverEmailConfigOauth**](EmailApi.md#discoveremailconfigoauth) | **POST** /email/config/discover/oauth | Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             
*EmailApi* | [**DiscoverEmailConfigOauthAsync**](EmailApi.md#discoveremailconfigoauthasync) | **POST** /email/config/discover/oauth | Discover email accounts by email address. Validates discovered accounts using OAuth 2.0.             . Not available on .NETFramework v2.0
*EmailApi* | [**DiscoverEmailConfigPassword**](EmailApi.md#discoveremailconfigpassword) | **POST** /email/config/discover/password | Discover email accounts by email address. Validates discovered accounts using login and password.             
*EmailApi* | [**DiscoverEmailConfigPasswordAsync**](EmailApi.md#discoveremailconfigpasswordasync) | **POST** /email/config/discover/password | Discover email accounts by email address. Validates discovered accounts using login and password.             . Not available on .NETFramework v2.0
*EmailApi* | [**DownloadFile**](EmailApi.md#downloadfile) | **GET** /email/storage/file/{path} | 
*EmailApi* | [**DownloadFileAsync**](EmailApi.md#downloadfileasync) | **GET** /email/storage/file/{path} | 
*EmailApi* | [**FetchEmailMessage**](EmailApi.md#fetchemailmessage) | **GET** /email/client/Fetch | Fetch message mime from email account             
*EmailApi* | [**FetchEmailMessageAsync**](EmailApi.md#fetchemailmessageasync) | **GET** /email/client/Fetch | Fetch message mime from email account             . Not available on .NETFramework v2.0
*EmailApi* | [**FetchEmailModel**](EmailApi.md#fetchemailmodel) | **GET** /email/client/FetchModel | Fetch message model from email account             
*EmailApi* | [**FetchEmailModelAsync**](EmailApi.md#fetchemailmodelasync) | **GET** /email/client/FetchModel | Fetch message model from email account             . Not available on .NETFramework v2.0
*EmailApi* | [**FetchEmailThreadMessages**](EmailApi.md#fetchemailthreadmessages) | **GET** /email/client/threads/{threadId}/messages | Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             
*EmailApi* | [**FetchEmailThreadMessagesAsync**](EmailApi.md#fetchemailthreadmessagesasync) | **GET** /email/client/threads/{threadId}/messages | Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendar**](EmailApi.md#getcalendar) | **GET** /email/Calendar/{name}/properties | Get calendar file properties             
*EmailApi* | [**GetCalendarAsync**](EmailApi.md#getcalendarasync) | **GET** /email/Calendar/{name}/properties | Get calendar file properties             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarAsFile**](EmailApi.md#getcalendarasfile) | **GET** /email/CalendarModel/{fileName}/as-file/{format} | Converts calendar document from storage to specified format and returns as file             
*EmailApi* | [**GetCalendarAsFileAsync**](EmailApi.md#getcalendarasfileasync) | **GET** /email/CalendarModel/{fileName}/as-file/{format} | Converts calendar document from storage to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarAttachment**](EmailApi.md#getcalendarattachment) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name             
*EmailApi* | [**GetCalendarAttachmentAsync**](EmailApi.md#getcalendarattachmentasync) | **GET** /email/Calendar/{name}/attachments/{attachment} | Get iCalendar document attachment by name             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarFileAsMapiModel**](EmailApi.md#getcalendarfileasmapimodel) | **PUT** /email/MapiCalendar/file-as-model | Converts calendar file to a MAPI model representation             
*EmailApi* | [**GetCalendarFileAsMapiModelAsync**](EmailApi.md#getcalendarfileasmapimodelasync) | **PUT** /email/MapiCalendar/file-as-model | Converts calendar file to a MAPI model representation             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarFileAsModel**](EmailApi.md#getcalendarfileasmodel) | **PUT** /email/CalendarModel/file-as-model | Converts calendar document to a model representation             
*EmailApi* | [**GetCalendarFileAsModelAsync**](EmailApi.md#getcalendarfileasmodelasync) | **PUT** /email/CalendarModel/file-as-model | Converts calendar document to a model representation             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarList**](EmailApi.md#getcalendarlist) | **GET** /email/Calendar | Get iCalendar files list in folder on storage             
*EmailApi* | [**GetCalendarListAsync**](EmailApi.md#getcalendarlistasync) | **GET** /email/Calendar | Get iCalendar files list in folder on storage             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarModel**](EmailApi.md#getcalendarmodel) | **GET** /email/CalendarModel/{name} | Get calendar file             
*EmailApi* | [**GetCalendarModelAsync**](EmailApi.md#getcalendarmodelasync) | **GET** /email/CalendarModel/{name} | Get calendar file             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarModelAsAlternate**](EmailApi.md#getcalendarmodelasalternate) | **GET** /email/CalendarModel/{name}/as-alternate/{calendarAction} | Get iCalendar from storage as AlternateView             
*EmailApi* | [**GetCalendarModelAsAlternateAsync**](EmailApi.md#getcalendarmodelasalternateasync) | **GET** /email/CalendarModel/{name}/as-alternate/{calendarAction} | Get iCalendar from storage as AlternateView             . Not available on .NETFramework v2.0
*EmailApi* | [**GetCalendarModelList**](EmailApi.md#getcalendarmodellist) | **GET** /email/CalendarModel | Get iCalendar list from storage folder             
*EmailApi* | [**GetCalendarModelListAsync**](EmailApi.md#getcalendarmodellistasync) | **GET** /email/CalendarModel | Get iCalendar list from storage folder             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactAsFile**](EmailApi.md#getcontactasfile) | **GET** /email/ContactModel/{format}/{fileName}/as-file/{destinationFormat} | Converts calendar document from storage to specified format and returns as file             
*EmailApi* | [**GetContactAsFileAsync**](EmailApi.md#getcontactasfileasync) | **GET** /email/ContactModel/{format}/{fileName}/as-file/{destinationFormat} | Converts calendar document from storage to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactAttachment**](EmailApi.md#getcontactattachment) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name             
*EmailApi* | [**GetContactAttachmentAsync**](EmailApi.md#getcontactattachmentasync) | **GET** /email/Contact/{format}/{name}/attachments/{attachment} | Get attachment file by name             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactFileAsMapiModel**](EmailApi.md#getcontactfileasmapimodel) | **PUT** /email/MapiContact/{fileFormat}/file-as-model | Converts contact file to a MAPI model representation             
*EmailApi* | [**GetContactFileAsMapiModelAsync**](EmailApi.md#getcontactfileasmapimodelasync) | **PUT** /email/MapiContact/{fileFormat}/file-as-model | Converts contact file to a MAPI model representation             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactFileAsModel**](EmailApi.md#getcontactfileasmodel) | **PUT** /email/ContactModel/{format}/file-as-model | Converts contact document to a model representation             
*EmailApi* | [**GetContactFileAsModelAsync**](EmailApi.md#getcontactfileasmodelasync) | **PUT** /email/ContactModel/{format}/file-as-model | Converts contact document to a model representation             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactList**](EmailApi.md#getcontactlist) | **GET** /email/Contact/{format} | Get contact list from storage folder             
*EmailApi* | [**GetContactListAsync**](EmailApi.md#getcontactlistasync) | **GET** /email/Contact/{format} | Get contact list from storage folder             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactModel**](EmailApi.md#getcontactmodel) | **GET** /email/ContactModel/{format}/{name} | Get contact document.             
*EmailApi* | [**GetContactModelAsync**](EmailApi.md#getcontactmodelasync) | **GET** /email/ContactModel/{format}/{name} | Get contact document.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactModelList**](EmailApi.md#getcontactmodellist) | **GET** /email/ContactModel/{format} | Get contact list from storage folder.             
*EmailApi* | [**GetContactModelListAsync**](EmailApi.md#getcontactmodellistasync) | **GET** /email/ContactModel/{format} | Get contact list from storage folder.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetContactProperties**](EmailApi.md#getcontactproperties) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties             
*EmailApi* | [**GetContactPropertiesAsync**](EmailApi.md#getcontactpropertiesasync) | **GET** /email/Contact/{format}/{name}/properties | Get contact document properties             . Not available on .NETFramework v2.0
*EmailApi* | [**GetDiscUsage**](EmailApi.md#getdiscusage) | **GET** /email/storage/disc | 
*EmailApi* | [**GetDiscUsageAsync**](EmailApi.md#getdiscusageasync) | **GET** /email/storage/disc | 
*EmailApi* | [**GetEmail**](EmailApi.md#getemail) | **GET** /email/{fileName} | Get email document             
*EmailApi* | [**GetEmailAsync**](EmailApi.md#getemailasync) | **GET** /email/{fileName} | Get email document             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailAsFile**](EmailApi.md#getemailasfile) | **GET** /email/{fileName}/as-file/{format} | Converts email document from storage to specified format and returns as file             
*EmailApi* | [**GetEmailAsFileAsync**](EmailApi.md#getemailasfileasync) | **GET** /email/{fileName}/as-file/{format} | Converts email document from storage to specified format and returns as file             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailAttachment**](EmailApi.md#getemailattachment) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name             
*EmailApi* | [**GetEmailAttachmentAsync**](EmailApi.md#getemailattachmentasync) | **GET** /email/{fileName}/attachments/{attachment} | Get email attachment by name             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailClientAccount**](EmailApi.md#getemailclientaccount) | **GET** /email/client/email-client-account | Get email client account from storage             
*EmailApi* | [**GetEmailClientAccountAsync**](EmailApi.md#getemailclientaccountasync) | **GET** /email/client/email-client-account | Get email client account from storage             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailClientMultiAccount**](EmailApi.md#getemailclientmultiaccount) | **GET** /email/client/multi-account | Get email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.             
*EmailApi* | [**GetEmailClientMultiAccountAsync**](EmailApi.md#getemailclientmultiaccountasync) | **GET** /email/client/multi-account | Get email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailFileAsMapiModel**](EmailApi.md#getemailfileasmapimodel) | **PUT** /email/MapiMessage/{fileFormat}/file-as-model | Converts email file to a MAPI model representation             
*EmailApi* | [**GetEmailFileAsMapiModelAsync**](EmailApi.md#getemailfileasmapimodelasync) | **PUT** /email/MapiMessage/{fileFormat}/file-as-model | Converts email file to a MAPI model representation             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailFileAsModel**](EmailApi.md#getemailfileasmodel) | **PUT** /email/model/file-as-model | Converts email document to a model representation             
*EmailApi* | [**GetEmailFileAsModelAsync**](EmailApi.md#getemailfileasmodelasync) | **PUT** /email/model/file-as-model | Converts email document to a model representation             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailModel**](EmailApi.md#getemailmodel) | **GET** /email/model/{format}/{name} | Get email document.             
*EmailApi* | [**GetEmailModelAsync**](EmailApi.md#getemailmodelasync) | **GET** /email/model/{format}/{name} | Get email document.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailModelList**](EmailApi.md#getemailmodellist) | **GET** /email/model/{format} | Get email list from storage folder.             
*EmailApi* | [**GetEmailModelListAsync**](EmailApi.md#getemailmodellistasync) | **GET** /email/model/{format} | Get email list from storage folder.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetEmailProperty**](EmailApi.md#getemailproperty) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name             
*EmailApi* | [**GetEmailPropertyAsync**](EmailApi.md#getemailpropertyasync) | **GET** /email/{fileName}/properties/{propertyName} | Get an email document property by its name             . Not available on .NETFramework v2.0
*EmailApi* | [**GetFileVersions**](EmailApi.md#getfileversions) | **GET** /email/storage/version/{path} | 
*EmailApi* | [**GetFileVersionsAsync**](EmailApi.md#getfileversionsasync) | **GET** /email/storage/version/{path} | 
*EmailApi* | [**GetFilesList**](EmailApi.md#getfileslist) | **GET** /email/storage/folder/{path} | 
*EmailApi* | [**GetFilesListAsync**](EmailApi.md#getfileslistasync) | **GET** /email/storage/folder/{path} | 
*EmailApi* | [**GetMapiAttachment**](EmailApi.md#getmapiattachment) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream             
*EmailApi* | [**GetMapiAttachmentAsync**](EmailApi.md#getmapiattachmentasync) | **GET** /email/Mapi/{name}/attachments/{attachment} | Get document attachment as file stream             . Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiAttachments**](EmailApi.md#getmapiattachments) | **GET** /email/Mapi/{name}/attachments | Get document attachment list             
*EmailApi* | [**GetMapiAttachmentsAsync**](EmailApi.md#getmapiattachmentsasync) | **GET** /email/Mapi/{name}/attachments | Get document attachment list             . Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiCalendarModel**](EmailApi.md#getmapicalendarmodel) | **GET** /email/MapiCalendar/{name} | Get calendar file             
*EmailApi* | [**GetMapiCalendarModelAsync**](EmailApi.md#getmapicalendarmodelasync) | **GET** /email/MapiCalendar/{name} | Get calendar file             . Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiContactModel**](EmailApi.md#getmapicontactmodel) | **GET** /email/MapiContact/{format}/{name} | Get contact document.             
*EmailApi* | [**GetMapiContactModelAsync**](EmailApi.md#getmapicontactmodelasync) | **GET** /email/MapiContact/{format}/{name} | Get contact document.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiList**](EmailApi.md#getmapilist) | **GET** /email/Mapi | Get document list from storage folder             
*EmailApi* | [**GetMapiListAsync**](EmailApi.md#getmapilistasync) | **GET** /email/Mapi | Get document list from storage folder             . Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiMessageModel**](EmailApi.md#getmapimessagemodel) | **GET** /email/MapiMessage/{format}/{name} | MAPI message document.             
*EmailApi* | [**GetMapiMessageModelAsync**](EmailApi.md#getmapimessagemodelasync) | **GET** /email/MapiMessage/{format}/{name} | MAPI message document.             . Not available on .NETFramework v2.0
*EmailApi* | [**GetMapiProperties**](EmailApi.md#getmapiproperties) | **GET** /email/Mapi/{name}/properties | Get document properties             
*EmailApi* | [**GetMapiPropertiesAsync**](EmailApi.md#getmapipropertiesasync) | **GET** /email/Mapi/{name}/properties | Get document properties             . Not available on .NETFramework v2.0
*EmailApi* | [**IsEmailAddressDisposable**](EmailApi.md#isemailaddressdisposable) | **GET** /email/disposable/isDisposable/{address} | Check email address is disposable             
*EmailApi* | [**IsEmailAddressDisposableAsync**](EmailApi.md#isemailaddressdisposableasync) | **GET** /email/disposable/isDisposable/{address} | Check email address is disposable             . Not available on .NETFramework v2.0
*EmailApi* | [**ListEmailFolders**](EmailApi.md#listemailfolders) | **GET** /email/client/ListFolders | Get folders list in email account             
*EmailApi* | [**ListEmailFoldersAsync**](EmailApi.md#listemailfoldersasync) | **GET** /email/client/ListFolders | Get folders list in email account             . Not available on .NETFramework v2.0
*EmailApi* | [**ListEmailMessages**](EmailApi.md#listemailmessages) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query             
*EmailApi* | [**ListEmailMessagesAsync**](EmailApi.md#listemailmessagesasync) | **GET** /email/client/ListMessages | Get messages from folder, filtered by query             . Not available on .NETFramework v2.0
*EmailApi* | [**ListEmailModels**](EmailApi.md#listemailmodels) | **GET** /email/client/ListMessagesModel | Get messages from folder, filtered by query             
*EmailApi* | [**ListEmailModelsAsync**](EmailApi.md#listemailmodelsasync) | **GET** /email/client/ListMessagesModel | Get messages from folder, filtered by query             . Not available on .NETFramework v2.0
*EmailApi* | [**ListEmailThreads**](EmailApi.md#listemailthreads) | **GET** /email/client/threads | Get message threads from folder. All messages are partly fetched (without email body and other fields)             
*EmailApi* | [**ListEmailThreadsAsync**](EmailApi.md#listemailthreadsasync) | **GET** /email/client/threads | Get message threads from folder. All messages are partly fetched (without email body and other fields)             . Not available on .NETFramework v2.0
*EmailApi* | [**MoveEmailMessage**](EmailApi.md#moveemailmessage) | **PUT** /email/client/move | Move message to another folder             
*EmailApi* | [**MoveEmailMessageAsync**](EmailApi.md#moveemailmessageasync) | **PUT** /email/client/move | Move message to another folder             . Not available on .NETFramework v2.0
*EmailApi* | [**MoveEmailThread**](EmailApi.md#moveemailthread) | **PUT** /email/client/threads/{threadId}/move | Move thread to another folder             
*EmailApi* | [**MoveEmailThreadAsync**](EmailApi.md#moveemailthreadasync) | **PUT** /email/client/threads/{threadId}/move | Move thread to another folder             . Not available on .NETFramework v2.0
*EmailApi* | [**MoveFile**](EmailApi.md#movefile) | **PUT** /email/storage/file/move/{srcPath} | 
*EmailApi* | [**MoveFileAsync**](EmailApi.md#movefileasync) | **PUT** /email/storage/file/move/{srcPath} | 
*EmailApi* | [**MoveFolder**](EmailApi.md#movefolder) | **PUT** /email/storage/folder/move/{srcPath} | 
*EmailApi* | [**MoveFolderAsync**](EmailApi.md#movefolderasync) | **PUT** /email/storage/folder/move/{srcPath} | 
*EmailApi* | [**ObjectExists**](EmailApi.md#objectexists) | **GET** /email/storage/exist/{path} | 
*EmailApi* | [**ObjectExistsAsync**](EmailApi.md#objectexistsasync) | **GET** /email/storage/exist/{path} | 
*EmailApi* | [**SaveCalendarModel**](EmailApi.md#savecalendarmodel) | **PUT** /email/CalendarModel/{name} | Save iCalendar             
*EmailApi* | [**SaveCalendarModelAsync**](EmailApi.md#savecalendarmodelasync) | **PUT** /email/CalendarModel/{name} | Save iCalendar             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveContactModel**](EmailApi.md#savecontactmodel) | **PUT** /email/ContactModel/{format}/{name} | Save contact.             
*EmailApi* | [**SaveContactModelAsync**](EmailApi.md#savecontactmodelasync) | **PUT** /email/ContactModel/{format}/{name} | Save contact.             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveEmailClientAccount**](EmailApi.md#saveemailclientaccount) | **PUT** /email/client/email-client-account | Create email client account file (*.account) with any of supported credentials             
*EmailApi* | [**SaveEmailClientAccountAsync**](EmailApi.md#saveemailclientaccountasync) | **PUT** /email/client/email-client-account | Create email client account file (*.account) with any of supported credentials             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveEmailClientMultiAccount**](EmailApi.md#saveemailclientmultiaccount) | **PUT** /email/client/multi-account | Create email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.             
*EmailApi* | [**SaveEmailClientMultiAccountAsync**](EmailApi.md#saveemailclientmultiaccountasync) | **PUT** /email/client/multi-account | Create email client multi account file (*.multi.account). Will respond error if file extension is not \&quot;.multi.account\&quot;.             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveEmailModel**](EmailApi.md#saveemailmodel) | **PUT** /email/model/{format}/{name} | Save email document.             
*EmailApi* | [**SaveEmailModelAsync**](EmailApi.md#saveemailmodelasync) | **PUT** /email/model/{format}/{name} | Save email document.             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveMailAccount**](EmailApi.md#savemailaccount) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication             
*EmailApi* | [**SaveMailAccountAsync**](EmailApi.md#savemailaccountasync) | **POST** /email/client/SaveMailAccount | Create email account file (*.account) with login/password authentication             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveMailOAuthAccount**](EmailApi.md#savemailoauthaccount) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth             
*EmailApi* | [**SaveMailOAuthAccountAsync**](EmailApi.md#savemailoauthaccountasync) | **POST** /email/client/SaveMailOAuthAccount | Create email account file (*.account) with OAuth             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveMapiCalendarModel**](EmailApi.md#savemapicalendarmodel) | **PUT** /email/MapiCalendar/{format}/{name} | Save MAPI Calendar to storage.             
*EmailApi* | [**SaveMapiCalendarModelAsync**](EmailApi.md#savemapicalendarmodelasync) | **PUT** /email/MapiCalendar/{format}/{name} | Save MAPI Calendar to storage.             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveMapiContactModel**](EmailApi.md#savemapicontactmodel) | **PUT** /email/MapiContact/{format}/{name} | Save contact.             
*EmailApi* | [**SaveMapiContactModelAsync**](EmailApi.md#savemapicontactmodelasync) | **PUT** /email/MapiContact/{format}/{name} | Save contact.             . Not available on .NETFramework v2.0
*EmailApi* | [**SaveMapiMessageModel**](EmailApi.md#savemapimessagemodel) | **PUT** /email/MapiMessage/{format}/{name} | Save MAPI message.             
*EmailApi* | [**SaveMapiMessageModelAsync**](EmailApi.md#savemapimessagemodelasync) | **PUT** /email/MapiMessage/{format}/{name} | Save MAPI message.             . Not available on .NETFramework v2.0
*EmailApi* | [**SendEmail**](EmailApi.md#sendemail) | **POST** /email/client/Send | Send an email from *.eml file located on storage             
*EmailApi* | [**SendEmailAsync**](EmailApi.md#sendemailasync) | **POST** /email/client/Send | Send an email from *.eml file located on storage             . Not available on .NETFramework v2.0
*EmailApi* | [**SendEmailMime**](EmailApi.md#sendemailmime) | **POST** /email/client/SendMime | Send an email specified by MIME in request             
*EmailApi* | [**SendEmailMimeAsync**](EmailApi.md#sendemailmimeasync) | **POST** /email/client/SendMime | Send an email specified by MIME in request             . Not available on .NETFramework v2.0
*EmailApi* | [**SendEmailModel**](EmailApi.md#sendemailmodel) | **POST** /email/client/SendModel | Send an email specified by model in request             
*EmailApi* | [**SendEmailModelAsync**](EmailApi.md#sendemailmodelasync) | **POST** /email/client/SendModel | Send an email specified by model in request             . Not available on .NETFramework v2.0
*EmailApi* | [**SetEmailProperty**](EmailApi.md#setemailproperty) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value             
*EmailApi* | [**SetEmailPropertyAsync**](EmailApi.md#setemailpropertyasync) | **PUT** /email/{fileName}/properties/{propertyName} | Set email document property value             . Not available on .NETFramework v2.0
*EmailApi* | [**SetEmailReadFlag**](EmailApi.md#setemailreadflag) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag             
*EmailApi* | [**SetEmailReadFlagAsync**](EmailApi.md#setemailreadflagasync) | **POST** /email/client/SetReadFlag | Sets \&quot;Message is read\&quot; flag             . Not available on .NETFramework v2.0
*EmailApi* | [**SetEmailThreadReadFlag**](EmailApi.md#setemailthreadreadflag) | **PUT** /email/client/threads/{threadId}/read-flag | Mark all messages in thread as read or unread             
*EmailApi* | [**SetEmailThreadReadFlagAsync**](EmailApi.md#setemailthreadreadflagasync) | **PUT** /email/client/threads/{threadId}/read-flag | Mark all messages in thread as read or unread             . Not available on .NETFramework v2.0
*EmailApi* | [**StorageExists**](EmailApi.md#storageexists) | **GET** /email/storage/{storageName}/exist | 
*EmailApi* | [**StorageExistsAsync**](EmailApi.md#storageexistsasync) | **GET** /email/storage/{storageName}/exist | 
*EmailApi* | [**UpdateCalendarProperties**](EmailApi.md#updatecalendarproperties) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties             
*EmailApi* | [**UpdateCalendarPropertiesAsync**](EmailApi.md#updatecalendarpropertiesasync) | **PUT** /email/Calendar/{name}/properties | Update calendar file properties             . Not available on .NETFramework v2.0
*EmailApi* | [**UpdateContactProperties**](EmailApi.md#updatecontactproperties) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties             
*EmailApi* | [**UpdateContactPropertiesAsync**](EmailApi.md#updatecontactpropertiesasync) | **PUT** /email/Contact/{format}/{name}/properties | Update contact document properties             . Not available on .NETFramework v2.0
*EmailApi* | [**UpdateMapiProperties**](EmailApi.md#updatemapiproperties) | **PUT** /email/Mapi/{name}/properties | Update document properties             
*EmailApi* | [**UpdateMapiPropertiesAsync**](EmailApi.md#updatemapipropertiesasync) | **PUT** /email/Mapi/{name}/properties | Update document properties             . Not available on .NETFramework v2.0
*EmailApi* | [**UploadFile**](EmailApi.md#uploadfile) | **PUT** /email/storage/file/{path} | 
*EmailApi* | [**UploadFileAsync**](EmailApi.md#uploadfileasync) | **PUT** /email/storage/file/{path} | 


## Documentation for Models

 - [Model.AccountBaseRequest](AccountBaseRequest.md)
 - [Model.AddAttachmentRequest](AddAttachmentRequest.md)
 - [Model.AiBcrImage](AiBcrImage.md)
 - [Model.AiBcrOcrData](AiBcrOcrData.md)
 - [Model.AiBcrOcrDataPart](AiBcrOcrDataPart.md)
 - [Model.AiBcrOptions](AiBcrOptions.md)
 - [Model.AiBcrRq](AiBcrRq.md)
 - [Model.AiNameComponent](AiNameComponent.md)
 - [Model.AiNameCulturalContext](AiNameCulturalContext.md)
 - [Model.AiNameExtracted](AiNameExtracted.md)
 - [Model.AiNameExtractedComponent](AiNameExtractedComponent.md)
 - [Model.AiNameFormatted](AiNameFormatted.md)
 - [Model.AiNameGenderHypothesis](AiNameGenderHypothesis.md)
 - [Model.AiNameMatchResult](AiNameMatchResult.md)
 - [Model.AiNameMismatch](AiNameMismatch.md)
 - [Model.AiNameParsedRq](AiNameParsedRq.md)
 - [Model.AiNameWeighted](AiNameWeighted.md)
 - [Model.AiNameWeightedVariants](AiNameWeightedVariants.md)
 - [Model.AssociatedPerson](AssociatedPerson.md)
 - [Model.AttachmentBase](AttachmentBase.md)
 - [Model.BaseObject](BaseObject.md)
 - [Model.CalendarDto](CalendarDto.md)
 - [Model.CalendarDtoAlternateRq](CalendarDtoAlternateRq.md)
 - [Model.CalendarReminder](CalendarReminder.md)
 - [Model.ContactDto](ContactDto.md)
 - [Model.ContactPhoto](ContactPhoto.md)
 - [Model.ContentType](ContentType.md)
 - [Model.ContentTypeParameter](ContentTypeParameter.md)
 - [Model.CreateEmailRequest](CreateEmailRequest.md)
 - [Model.CustomerEvent](CustomerEvent.md)
 - [Model.DiscUsage](DiscUsage.md)
 - [Model.DiscoverEmailConfigRq](DiscoverEmailConfigRq.md)
 - [Model.EmailAccountConfig](EmailAccountConfig.md)
 - [Model.EmailAccountRequest](EmailAccountRequest.md)
 - [Model.EmailAddress](EmailAddress.md)
 - [Model.EmailClientAccount](EmailClientAccount.md)
 - [Model.EmailClientAccountCredentials](EmailClientAccountCredentials.md)
 - [Model.EmailClientMultiAccount](EmailClientMultiAccount.md)
 - [Model.EmailDocument](EmailDocument.md)
 - [Model.EmailDocumentResponse](EmailDocumentResponse.md)
 - [Model.EmailDto](EmailDto.md)
 - [Model.EmailProperties](EmailProperties.md)
 - [Model.EmailProperty](EmailProperty.md)
 - [Model.EmailPropertyResponse](EmailPropertyResponse.md)
 - [Model.EmailThread](EmailThread.md)
 - [Model.EnumWithCustomOfAssociatedPersonCategory](EnumWithCustomOfAssociatedPersonCategory.md)
 - [Model.EnumWithCustomOfEmailAddressCategory](EnumWithCustomOfEmailAddressCategory.md)
 - [Model.EnumWithCustomOfEventCategory](EnumWithCustomOfEventCategory.md)
 - [Model.EnumWithCustomOfInstantMessengerCategory](EnumWithCustomOfInstantMessengerCategory.md)
 - [Model.EnumWithCustomOfPhoneNumberCategory](EnumWithCustomOfPhoneNumberCategory.md)
 - [Model.EnumWithCustomOfPostalAddressCategory](EnumWithCustomOfPostalAddressCategory.md)
 - [Model.EnumWithCustomOfUrlCategory](EnumWithCustomOfUrlCategory.md)
 - [Model.Error](Error.md)
 - [Model.ErrorDetails](ErrorDetails.md)
 - [Model.FileVersions](FileVersions.md)
 - [Model.FilesList](FilesList.md)
 - [Model.FilesUploadResult](FilesUploadResult.md)
 - [Model.HierarchicalObjectRequest](HierarchicalObjectRequest.md)
 - [Model.HierarchicalObjectResponse](HierarchicalObjectResponse.md)
 - [Model.InstantMessengerAddress](InstantMessengerAddress.md)
 - [Model.Link](Link.md)
 - [Model.ListResponseOfAiBcrOcrData](ListResponseOfAiBcrOcrData.md)
 - [Model.ListResponseOfAiNameComponent](ListResponseOfAiNameComponent.md)
 - [Model.ListResponseOfAiNameExtracted](ListResponseOfAiNameExtracted.md)
 - [Model.ListResponseOfAiNameGenderHypothesis](ListResponseOfAiNameGenderHypothesis.md)
 - [Model.ListResponseOfContactDto](ListResponseOfContactDto.md)
 - [Model.ListResponseOfEmailAccountConfig](ListResponseOfEmailAccountConfig.md)
 - [Model.ListResponseOfEmailDto](ListResponseOfEmailDto.md)
 - [Model.ListResponseOfEmailThread](ListResponseOfEmailThread.md)
 - [Model.ListResponseOfHierarchicalObject](ListResponseOfHierarchicalObject.md)
 - [Model.ListResponseOfHierarchicalObjectResponse](ListResponseOfHierarchicalObjectResponse.md)
 - [Model.ListResponseOfMailServerFolder](ListResponseOfMailServerFolder.md)
 - [Model.ListResponseOfStorageFileLocation](ListResponseOfStorageFileLocation.md)
 - [Model.ListResponseOfStorageModelOfCalendarDto](ListResponseOfStorageModelOfCalendarDto.md)
 - [Model.ListResponseOfStorageModelOfContactDto](ListResponseOfStorageModelOfContactDto.md)
 - [Model.ListResponseOfStorageModelOfEmailDto](ListResponseOfStorageModelOfEmailDto.md)
 - [Model.ListResponseOfString](ListResponseOfString.md)
 - [Model.MailAddress](MailAddress.md)
 - [Model.MailServerFolder](MailServerFolder.md)
 - [Model.MapiAttachmentDto](MapiAttachmentDto.md)
 - [Model.MapiCalendarAttendeesDto](MapiCalendarAttendeesDto.md)
 - [Model.MapiCalendarEventRecurrenceDto](MapiCalendarEventRecurrenceDto.md)
 - [Model.MapiCalendarExceptionInfoDto](MapiCalendarExceptionInfoDto.md)
 - [Model.MapiCalendarRecurrencePatternDto](MapiCalendarRecurrencePatternDto.md)
 - [Model.MapiCalendarTimeZoneDto](MapiCalendarTimeZoneDto.md)
 - [Model.MapiCalendarTimeZoneInfoDto](MapiCalendarTimeZoneInfoDto.md)
 - [Model.MapiCalendarTimeZoneRuleDto](MapiCalendarTimeZoneRuleDto.md)
 - [Model.MapiContactElectronicAddressDto](MapiContactElectronicAddressDto.md)
 - [Model.MapiContactElectronicAddressPropertySetDto](MapiContactElectronicAddressPropertySetDto.md)
 - [Model.MapiContactEventPropertySetDto](MapiContactEventPropertySetDto.md)
 - [Model.MapiContactNamePropertySetDto](MapiContactNamePropertySetDto.md)
 - [Model.MapiContactOtherPropertySetDto](MapiContactOtherPropertySetDto.md)
 - [Model.MapiContactPersonalInfoPropertySetDto](MapiContactPersonalInfoPropertySetDto.md)
 - [Model.MapiContactPhysicalAddressDto](MapiContactPhysicalAddressDto.md)
 - [Model.MapiContactPhysicalAddressPropertySetDto](MapiContactPhysicalAddressPropertySetDto.md)
 - [Model.MapiContactProfessionalPropertySetDto](MapiContactProfessionalPropertySetDto.md)
 - [Model.MapiContactTelephonePropertySetDto](MapiContactTelephonePropertySetDto.md)
 - [Model.MapiElectronicAddressDto](MapiElectronicAddressDto.md)
 - [Model.MapiMessageItemBaseDto](MapiMessageItemBaseDto.md)
 - [Model.MapiPropertyDescriptor](MapiPropertyDescriptor.md)
 - [Model.MapiPropertyDto](MapiPropertyDto.md)
 - [Model.MapiRecipientDto](MapiRecipientDto.md)
 - [Model.MimeResponse](MimeResponse.md)
 - [Model.NameValuePair](NameValuePair.md)
 - [Model.ObjectExist](ObjectExist.md)
 - [Model.PhoneNumber](PhoneNumber.md)
 - [Model.PostalAddress](PostalAddress.md)
 - [Model.RecurrencePatternDto](RecurrencePatternDto.md)
 - [Model.ReminderAttendee](ReminderAttendee.md)
 - [Model.ReminderTrigger](ReminderTrigger.md)
 - [Model.SetEmailPropertyRequest](SetEmailPropertyRequest.md)
 - [Model.StorageExist](StorageExist.md)
 - [Model.StorageFile](StorageFile.md)
 - [Model.StorageFileRqOfEmailClientAccount](StorageFileRqOfEmailClientAccount.md)
 - [Model.StorageFileRqOfEmailClientMultiAccount](StorageFileRqOfEmailClientMultiAccount.md)
 - [Model.StorageFolderLocation](StorageFolderLocation.md)
 - [Model.StorageModelOfCalendarDto](StorageModelOfCalendarDto.md)
 - [Model.StorageModelOfContactDto](StorageModelOfContactDto.md)
 - [Model.StorageModelOfEmailDto](StorageModelOfEmailDto.md)
 - [Model.StorageModelRqOfCalendarDto](StorageModelRqOfCalendarDto.md)
 - [Model.StorageModelRqOfContactDto](StorageModelRqOfContactDto.md)
 - [Model.StorageModelRqOfEmailDto](StorageModelRqOfEmailDto.md)
 - [Model.StorageModelRqOfMapiCalendarDto](StorageModelRqOfMapiCalendarDto.md)
 - [Model.StorageModelRqOfMapiContactDto](StorageModelRqOfMapiContactDto.md)
 - [Model.StorageModelRqOfMapiMessageDto](StorageModelRqOfMapiMessageDto.md)
 - [Model.Url](Url.md)
 - [Model.ValueResponse](ValueResponse.md)
 - [Model.ValueTOfBoolean](ValueTOfBoolean.md)
 - [Model.AiBcrBase64Image](AiBcrBase64Image.md)
 - [Model.AiBcrBase64Rq](AiBcrBase64Rq.md)
 - [Model.AiBcrImageStorageFile](AiBcrImageStorageFile.md)
 - [Model.AiBcrParseOcrDataRq](AiBcrParseOcrDataRq.md)
 - [Model.AiBcrStorageImageRq](AiBcrStorageImageRq.md)
 - [Model.AiNameParsedMatchRq](AiNameParsedMatchRq.md)
 - [Model.AlternateView](AlternateView.md)
 - [Model.AppendEmailAccountBaseRequest](AppendEmailAccountBaseRequest.md)
 - [Model.Attachment](Attachment.md)
 - [Model.CalendarDtoList](CalendarDtoList.md)
 - [Model.ContactDtoList](ContactDtoList.md)
 - [Model.CreateFolderBaseRequest](CreateFolderBaseRequest.md)
 - [Model.DailyRecurrencePatternDto](DailyRecurrencePatternDto.md)
 - [Model.DeleteEmailThreadAccountRq](DeleteEmailThreadAccountRq.md)
 - [Model.DeleteFolderBaseRequest](DeleteFolderBaseRequest.md)
 - [Model.DeleteMessageBaseRequest](DeleteMessageBaseRequest.md)
 - [Model.DiscoverEmailConfigOauth](DiscoverEmailConfigOauth.md)
 - [Model.DiscoverEmailConfigPassword](DiscoverEmailConfigPassword.md)
 - [Model.EmailAccountConfigList](EmailAccountConfigList.md)
 - [Model.EmailClientAccountOauthCredentials](EmailClientAccountOauthCredentials.md)
 - [Model.EmailClientAccountPasswordCredentials](EmailClientAccountPasswordCredentials.md)
 - [Model.EmailDtoList](EmailDtoList.md)
 - [Model.EmailThreadList](EmailThreadList.md)
 - [Model.EmailThreadReadFlagRq](EmailThreadReadFlagRq.md)
 - [Model.FileVersion](FileVersion.md)
 - [Model.HierarchicalObject](HierarchicalObject.md)
 - [Model.IndexedHierarchicalObject](IndexedHierarchicalObject.md)
 - [Model.IndexedPrimitiveObject](IndexedPrimitiveObject.md)
 - [Model.LinkedResource](LinkedResource.md)
 - [Model.MapiBinaryPropertyDto](MapiBinaryPropertyDto.md)
 - [Model.MapiBooleanPropertyDto](MapiBooleanPropertyDto.md)
 - [Model.MapiCalendarDailyRecurrencePatternDto](MapiCalendarDailyRecurrencePatternDto.md)
 - [Model.MapiCalendarDto](MapiCalendarDto.md)
 - [Model.MapiCalendarWeeklyRecurrencePatternDto](MapiCalendarWeeklyRecurrencePatternDto.md)
 - [Model.MapiCalendarYearlyAndMonthlyRecurrencePatternDto](MapiCalendarYearlyAndMonthlyRecurrencePatternDto.md)
 - [Model.MapiContactDto](MapiContactDto.md)
 - [Model.MapiContactPhotoDto](MapiContactPhotoDto.md)
 - [Model.MapiDateTimePropertyDto](MapiDateTimePropertyDto.md)
 - [Model.MapiFileAsPropertyDto](MapiFileAsPropertyDto.md)
 - [Model.MapiImportancePropertyDto](MapiImportancePropertyDto.md)
 - [Model.MapiIntPropertyDto](MapiIntPropertyDto.md)
 - [Model.MapiKnownPropertyDescriptor](MapiKnownPropertyDescriptor.md)
 - [Model.MapiLegacyFreeBusyPropertyDto](MapiLegacyFreeBusyPropertyDto.md)
 - [Model.MapiMessageDto](MapiMessageDto.md)
 - [Model.MapiMultiIntPropertyDto](MapiMultiIntPropertyDto.md)
 - [Model.MapiMultiStringPropertyDto](MapiMultiStringPropertyDto.md)
 - [Model.MapiPhysicalAddressIndexPropertyDto](MapiPhysicalAddressIndexPropertyDto.md)
 - [Model.MapiPidPropertyDescriptor](MapiPidPropertyDescriptor.md)
 - [Model.MapiResponseTypePropertyDto](MapiResponseTypePropertyDto.md)
 - [Model.MapiStringPropertyDto](MapiStringPropertyDto.md)
 - [Model.MonthlyRecurrencePatternDto](MonthlyRecurrencePatternDto.md)
 - [Model.MoveEmailMessageRq](MoveEmailMessageRq.md)
 - [Model.MoveEmailThreadRq](MoveEmailThreadRq.md)
 - [Model.PrimitiveObject](PrimitiveObject.md)
 - [Model.SaveEmailAccountRequest](SaveEmailAccountRequest.md)
 - [Model.SaveOAuthEmailAccountRequest](SaveOAuthEmailAccountRequest.md)
 - [Model.SendEmailBaseRequest](SendEmailBaseRequest.md)
 - [Model.SendEmailMimeBaseRequest](SendEmailMimeBaseRequest.md)
 - [Model.SendEmailModelRq](SendEmailModelRq.md)
 - [Model.SetMessageReadFlagAccountBaseRequest](SetMessageReadFlagAccountBaseRequest.md)
 - [Model.StorageFileLocation](StorageFileLocation.md)
 - [Model.TaskRegeneratingPatternDto](TaskRegeneratingPatternDto.md)
 - [Model.WeeklyRecurrencePatternDto](WeeklyRecurrencePatternDto.md)
 - [Model.YearlyRecurrencePatternDto](YearlyRecurrencePatternDto.md)
 - [Model.AiBcrParseStorageRq](AiBcrParseStorageRq.md)
 - [Model.AppendEmailBaseRequest](AppendEmailBaseRequest.md)
 - [Model.AppendEmailMimeBaseRequest](AppendEmailMimeBaseRequest.md)
 - [Model.AppendEmailModelRq](AppendEmailModelRq.md)
 - [Model.MapiPidLidPropertyDescriptor](MapiPidLidPropertyDescriptor.md)
 - [Model.MapiPidNamePropertyDescriptor](MapiPidNamePropertyDescriptor.md)
 - [Model.MapiPidTagPropertyDescriptor](MapiPidTagPropertyDescriptor.md)

