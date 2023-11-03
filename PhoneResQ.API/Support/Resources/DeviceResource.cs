﻿using PhoneResQ.API.Support.Domain.Models.Entities;

namespace PhoneResQ.API.Support.Resources
{
    public class DeviceResource
    {
        public int Id { get; set; }
        public long IMEI { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    public class SaveDeviceResource
    {
        public long IMEI { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int OwnerId { get; set; }
    }
}