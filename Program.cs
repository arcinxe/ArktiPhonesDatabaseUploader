using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

namespace ArktiPhonesDatabaseUploader {
    class Program {
        static void Main (string[] args) {
            // if (args.Length > 0) System.Console.WriteLine(args[0]);
            // if (args.Length > 1) System.Console.WriteLine(args[1]);
            var startTime = DateTime.Now;
            Console.CancelKeyPress += delegate {
                System.Console.WriteLine ($"\nCancelled after: ~{(DateTime.Now - startTime):hh\\h\\:mm\\m\\:ss\\s\\:fff\\m\\s}!");
                // File.AppendAllText("results.csv", $"\nAborted in: ~{(DateTime.Now - startTime):hh\\h\\:mm\\m\\:ss\\s\\:fff\\m\\s}!");
            };
            var targetDb = args.ElementAtOrDefault (1) != null ? args.ElementAtOrDefault (1) : "";
            var set = int.TryParse (args.ElementAtOrDefault (2), out var res) && res > 0 ? res : 1;
            // File.AppendAllText("results.csv", $"\nStarted at {startTime}{(targetDb!=""?" using "+targetDb:"")}\n");
            System.Console.WriteLine ($"Started at {startTime}{(targetDb!=""?" using "+targetDb:"")}");
            var devices = new FileLoader ().LoadDevices ();
            DbUploader.Upload (devices, int.TryParse (args.ElementAtOrDefault (0), out var result) && result > 0 ? result : 1000, targetDb, set);
            DbDownloader.Test (targetDb, set);
            System.Console.WriteLine ($"Done in: ~{(DateTime.Now - startTime):hh\\h\\:mm\\m\\:ss\\s\\:fff\\m\\s}!");
        }
    }
}