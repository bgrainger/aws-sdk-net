/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// List of sidewalk certificates.
    /// </summary>
    public partial class CertificateList
    {
        private SigningAlg _signingAlg;
        private string _value;

        /// <summary>
        /// Gets and sets the property SigningAlg. 
        /// <para>
        /// The certificate chain algorithm provided by sidewalk.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningAlg SigningAlg
        {
            get { return this._signingAlg; }
            set { this._signingAlg = value; }
        }

        // Check to see if SigningAlg property is set
        internal bool IsSetSigningAlg()
        {
            return this._signingAlg != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the chosen sidewalk certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}