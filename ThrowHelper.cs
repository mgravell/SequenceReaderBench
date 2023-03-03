// this is just a dummy stub to allow the existing code to compile (it is not used)

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Buffers2 {
    internal class ThrowHelper {
        internal static void ThrowArgumentOutOfRangeException(object count) {
            throw new NotImplementedException();
        }

        internal static void ThrowArgumentOutOfRangeException_OffsetOutOfRange() {
            throw new NotImplementedException();
        }
    }
    internal class ExceptionArgument {
        internal const string count = nameof(count);
    }
}