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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies that WAF should allow the request and optionally defines additional custom
    /// handling for the request.
    /// 
    ///  
    /// <para>
    /// This is used in the context of other settings, for example to specify values for <a>RuleAction</a>
    /// and web ACL <a>DefaultAction</a>. 
    /// </para>
    /// </summary>
    public partial class AllowAction
    {
        private CustomRequestHandling _customRequestHandling;

        /// <summary>
        /// Gets and sets the property CustomRequestHandling. 
        /// <para>
        /// Defines custom handling for the web request.
        /// </para>
        ///  
        /// <para>
        /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
        /// web requests and responses in WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        /// </summary>
        public CustomRequestHandling CustomRequestHandling
        {
            get { return this._customRequestHandling; }
            set { this._customRequestHandling = value; }
        }

        // Check to see if CustomRequestHandling property is set
        internal bool IsSetCustomRequestHandling()
        {
            return this._customRequestHandling != null;
        }

    }
}