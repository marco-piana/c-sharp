﻿namespace PubNubMessaging.Tests
{
    public static class PubnubCommon
    {
		public const bool PAMEnabled = true;
		public const bool EnableStubTest = false;

        //USE demo-36 keys for unit tests
        //public static readonly string PublishKey = "demo-36";
        //public static readonly string SubscribeKey = "demo-36";
        //public static readonly string SecretKey = "demo-36";
        public static readonly string PublishKey = "pub-c-38994634-9e05-4967-bc66-2ac2cef65ed9";
        public static readonly string SubscribeKey = "sub-c-c9710928-1b7a-11e3-a0c8-02ee2ddab7fe";
        public static readonly string SecretKey = "sec-c-ZDkzZTBkOTEtNTQxZS00MmQ3LTljMWUtMTNiNGZjNWUwMTVk";

        public static readonly string StubOrign = "localhost:9191";
        public static readonly string EncodedSDK = "PubNub%20CSharp%204.0";

        static PubnubCommon()
        {
        }
    }
}