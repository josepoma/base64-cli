using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace base64_cli.Parser
{
    class Options
    {
        [Option('i', "input", Required = true, HelpText = "Input string")]
        public string Input { get; set; }

        [Option('c', "compress", Required = false, HelpText = "Compress string to base64")]
        public bool Compress { get; set; }

        [Option('d', "decompress", Required = false, HelpText = "Decompress base64 string")]
        public bool Decompress { get; set; }

        [Option('E', "encode", Required = false, HelpText = "Encode string to base64")]
        public bool Encode { get; set; }

        [Option('D', "decode", Required = false, HelpText = "Decode string from base64")]
        public bool Decode { get; set; }
    }
}
