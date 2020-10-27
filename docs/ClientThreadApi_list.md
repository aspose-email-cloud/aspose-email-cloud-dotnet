
## Documentation for ClientThreadApi operations

All URIs are relative to *https://api.aspose.cloud/v4.0*

All methods have Async versions. These async versions are not available on .NETFramework v2.0.

Method | HTTP request | Description
------------- | ------------- | -------------
[**Delete**](ClientThreadApi.md#Delete)/[**DeleteAsync**](ClientThreadApi.md#DeleteAsync)| **DELETE** /email/client/thread| Delete thread by id. All messages from thread will also be deleted.             
[**GetList**](ClientThreadApi.md#GetList)/[**GetListAsync**](ClientThreadApi.md#GetListAsync)| **GET** /email/client/thread/list| Get message threads from folder. All messages are partly fetched (without email body and some other fields).             
[**GetMessages**](ClientThreadApi.md#GetMessages)/[**GetMessagesAsync**](ClientThreadApi.md#GetMessagesAsync)| **GET** /email/client/thread/messages| Get messages from thread by id. All messages are fully fetched. For accounts with CacheFile only cached messages will be returned.             
[**Move**](ClientThreadApi.md#Move)/[**MoveAsync**](ClientThreadApi.md#MoveAsync)| **PUT** /email/client/thread/move| Move thread to another folder.             
[**SetIsRead**](ClientThreadApi.md#SetIsRead)/[**SetIsReadAsync**](ClientThreadApi.md#SetIsReadAsync)| **PUT** /email/client/thread/set-is-read| Mark all messages in thread as read or unread.             

