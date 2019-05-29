/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// An object that specifies whether cloud metrics are collected in a deployment and,
    /// if so, what role is used to collect metrics.
    /// </summary>
    public partial class MetricsConfiguration
    {
        private bool? _cloudMetricEnabled;
        private string _metricRuleRoleArn;

        /// <summary>
        /// Gets and sets the property CloudMetricEnabled. 
        /// <para>
        /// A Boolean that specifies whether cloud metrics are collected.
        /// </para>
        /// </summary>
        public bool CloudMetricEnabled
        {
            get { return this._cloudMetricEnabled.GetValueOrDefault(); }
            set { this._cloudMetricEnabled = value; }
        }

        // Check to see if CloudMetricEnabled property is set
        internal bool IsSetCloudMetricEnabled()
        {
            return this._cloudMetricEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricRuleRoleArn. 
        /// <para>
        /// The ARN of the role that is used to collect cloud metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string MetricRuleRoleArn
        {
            get { return this._metricRuleRoleArn; }
            set { this._metricRuleRoleArn = value; }
        }

        // Check to see if MetricRuleRoleArn property is set
        internal bool IsSetMetricRuleRoleArn()
        {
            return this._metricRuleRoleArn != null;
        }

    }
}