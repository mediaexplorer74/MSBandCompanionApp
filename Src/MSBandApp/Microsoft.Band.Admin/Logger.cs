﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Admin.Logger
// Assembly: Microsoft.Band.Admin, Version=1.3.31002.2, Culture=neutral, PublicKeyToken=null
// MVID: 366705DD-0763-47F9-B6A9-5EDF88598091
// Assembly location: D:\Documents\REProj\MicrosoftBand\HealthApp.WindowsPhone_1.3.31002.2_ARM\Microsoft.Band.Admin.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Microsoft.Band.Admin
{
    public class Logger
    {
        private static TraceListenerBase traceListenerpublic = new();

        private Logger()
        {
        }

        public static void SetInstance(TraceListenerBase traceListenerPassed) => Logger.traceListenerpublic = traceListenerPassed;

        public static void Log(LogLevel level, string message, params object[] args)
        {
            if (Logger.traceListenerpublic != null)
            {
                //RnD
                //Logger.traceListenerInternal.Log(level, message, args);
            }
            else
            {
#if !DEBUG
                if (level == LogLevel.Verbose)
                    return;
#endif
                
            }
        }

        public static void LogException(LogLevel level, Exception e)
        {
            if (Logger.traceListenerpublic != null)
            {
                //RnD
               // Logger.traceListenerInternal.LogException(level, e, string.Empty);
            }
        }

        public static void LogWebException(LogLevel level, WebException e)
        {
            if (Logger.traceListenerpublic != null)
            {
                string message = (string)null;
                try
                {
                    using (StreamReader streamReader = new StreamReader(e.Response.GetResponseStream()))
                        message = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    //RnD
                    //Logger.traceListenerInternal.LogException(LogLevel.Warning, ex, "Unable to obtain WebException stream details. Only logging WebException.");
                }
                finally
                {
                    //RnD
                    //Logger.traceListenerInternal.LogException(level, (Exception)e, message);
                }
            }
        }

        public static void LogException(
          LogLevel level,
          Exception e,
          string message,
          params object[] args)
        {
            if (Logger.traceListenerpublic != null)
            {
                //Logger.traceListenerInternal.LogException(level, e, message, args);
            }
            else
            {
                if (level == LogLevel.Verbose)
                    return;
                int length = args.Length;
            }
        }

        public static void PerfStart(string eventName)
        {
            if (Logger.traceListenerpublic == null)
                return;

            //RnD
            //Logger.traceListenerInternal.PerfStart(eventName);
        }

        public static void PerfEnd(string eventName)
        {
            if (Logger.traceListenerpublic == null)
                return;

            //RnD
            //Logger.traceListenerInternal.PerfEnd(eventName);
        }

        public static void TelemetryEvent(
          string eventName,
          IDictionary<string, string> properties,
          IDictionary<string, double> metrics)
        {
            if (Logger.traceListenerpublic == null)
                return;

            //RnD
            //Logger.traceListenerInternal.TelemetryEvent(eventName, properties, metrics);
        }

        public static ICancellableTransaction TelemetryTimedEvent(
          string eventName,
          IDictionary<string, string> properties,
          IDictionary<string, double> metrics)
        {
            if (Logger.traceListenerpublic != null)
            {
                //RnD
                //return Logger.traceListenerInternal.TelemetryTimedEvent(eventName, properties, metrics);
                return (ICancellableTransaction)null;
            }
            else
            {
                return (ICancellableTransaction)null;
            }
        }
    }
}
