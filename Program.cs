using System;
using System.Collections.Generic;
using CommandLine;

namespace base64_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine.Parser.Default.ParseArguments<Options>(args)
                .WithParsed(RunOptions)
                .WithNotParsed(RunUnparsed);
        }

        static void RunOptions(Options opts)
        {
            if (opts.Input.Length > 0)
            {
                if (opts.Compress)
                {
                    string compressed = LZString.compressToBase64(opts.Input);
                    Console.WriteLine("Compressed: " + compressed);
                }
                if (opts.Decompress)
                {
                    string decompressed = LZString.decompressFromBase64(opts.Input);
                    Console.WriteLine("Decompressed: " + decompressed);
                }
                if (opts.Encode)
                {
                    byte[] strBytes = System.Text.Encoding.UTF8.GetBytes(opts.Input);
                    string base64Str = System.Convert.ToBase64String(strBytes);

                    Console.WriteLine("Encoded: " + base64Str);
                }
                if (opts.Decode)
                {
                    byte[] base64Bytes = System.Convert.FromBase64String(opts.Input);
                    string str = System.Text.Encoding.UTF8.GetString(base64Bytes);

                    Console.WriteLine("Decoded: " + str);
                }
            }
        }

        static void RunUnparsed(IEnumerable<Error> errors)
        {
            // Ignore.
        }
    }
}
