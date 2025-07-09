using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppiumTests.Utils
{
    internal static class ApkDownloader
    {
        private const string ApkUrl = "https://github.com/appium-pro/TheApp/releases/download/v1.12.0/TheApp.apk";
        private const string ApkFileName = "TheApp.apk";

        public static async Task<string> DownloadApkAsync()
        {
            var apkPath = Path.Combine(Directory.GetCurrentDirectory(), ApkFileName);
            if (File.Exists(apkPath))
                return apkPath;

            using var client = new HttpClient();
            var apkBytes = await client.GetByteArrayAsync(ApkUrl);
            await File.WriteAllBytesAsync(apkPath, apkBytes);
            return apkPath;
        }
    }
}
