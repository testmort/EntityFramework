// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Design.Internal.Infrastructure;

namespace Microsoft.EntityFrameworkCore.Design.Internal.Protocol
{
    [Endpoint(Constants.ApiPrefix + "/log/message", HttpMethodName.Post)]
    public class LogMessage
    {
        public string Level { get; set; }
        public string Content { get; set; }
    }
}