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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateModelVersion Request Marshaller
    /// </summary>       
    public class UpdateModelVersionRequestMarshaller : IMarshaller<IRequest, UpdateModelVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateModelVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateModelVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FraudDetector");
            string target = "AWSHawksNestServiceFacade.UpdateModelVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-15";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExternalEventsDetail())
                {
                    context.Writer.WritePropertyName("externalEventsDetail");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExternalEventsDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExternalEventsDetail, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIngestedEventsDetail())
                {
                    context.Writer.WritePropertyName("ingestedEventsDetail");
                    context.Writer.WriteObjectStart();

                    var marshaller = IngestedEventsDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IngestedEventsDetail, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMajorVersionNumber())
                {
                    context.Writer.WritePropertyName("majorVersionNumber");
                    context.Writer.Write(publicRequest.MajorVersionNumber);
                }

                if(publicRequest.IsSetModelId())
                {
                    context.Writer.WritePropertyName("modelId");
                    context.Writer.Write(publicRequest.ModelId);
                }

                if(publicRequest.IsSetModelType())
                {
                    context.Writer.WritePropertyName("modelType");
                    context.Writer.Write(publicRequest.ModelType);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateModelVersionRequestMarshaller _instance = new UpdateModelVersionRequestMarshaller();        

        internal static UpdateModelVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateModelVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}