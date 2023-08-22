
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClientGroup.cs">
//   Copyright (c) 2018-2023 Aspose.Email for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Email.Cloud.Sdk.Api
{
    using Client;
    
    /** <summary>Builtin Email client operations.</summary>*/
    public class ClientGroup
    {
    
        /** <summary>Email server account for built-in client operations.</summary>*/
        public ClientAccountApi Account { get; }
    
        /** <summary>Email client folder operations.</summary>*/
        public ClientFolderApi Folder { get; }
    
        /** <summary>Email client message operations.</summary>*/
        public ClientMessageApi Message { get; }
    
        /** <summary>Email client thread operations.</summary>*/
        public ClientThreadApi Thread { get; }
    
        internal ClientGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            Account = new ClientAccountApi(apiInvoker, configuration);
        
            Folder = new ClientFolderApi(apiInvoker, configuration);
        
            Message = new ClientMessageApi(apiInvoker, configuration);
        
            Thread = new ClientThreadApi(apiInvoker, configuration);
        
        }
    }
}

