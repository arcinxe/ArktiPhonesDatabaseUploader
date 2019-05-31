using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ArktiPhonesDatabaseUploader {
    class DbUploader {
        public static void Upload(List<DeviceDetailDefault> devices, int insertsPerTransaction) {
            var repo = new SqlDbRepository();
            var converter = new DeviceDetailConvert();
            Console.WriteLine("Converting started!");
            var deviceToInsert = devices.Select(d => converter.Convert(d)).Take(1000).ToList();
            Console.WriteLine("Converting done!");

            int count = deviceToInsert.Count();
            Console.WriteLine($"Started uploading of {deviceToInsert.Count} devices at rate of {insertsPerTransaction} per transaction\n");
            File.AppendAllText("results.csv", $"Started uploading of {deviceToInsert.Count} devices at rate of {insertsPerTransaction} per transaction\n");
            File.AppendAllText("results.csv", "No,TimeInMilliseconds\n");
            var value = "";
            var totalTransactions = count / insertsPerTransaction + 1;
            var startTime = DateTime.Now;
            for (var i = 0; i < (count / insertsPerTransaction) + 1; i++) {
                var subStartTime = DateTime.Now;
                repo.AddDevices(deviceToInsert.Skip(i * insertsPerTransaction).Take(insertsPerTransaction));
                value = Math.Floor((DateTime.Now - subStartTime).TotalMilliseconds).ToString();
                File.AppendAllText("results.csv", (i + 1) + "," + value + "\n");
                Console.Write($"{((double)(i + 1) / totalTransactions * 100).ToString("00.00")}% - {i + 1} out of {totalTransactions} done");
                Console.WriteLine($" {(DateTime.Now - subStartTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
            }

            Console.WriteLine($"{count / insertsPerTransaction + 1} transactions done in ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
            File.AppendAllText("results.csv", $"{count / insertsPerTransaction + 1} transactions done in ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}
