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
        public string Name { get; set; }
        [JsonProperty("levelArr")]
        public int[] LevelArr { get; set; }
        [JsonProperty("isCastom")]
        public bool IsCastom { get; set; }
        [JsonProperty("isNoClip")]
        public bool isNoClip { get; set; }
        [JsonProperty("isOnTime")]
        public bool isOnTime { get; set; }


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
