using System.Diagnostics;
using System.Threading.Tasks;

namespace Microsoft.Band.Admin.Phone;

public class BandAdminClientManager : BandAdminClientManagerBase, IBandAdminClientManager
{
    private static readonly BandAdminClientManager instance = new BandAdminClientManager();

    private const int MaximumBluetoothConnectAttempts = 3;

    public static IBandAdminClientManager Instance => ConcreteInstance;

    public static BandAdminClientManager ConcreteInstance => instance;

    private BandAdminClientManager()
    {
    }

    public override async Task<CargoClient> ConcreteConnectAsync(IBandInfo bandInfo)
    {
        BluetoothTransport bluetoothTransport = null;
        CargoClient client = null;
        try
        {
            Stopwatch connectTime = Stopwatch.StartNew();
            LoggerProvider loggerProvider = new LoggerProvider();
            PhoneProvider phoneProvider = new PhoneProvider();
            bluetoothTransport = await BluetoothTransport.CreateAsync(bandInfo, loggerProvider, MaximumBluetoothConnectAttempts);
            client = new CargoClient(bluetoothTransport, null, loggerProvider, phoneProvider, StoreApplicationPlatformProvider.Current);
            client.InitializeCachedProperties();
            loggerProvider.Log(ProviderLogLevel.Info, $"BandAdminClientManager.ConcreteConnectAsync(IBandInfo bandinfo) succeeded: Elapsed: {connectTime.Elapsed}");
            return client;
        }
        catch
        {
            if (client != null)
            {
                client.Dispose();
            }
            else
            {
                bluetoothTransport?.Dispose();
            }
            throw;
        }
    }

    public override async Task<CargoClient> ConcreteConnectAsync(IBandInfo bandInfo, string userId)
    {
        BluetoothTransport bluetoothTransport = null;
        CargoClient client = null;
        try
        {
            Stopwatch connectTime = Stopwatch.StartNew();
            LoggerProvider loggerProvider = new LoggerProvider();
            PhoneProvider phoneProvider = new PhoneProvider();
            bluetoothTransport = await BluetoothTransport.CreateAsync(bandInfo, loggerProvider, 3);
            client = new CargoClient(bluetoothTransport, null, loggerProvider, phoneProvider, StoreApplicationPlatformProvider.Current);
            client.InitializeCachedProperties();
            StorageProvider storageProvider = StorageProvider.Create(userId, client.DeviceUniqueId.ToString("N"));
            client.InitializeStorageProvider(storageProvider);
            loggerProvider.Log(ProviderLogLevel.Info, $"BandAdminClientManager.ConcreteConnectAsync(IBandInfo bandInfo, string userId) succeeded: Elapsed: {connectTime.Elapsed}");
            return client;
        }
        catch
        {
            if (client != null)
            {
                client.Dispose();
            }
            else
            {
                bluetoothTransport?.Dispose();
            }
            throw;
        }
    }

    public override async Task<CargoClient> ConcreteConnectAsync(IBandInfo bandInfo, ServiceInfo serviceInfo)
    {
        BluetoothTransport bluetoothTransport = null;
        CargoClient client = null;
        try
        {
            Stopwatch connectTime = Stopwatch.StartNew();
            LoggerProvider loggerProvider = new LoggerProvider();
            PhoneProvider phoneProvider = new PhoneProvider();
            bluetoothTransport = await BluetoothTransport.CreateAsync(bandInfo, loggerProvider, 3);
            CloudProvider cloudProvider = new CloudProvider(serviceInfo);
            client = new CargoClient(bluetoothTransport, cloudProvider, loggerProvider, phoneProvider, StoreApplicationPlatformProvider.Current);
            client.InitializeCachedProperties();
            cloudProvider.SetUserAgent(phoneProvider.GetDefaultUserAgent(client.FirmwareVersions), appOverride: false);
            StorageProvider storageProvider = StorageProvider.Create(serviceInfo.UserId, client.DeviceUniqueId.ToString("N"));
            client.InitializeStorageProvider(storageProvider);
            loggerProvider.Log(ProviderLogLevel.Info, $"BandAdminClientManager.ConcreteConnectAsync(IBandInfo bandInfo, ServiceInfo serviceInfo) succeeded: Elapsed: {connectTime.Elapsed}");
            return client;
        }
        catch
        {
            if (client != null)
            {
                client.Dispose();
            }
            else
            {
                bluetoothTransport?.Dispose();
            }
            throw;
        }
    }
}
