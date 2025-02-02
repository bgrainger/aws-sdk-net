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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// This is the response object from the GetFirewallRuleGroupPolicy operation.
    /// </summary>
    public partial class GetFirewallRuleGroupPolicyResponse : AmazonWebServiceResponse
    {
        private string _firewallRuleGroupPolicy;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupPolicy. 
        /// <para>
        /// The Identity and Access Management (Amazon Web Services IAM) policy for sharing the
        /// specified rule group. You can use the policy to share the rule group using Resource
        /// Access Manager (RAM). 
        /// </para>
        /// </summary>
        [AWSProperty(Max=5000)]
        public string FirewallRuleGroupPolicy
        {
            get { return this._firewallRuleGroupPolicy; }
            set { this._firewallRuleGroupPolicy = value; }
        }

        // Check to see if FirewallRuleGroupPolicy property is set
        internal bool IsSetFirewallRuleGroupPolicy()
        {
            return this._firewallRuleGroupPolicy != null;
        }

    }
}