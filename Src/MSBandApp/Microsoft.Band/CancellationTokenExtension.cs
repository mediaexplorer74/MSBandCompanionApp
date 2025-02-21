﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.CancellationTokenExtension
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

using System;
using System.Threading;

namespace Microsoft.Band
{
    public static class CancellationTokenExtension
    {
        public static void WaitAndThrowIfCancellationRequested(this CancellationToken token, TimeSpan timeout)
        {
            token.WaitHandle.WaitOne(timeout);
            token.ThrowIfCancellationRequested();
        }

        public static void WaitAndThrowIfCancellationRequested(this CancellationToken token, int timeout)
        {
            token.WaitHandle.WaitOne(timeout);
            token.ThrowIfCancellationRequested();
        }
    }
}
