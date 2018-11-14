﻿/*
Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.

  Licensed under the Apache License, Version 2.0 (the "License").
  You may not use this file except in compliance with the License.
  A copy of the License is located at

      http://www.apache.org/licenses/LICENSE-2.0

  or in the "license" file accompanying this file. This file is distributed
  on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
  express or implied. See the License for the specific language governing
  permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.AspNetCore.DataProtection.SSM
{
    /// <summary>
    /// Exception thrown when the service client for AWS Systems Manager, implementation of the interface IAmazonSimpleSystemsManagement,
    /// cannot be found when constructing the DataProtection SSM repository. 
    /// </summary>
    public class SSMNotConfiguredException : Exception
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public SSMNotConfiguredException()
            :base("The AWS Systems Manager service client is not configured with the service provider. " +
                  "Add the AWSSDK.Extensions.NETCore.Setup package and then call \"services.AddAWSService<Amazon.SimpleSystemsManagement.IAmazonSimpleSystemsManagement>();\" " +
                  "when adding services to the IServiceCollection.")
        {

        }
    }
}
