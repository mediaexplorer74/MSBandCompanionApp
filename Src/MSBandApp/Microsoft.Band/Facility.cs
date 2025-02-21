﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Band.Facility
// Assembly: Microsoft.Band, Version=1.3.20517.1, Culture=neutral, PublicKeyToken=null
// MVID: AFCBFE03-E2CF-481D-86F4-92C60C36D26A
// Assembly location: C:\Users\Pdawg\Downloads\Microsoft Band Sync Setup\Microsoft_Band.dll

namespace Microsoft.Band
{
    public enum Facility : byte
    {
        Invalid = 0,
        Min = 0,
        ReservedBase = 1,
        ReservedEnd = 31, // 0x1F
        DriverDma = 32, // 0x20
        DriversBase = 32, // 0x20
        DriverBtle = 33, // 0x21
        DriverPdb = 34, // 0x22
        DriverI2c = 35, // 0x23
        DriverAdc = 36, // 0x24
        DriverGpio = 37, // 0x25
        DriverDac = 38, // 0x26
        DriverAnalogMgr = 39, // 0x27
        DriverRtc = 40, // 0x28
        DriverMotor = 41, // 0x29
        DriverDisplay = 43, // 0x2B
        DriverUartAsync = 44, // 0x2C
        DriverPmu = 45, // 0x2D
        DriverExternalRam = 46, // 0x2E
        DriverAls = 47, // 0x2F
        DriverTimers = 48, // 0x30
        DriverFlexBus = 49, // 0x31
        DriverSpi = 50, // 0x32
        DriverEFlash = 51, // 0x33
        DriverPwm = 52, // 0x34
        DriverCrc = 53, // 0x35
        DriverPFlash = 54, // 0x36
        DriverFpu = 55, // 0x37
        DriverWatchDog = 56, // 0x38
        DriverCoreModule = 57, // 0x39
        DriverCrashDump = 58, // 0x3A
        DriverUsb = 59, // 0x3B
        DriverMmcau = 60, // 0x3C
        DriversEnd = 111, // 0x6F
        LibrariesBase = 112, // 0x70
        LibraryDebug = 112, // 0x70
        LibraryRuntime = 113, // 0x71
        LibraryUsbCmdProtocol = 114, // 0x72
        LibraryBTPS = 115, // 0x73
        LibraryTouch = 116, // 0x74
        LibraryTime = 117, // 0x75
        LibraryJutil = 118, // 0x76
        LibraryHRManager = 119, // 0x77
        LibraryConfiguration = 120, // 0x78
        LibraryButton = 121, // 0x79
        LibraryBacklight = 122, // 0x7A
        LibraryMotion = 123, // 0x7B
        LibraryActMon = 124, // 0x7C
        LibraryBattery = 125, // 0x7D
        LibraryGps = 126, // 0x7E
        LibraryHRLed = 127, // 0x7F
        LibraryDfu = 128, // 0x80
        LibraryHeartRate = 129, // 0x81
        LibraryMicrophone = 131, // 0x83
        LibraryGsr = 132, // 0x84
        LibraryUV = 133, // 0x85
        LibrarySkinTemp = 134, // 0x86
        LibraryAmbTemp = 135, // 0x87
        LibraryPedometer = 136, // 0x88
        LibraryCalories = 137, // 0x89
        LibraryDistance = 138, // 0x8A
        LibraryAlgoMath = 139, // 0x8B
        LibraryLogger = 140, // 0x8C
        LibraryPeg = 141, // 0x8D
        LibraryFile = 142, // 0x8E
        LibraryRemoteSubscription = 143, // 0x8F
        LibraryPower = 144, // 0x90
        LibraryUVExposure = 145, // 0x91
        LibraryMinuteTimer = 146, // 0x92
        LibraryRecovery = 147, // 0x93
        LibrarySubscriptionBase = 148, // 0x94
        LibraryDateChangeSubscription = 149, // 0x95
        LibraryHREstimator = 150, // 0x96
        LibraryUSBConnection = 151, // 0x97
        LibrarySRAMFWUpdate = 152, // 0x98
        LibraryAutoBrightness = 153, // 0x99
        LibraryHaptic = 154, // 0x9A
        LibraryFitnessPlans = 155, // 0x9B
        LibrarySleepRecovery = 156, // 0x9C
        LibraryFirstBeat = 157, // 0x9D
        LibraryAncsNotificationCache = 158, // 0x9E
        LibraryKeyboard = 159, // 0x9F
        LibraryHrAccelSync = 160, // 0xA0
        LibraryGolf = 161, // 0xA1
        ModuleOobe = 173, // 0xAD
        LibrariesEnd = 191, // 0xBF
        ModuleMain = 192, // 0xC0
        ModulesBase = 192, // 0xC0
        ModuleBehavior = 193, // 0xC1
        ModuleFireballTransportLayer = 194, // 0xC2
        ModuleFireballUI = 195, // 0xC3
        ModuleFireballUtilities = 196, // 0xC4
        ModuleProfile = 197, // 0xC5
        ModuleLoggerSubscriptions = 198, // 0xC6
        ModuleFireballTilesModels = 199, // 0xC7
        ModulePowerManager = 200, // 0xC8
        ModuleHrPowerManager = 201, // 0xC9
        ModuleSystemSettings = 202, // 0xCA
        ModuleFireballHardwareManager = 203, // 0xCB
        ModuleNotification = 204, // 0xCC
        ModuleFtlTouchManager = 205, // 0xCD
        ModulePersistedStatistics = 206, // 0xCE
        ModuleAlgorithms = 207, // 0xCF
        ModulePersistedApplicationData = 208, // 0xD0
        ModuleDeviceContact = 209, // 0xD1
        ModuleInstrumentation = 210, // 0xD2
        ModuleFireballAppsManagement = 211, // 0xD3
        ModuleInstalledAppList = 212, // 0xD4
        ModuleFireballPageManagement = 213, // 0xD5
        ModuleUnitTests = 214, // 0xD6
        ModuleBatteryGauge = 215, // 0xD7
        ModuleThemeColor = 216, // 0xD8
        ModuleGoalTracker = 217, // 0xD9
        ModuleKfrost = 218, // 0xDA
        ModulePal = 219, // 0xDB
        ModuleGestures = 220, // 0xDC
        ModuleCortana = 221, // 0xDD
        ModuleVoicePush = 222, // 0xDE
        ModulesEnd = 223, // 0xDF
        ApplicationMain = 224, // 0xE0
        ApplicationsBase = 224, // 0xE0
        Application1BL = 225, // 0xE1
        Application2UP = 226, // 0xE2
        ApplicationsEnd = 239, // 0xEF
        Reserved2Base = 240, // 0xF0
        Max = 255, // 0xFF
        Reserved2End = 255, // 0xFF
    }
}
