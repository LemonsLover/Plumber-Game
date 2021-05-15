using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Plumber_Game
{
    class Level
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("levelArr")]
        public int[] LevelArr { get; set; }

        public Level(string Name, int[] LevelArr)
        {
            this.Name = Name;
            this.LevelArr = LevelArr;
        }
    }
}
