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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information system user and group that the IoT Greengrass Core software uses
    /// to run component processes on the core device. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-greengrass-core-v2.html#configure-component-user">Configure
    /// the user and group that run components</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// </summary>
    public partial class ComponentRunWith
    {
        private string _posixUser;
        private SystemResourceLimits _systemResourceLimits;

        /// <summary>
        /// Gets and sets the property PosixUser. 
        /// <para>
        /// The POSIX system user and (optional) group to use to run this component. Specify the
        /// user and group separated by a colon (<code>:</code>) in the following format: <code>user:group</code>.
        /// The group is optional. If you don't specify a group, the IoT Greengrass Core software
        /// uses the primary user for the group.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the IoT Greengrass Core software uses the default system
        /// user and group that you configure on the Greengrass nucleus component. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-greengrass-core-v2.html#configure-component-user">Configure
        /// the user and group that run components</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PosixUser
        {
            get { return this._posixUser; }
            set { this._posixUser = value; }
        }

        // Check to see if PosixUser property is set
        internal bool IsSetPosixUser()
        {
            return this._posixUser != null;
        }

        /// <summary>
        /// Gets and sets the property SystemResourceLimits. 
        /// <para>
        /// The system resource limits to apply to this component's process on the core device.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the IoT Greengrass Core software uses the default system
        /// resource limits that you configure on the Greengrass nucleus component. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-greengrass-core-v2.html#configure-component-system-resource-limits">Configure
        /// system resource limits for components</a>.
        /// </para>
        /// </summary>
        public SystemResourceLimits SystemResourceLimits
        {
            get { return this._systemResourceLimits; }
            set { this._systemResourceLimits = value; }
        }

        // Check to see if SystemResourceLimits property is set
        internal bool IsSetSystemResourceLimits()
        {
            return this._systemResourceLimits != null;
        }

    }
}