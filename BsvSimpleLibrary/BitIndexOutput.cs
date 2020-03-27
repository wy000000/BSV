﻿using Newtonsoft.Json;

namespace BsvSimpleLibrary
{
    public class BitIndexOutput
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }

        //[JsonProperty("valueSat")]
        //public long ValueSatoshis { get; set; }

        [JsonProperty("n")]
        public uint N { get; set; }

        [JsonProperty("scriptPubKey")]
        public BitIndexScriptPubKey ScriptPubKey { get; set; }

        //[JsonProperty("spentTxId")]
        //public string SpentTxId { get; set; }

        //[JsonProperty("spentIndex")]
        //public int? SpentIndex { get; set; }

        //[JsonProperty("spentHeight")]
        //public long? SpentHeight { get; set; }
    }
}