using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ArktiPhonesDatabaseUploader {
    class DbDownloader {
        public static void Test (string targetDb, int set) {
            var repo = new SqlDbRepository ();
            var startTime = DateTime.Now;

            // Console.WriteLine ($"Started uploading of devices at rate of  per transaction\n");
            // File.AppendAllText ("results.csv", $"Download speed Testing\n");
            // File.AppendAllText("results.csv", "No,TimeInMilliseconds\n");

            System.Console.WriteLine ("Getting devices");

            var devices = repo.GetDevices ();
            // System.Console.WriteLine ("Devices got");
            var devicesList = devices.ToList ();
            JsonConvert.SerializeObject (devices, new JsonSerializerSettings () { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            // System.Console.WriteLine ("Devices serialized");
            var value = Math.Floor ((DateTime.Now - startTime).TotalMilliseconds).ToString ();
            File.AppendAllText ("results.csv", $"{targetDb},Download,{set},1,{value}\n");

            startTime = DateTime.Now;
            var data = repo.GetDevices ()
                .Where (p => p.Status.ReleasedDate.Year != null)
                .OrderByDescending (p => p.Status.ReleasedDate.Year)
                .GroupBy (p => p.Status.ReleasedDate.Year)
                .Select (p => new {
                    Year = p.Key.ToString (),
                        Memory = p
                        .Where (ph => ph.Memory.RandomAccess.HasValue)
                        .GroupBy (ph => ph.Memory.RandomAccess > 1000 ? $"{ph.Memory.RandomAccess/1024}GB" : $"<1GB")
                        .Select (ph => new {
                            RamInMB = ph.Key,
                                PhonesAmount = ph.Select (d => d.Memory.RandomAccess).Count (),
                                Phones = ph.Select (d => d.Name)
                        })
                })
                .ToList ();
            JsonConvert.SerializeObject (data, new JsonSerializerSettings () { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            value = Math.Floor ((DateTime.Now - startTime).TotalMilliseconds).ToString ();
            File.AppendAllText ("results.csv", $"{targetDb},RAM,{set},1,{value}\n");
            Console.WriteLine ($"Query done in ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
            // File.AppendAllText ("results.csv", $" done in ~{(DateTime.Now - startTime):mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}