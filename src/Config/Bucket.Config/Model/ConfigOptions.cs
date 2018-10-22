﻿namespace Bucket.Config
{
    public class ConfigOptions
    {
        public string AppId { set; get; }
        public string AppSercet { set; get; }
        public string NamespaceName { set; get; }
        public string Env { set; get; } = "pro";
        public string ServerUrl { set; get; }

        public int RefreshInteval { set; get; }
        public bool RedisListener { set; get; }
        public string RedisConnectionString { set; get; }

        public bool UseServiceDiscovery { set; get; }
        public string ServiceName { set; get; }
    }
}