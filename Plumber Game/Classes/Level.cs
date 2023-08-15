using Newtonsoft.Json;

namespace Plumber_Game
{
    public class Level
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("levelArr")]
        public int[] LevelArr;
        [JsonIgnore]
        public bool IsCustom = false;
        [JsonProperty("isNoClip")]
        public readonly bool IsNoClip;
        [JsonProperty("isOnTime")]
        public readonly bool IsOnTime;


        public Level(string name, int[] levelArr, bool isCustom = false, bool isNoClip = false, bool isOnTime = true)
        {
            Name = name;
            LevelArr = levelArr;
            IsCustom = isCustom;
            IsNoClip = isNoClip;
            IsOnTime = isOnTime;
        }
    }
}
