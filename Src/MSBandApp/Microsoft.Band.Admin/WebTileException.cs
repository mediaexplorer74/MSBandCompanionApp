﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Admin.WebTileException
// Assembly: Microsoft.Band.Admin, Version=1.3.31002.2, Culture=neutral, PublicKeyToken=null
// MVID: 366705DD-0763-47F9-B6A9-5EDF88598091
// Assembly location: D:\Documents\REProj\MicrosoftBand\HealthApp.WindowsPhone_1.3.31002.2_ARM\Microsoft.Band.Admin.dll

using System;

namespace Microsoft.Band.Admin
{
    public class WebTileException : Exception
    {
        public WebTileException()
        {
        }

        public WebTileException(string message)
          : base(message)
        {
        }

        public WebTileException(string message, Exception innerException)
          : base(message, innerException)
        {
        }
    }
}
