﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Admin.CargoGuidedWorkoutStatistics
// Assembly: Microsoft.Band.Admin, Version=1.3.31002.2, Culture=neutral, PublicKeyToken=null
// MVID: 366705DD-0763-47F9-B6A9-5EDF88598091
// Assembly location: D:\Documents\REProj\MicrosoftBand\HealthApp.WindowsPhone_1.3.31002.2_ARM\Microsoft.Band.Admin.dll

using System;

namespace Microsoft.Band.Admin
{
    public sealed class CargoGuidedWorkoutStatistics
    {
        private static readonly int serializedByteCount = CargoFileTime.GetSerializedByteCount() + 2 + 4 + 4 + 4 + 4 + CargoFileTime.GetSerializedByteCount() + 4;

        private CargoGuidedWorkoutStatistics()
        {
        }

        public DateTime Timestamp { get; private set; }

        public ushort Version { get; private set; }

        public uint Duration { get; private set; }

        public uint Calories { get; private set; }

        public uint AverageHeartrate { get; private set; }

        public uint MaximumHeartrate { get; private set; }

        public DateTime EndTime { get; private set; }

        public uint RoundsCompleted { get; private set; }

        public static int GetSerializedByteCount() => CargoGuidedWorkoutStatistics.serializedByteCount;

        public static CargoGuidedWorkoutStatistics DeserializeFromBand(
          ICargoReader reader)
        {
            return new CargoGuidedWorkoutStatistics()
            {
                Timestamp = CargoFileTime.DeserializeFromBandAsDateTime(reader),
                Version = reader.ReadUInt16(),
                Duration = reader.ReadUInt32(),
                Calories = reader.ReadUInt32(),
                AverageHeartrate = reader.ReadUInt32(),
                MaximumHeartrate = reader.ReadUInt32(),
                EndTime = CargoFileTime.DeserializeFromBandAsDateTime(reader),
                RoundsCompleted = reader.ReadUInt32()
            };
        }
    }
}
