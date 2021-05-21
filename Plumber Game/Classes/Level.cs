using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Plumber_Game
{
    public class Level
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("levelArr")]
        public int[] LevelArr;
        [JsonProperty("isCastom")]
        public readonly bool IsCastom;
        [JsonProperty("isNoClip")]
        public readonly bool isNoClip;
        [JsonProperty("isOnTime")]
        public readonly bool isOnTime;


        public Level(string Name, int[] LevelArr, bool isCastom = false, bool isNoClip = false, bool isOnTime = true)
        {
            this.Name = Name;
            this.LevelArr = LevelArr;
            this.IsCastom = isCastom;
            this.isNoClip = isNoClip;
            this.isOnTime = isOnTime;
        }
    }
}
