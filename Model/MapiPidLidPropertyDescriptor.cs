// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MapiPidLidPropertyDescriptor.cs">
//   Copyright (c) 2016-2020 Aspose.Email for Cloud
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

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantUsingDirective
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
namespace Aspose.Email.Cloud.Sdk.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    /// <summary>
    /// Property identified by an unsigned 32-bit quantity along with a property set             
    /// </summary>
    public class MapiPidLidPropertyDescriptor : MapiPidPropertyDescriptor 
    {
        /// <summary>
        /// An unsigned 32-bit quantity that, along with the property set, identifies a named property.             
        /// </summary>
        public long? LongId { get; set; }

        /// <summary>
        /// A GUID that identifies a group of properties with a similar purpose.             
        /// </summary>
        public string PropertySet { get; set; }


        /// <summary>MapiPidLidPropertyDescriptor constructor</summary>
        public MapiPidLidPropertyDescriptor() {}


        /// <summary>MapiPidLidPropertyDescriptor constructor</summary>
        /// <param name="canonicalName">The name used to refer to the property in the documentation. The prefix of the canonical name identifies the basic characteristics of a property to the implementer. The canonical naming structure uses three categories that are denoted by the following prefixes to the canonical property name: * PidLid prefix: Properties identified by an unsigned 32-bit quantity along with a property set. * PidName prefix: Properties identified by a string name along with a property set. * PidTag prefix: Properties identified by an unsigned 16-bit quantity.             </param>
        /// <param name="dataType">[MS-OXCDATA]: Data Structures./nEnum, available values: Unspecified, Null, Integer16, Integer32, Floating32, Floating64, Currency, FloatingTime, ErrorCode, Boolean, Integer64, String, String8, Time, Guid, ServerId, Restriction, RuleAction, Binary, MultipleInteger16, MultipleInteger32, MultipleFloating32, MultipleFloating64, MultipleCurrency, MultipleFloatingTime, MultipleBoolean, MultipleInteger64, MultipleString, MultipleString8, MultipleTime, MultipleGuid, MultipleBinary, Object</param>
        /// <param name="multipleValuesDataType">Indicates if data type contains of multiple values             </param>
        /// <param name="name">A string that identifies the property             </param>
        /// <param name="longId">An unsigned 32-bit quantity that, along with the property set, identifies a named property.             </param>
        /// <param name="propertySet">A GUID that identifies a group of properties with a similar purpose.             </param>
        public MapiPidLidPropertyDescriptor(
            //,
            string canonicalName,
            string dataType,
            bool? multipleValuesDataType,
            string name,
            long? longId,
            string propertySet
        )
        { 
            CanonicalName = canonicalName;
            DataType = dataType;
            MultipleValuesDataType = multipleValuesDataType;
            Name = name;
            LongId = longId;
            PropertySet = propertySet;
        }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MapiPidLidPropertyDescriptor {\n");
          sb.Append("  Discriminator: ").Append(this.Discriminator).Append("\n");
          sb.Append("  CanonicalName: ").Append(this.CanonicalName).Append("\n");
          sb.Append("  DataType: ").Append(this.DataType).Append("\n");
          sb.Append("  MultipleValuesDataType: ").Append(this.MultipleValuesDataType).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  LongId: ").Append(this.LongId).Append("\n");
          sb.Append("  PropertySet: ").Append(this.PropertySet).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
