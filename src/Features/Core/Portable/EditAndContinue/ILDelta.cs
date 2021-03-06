﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.EditAndContinue
{
    internal readonly struct ILDelta
    {
        public readonly byte[] Value;

        public ILDelta(byte[] value)
        {
            this.Value = value;
        }
    }
}
