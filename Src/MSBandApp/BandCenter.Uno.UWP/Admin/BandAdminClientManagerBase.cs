using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Band.Admin.Phone;

namespace Microsoft.Band.Admin;

public abstract class BandAdminClientManagerBase
{
    public async Task<IBandInfo[]> GetBandsAsync()
    {
        return await Task.Run(() => GetBands());
    }

    public IBandInfo[] GetBands()
    {
        return ConcreteGetBands();
    }

    public ICargoClient Connect(IBandInfo bandInfo)
    {
        return ConcreteConnect(bandInfo);
    }

    public async Task<ICargoClient> ConnectAsync(IBandInfo bandInfo)
    {
        return await ConcreteConnectAsync(bandInfo);
    }

    public ICargoClient Connect(ServiceInfo serviceInfo)
    {
        return ConcreteConnect(serviceInfo);
    }

    public Task<ICargoClient> ConnectAsync(ServiceInfo serviceInfo)
    {
        return Task.FromResult((ICargoClient)ConcreteConnect(serviceInfo));
    }

    public ICargoClient Connect(IBandInfo bandInfo, string userId)
    {
        return ConcreteConnect(bandInfo, userId);
    }

    public async Task<ICargoClient> ConnectAsync(IBandInfo bandInfo, string userId)
    {
        return await ConcreteConnectAsync(bandInfo, userId);
    }

    public ICargoClient Connect(string bandId, ServiceInfo serviceInfo)
    {
        return ConcreteConnect(bandId, serviceInfo);
    }

    public Task<ICargoClient> ConnectAsync(string bandId, ServiceInfo serviceInfo)
    {
        return Task.FromResult((ICargoClient)ConcreteConnect(bandId, serviceInfo));
    }

    public ICargoClient Connect(IBandInfo bandInfo, ServiceInfo serviceInfo)
    {
        return ConcreteConnect(bandInfo, serviceInfo);
    }

    public async Task<ICargoClient> ConnectAsync(IBandInfo bandInfo, ServiceInfo serviceInfo)
    {
        return await ConcreteConnectAsync(bandInfo, serviceInfo);
    }

    public Task<BluetoothDeviceInfo[]> ConcreteGetBandsAsync()
    {
        return Task.Run(() => ConcreteGetBands());
    }

    public BluetoothDeviceInfo[] ConcreteGetBands()
    {
        return ConcreteGetBands(new Guid("{A502CA97-2BA5-413C-A4E0-13804E47B38F}"));
    }

    public Task<BluetoothDeviceInfo[]> ConcreteGetBandsAsync(Guid service)
    {
        return Task.Run(() => ConcreteGetBands(service));
    }

    public BluetoothDeviceInfo[] ConcreteGetBands(Guid service)
    {
        return BluetoothTransport.GetConnectedDevices(service, new LoggerProvider());
    }

    public Task<CargoClient> ConcreteConnectAsync(ServiceInfo serviceInfo)
    {
        return Task.FromResult(ConcreteConnect(serviceInfo));
    }

    public CargoClient ConcreteConnect(ServiceInfo serviceInfo)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        LoggerProvider loggerProvider = new LoggerProvider();
        PhoneProvider phoneProvider = new PhoneProvider();
        CloudProvider cloudProvider = new CloudProvider(serviceInfo);
        CargoClient result = new CargoClient(null, cloudProvider, loggerProvider, phoneProvider, StoreApplicationPlatformProvider.Current);
        cloudProvider.SetUserAgent(phoneProvider.GetDefaultUserAgent(null), appOverride: false);
        loggerProvider.Log(ProviderLogLevel.Info, $"BandAdminClientManager.ConcreteConnect(ServiceInfo serviceInfo) succeeded: Elapsed: {stopwatch.Elapsed}");
        return result;
    }

    public CargoClient ConcreteConnect(IBandInfo bandInfo)
    {
        return ConcreteConnectAsync(bandInfo).Result;
    }

    public abstract Task<CargoClient> ConcreteConnectAsync(IBandInfo bandInfo);

    public CargoClient ConcreteConnect(IBandInfo bandInfo, string userId)
    {
        return ConcreteConnectAsync(bandInfo, userId).Result;
    }

    public abstract Task<CargoClient> ConcreteConnectAsync(IBandInfo bandInfo, string userId);

    public Task<CargoClient> ConcreteConnectAsync(string bandId, ServiceInfo serviceInfo)
    {
        return Task.FromResult(ConcreteConnect(bandId, serviceInfo));
    }

    public CargoClient ConcreteConnect(string bandId, ServiceInfo serviceInfo)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        LoggerProvider loggerProvider = new LoggerProvider();
        PhoneProvider phoneProvider = new PhoneProvider();
        CloudProvider cloudProvider = new CloudProvider(serviceInfo);
        CargoClient cargoClient = new CargoClient(null, cloudProvider, loggerProvider, phoneProvider, StoreApplicationPlatformProvider.Current);
        cargoClient.DeviceUniqueId = Guid.Parse(bandId);
        cargoClient.SerialNumber = null;
        cloudProvider.SetUserAgent(phoneProvider.GetDefaultUserAgent(null), appOverride: false);
        StorageProvider storageProvider = StorageProvider.Create(serviceInfo.UserId, cargoClient.DeviceUniqueId.ToString("N"));
        cargoClient.InitializeStorageProvider(storageProvider);
        loggerProvider.Log(ProviderLogLevel.Info, $"BandAdminClientManager.ConcreteConnect(string bandId, ServiceInfo serviceInfo) succeeded: Elapsed: {stopwatch.Elapsed}");
        return cargoClient;
    }

    public CargoClient ConcreteConnect(IBandInfo bandInfo, ServiceInfo serviceInfo)
    {
        return ConcreteConnectAsync(bandInfo, serviceInfo).Result;
    }

    public abstract Task<CargoClient> ConcreteConnectAsync(IBandInfo bandInfo, ServiceInfo serviceInfo);
}
