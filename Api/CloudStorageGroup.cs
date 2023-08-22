
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CloudStorageGroup.cs">
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
    
    /** <summary>Cloud file storage operations.</summary>*/
    public class CloudStorageGroup
    {
    
        /** <summary>File operations controller</summary>*/
        public FileApi File { get; }
    
        /** <summary>Folder operations controller</summary>*/
        public FolderApi Folder { get; }
    
        /** <summary>Storage operations controller</summary>*/
        public StorageApi Storage { get; }
    
        internal CloudStorageGroup(ApiInvoker apiInvoker, Configuration configuration)
        {
        
            File = new FileApi(apiInvoker, configuration);
        
            Folder = new FolderApi(apiInvoker, configuration);
        
            Storage = new StorageApi(apiInvoker, configuration);
        
        }
    }
}

