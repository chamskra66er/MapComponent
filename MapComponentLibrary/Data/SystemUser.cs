﻿
namespace MapComponentLibrary.Data
{
    public class SystemUser:IUser
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
