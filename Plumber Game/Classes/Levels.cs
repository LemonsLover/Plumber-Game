using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Plumber_Game
{
    class Levels
    {
        public static List<Level> GameLevelsList = new List<Level>()
        {
            new Level("generated" ,new int[] {     3, 0, 0, 0, 0,
                                            0, 0, 0, 0, 0,
                                            0, 0, 0, 0, 0,
                                            0, 0, 0, 0, 0,
                                            0, 0, 0, 0, 1  },false, true),

            new Level("1" ,new int[] {     3, 8, 0, 0, 0,
                                            0, 10, 0, 0, 0,
                                            0, 6, 8, 0, 0,
                                            0, 0, 10, 7, 8,
                                            0, 0, 6, 5, 2 }),

            new Level("2" ,new int[] {   3, 9, 9, 8, 0,
                                            0, 7, 9, 5, 0,
                                            0, 6, 9, 8, 0,
                                            6, 0, 7, 5, 0,
                                            0, 0, 6, 9, 1 }),

            new Level("3" ,new int[] {    7, 8, 0, 0, 0,
                                            2, 6, 8, 0, 0,
                                            0, 0, 6, 8, 0,
                                            6, 0, 0, 6, 8,
                                            0, 0, 0, 0, 2 }),

             new Level("4" ,new int[] {   0, 0, 0, 7, 1,
                                            0, 0, 0, 6, 8,
                                            0, 7, 8, 7, 5,
                                            7, 5, 6, 5, 0,
                                            2, 0, 0, 0, 0 }),

            new Level("5" ,new int[] {    3, 9, 5, 0, 0,
                                            0, 0, 5, 9, 5,
                                            5, 9, 9, 9, 5,
                                            9, 4, 0, 0, 0,
                                            5, 5, 0, 0, 0 }),

            new Level("6" ,new int[] {    3, 5, 11, 5, 1,
                                            5, 5, 11, 9, 0,
                                            5, 9, 9, 5, 0,
                                            0, 0, 11, 0, 0,
                                            0, 0, 11, 0, 0 }),

            new Level("7" ,new int[] {    4, 5, 9, 5, 0,
                                            5, 5, 11, 9, 11,
                                            11, 5, 0, 9, 0,
                                            0, 9, 5, 5, 0,
                                            0, 3, 5, 0, 0  }),

            new Level("8" ,new int[] {    5, 9, 9, 9, 1,
                                            5, 5, 5, 11, 14,
                                            11, 9, 11, 11, 17,
                                            5, 5, 5, 11, 13,
                                            5, 9, 9, 9, 1  }),

            new Level("9" ,new int[] {    5, 5, 5, 5, 4,
                                            9, 5, 5, 5, 5,
                                            9, 11, 11, 11, 11,
                                            9, 5, 5, 5, 5,
                                            5, 5, 5, 5, 2 }),

            new Level("10" ,new int[] {   4, 0, 0, 0, 4,
                                            9, 11, 0, 11, 9,
                                            5, 9,  5, 11, 9,
                                            0, 11, 9, 11, 9,
                                            11, 0, 5, 9, 5  }),

            new Level("11" ,new int[] {    14, 12, 0, 13, 15,
                                            12, 0, 5, 5, 13,
                                            3, 15,  9, 13, 1,
                                            15, 5, 5, 0, 14,
                                            13, 15, 0, 14, 12  }),

            new Level("12" ,new int[] {    0,  4,  0,  4, 0,
                                            5, 12, 16, 13, 5,
                                            5, 15, 11, 14, 5,
                                            5,  5,  0,  5, 5,
                                            5,  9,  16,  9, 5  }),

            new Level("13" ,new int[] {   14, 9, 5, 0, 15,
                                            9, 0, 2, 0, 0,
                                            13, 9, 16, 9, 15,
                                            0, 0, 4, 0, 9,
                                            13, 0, 5, 9, 12  }),

            new Level("14" ,new int[] {    4, 0, 16, 16, 5,
                                            5, 5, 16, 5, 5,
                                            0, 17, 11, 17, 9,
                                            5, 12, 16, 9, 9,
                                            5, 9, 9, 5, 2  }),

            new Level("15" ,new int[] {    0,  0,  0,  0, 4,
                                            5,  5,  5,  5, 9,
                                            9, 17, 17, 17, 9,
                                            9,  5,  5,  9, 9,
                                            2,  0,  0,  13, 5  }),

            new Level("16" ,new int[] {    4, 0, 11, 0, 5,
                                            12, 0, 11, 0, 5,
                                            9, 5, 11, 0, 0,
                                            0, 9, 11, 5, 16,
                                            9, 5, 11, 5, 1  },false, true),

            new Level("17" ,new int[] {    1, 5, 5, 0, 3,
                                            9, 5, 9, 0, 0,
                                            0, 0, 9, 0, 0,
                                            5, 5, 9, 5, 9,
                                            12, 5, 5, 5, 16  },false, true),

            new Level("18" ,new int[] {    3, 5, 0, 13, 5,
                                            9, 5, 5, 9, 5,
                                            16, 16, 5, 16, 16,
                                            5, 5, 9, 5, 9,
                                            5, 5, 5, 5, 1  },false, true),

            new Level("19" ,new int[] {    9, 5, 11, 5, 9,
                                            9, 5, 11, 5, 1,
                                            11, 11, 11, 11, 11,
                                            3, 5, 11, 5, 9,
                                            9, 5, 11, 5, 9},false, true),

            new Level("20" ,new int[] {    1, 3, 9, 15, 7,
                                            9, 16, 9, 7, 9,
                                            5, 9,  9, 5, 13,
                                            5, 5, 5, 9, 14,
                                            9, 12, 5, 12, 6 },false, true)

    };

        public static List<Level> CastomLevelsList = new List<Level>();

        public static List<Level> CorrectlevelList = GameLevelsList;

        public static int LevelAmount = Levels.GameLevelsList.Count - 1;
        public static int CorrectLevelId = 1;
        public static int AvailableLevel = Properties.Settings.Default.avalibleLevel;

        static Levels()
        {
            if (!File.Exists("levels.json"))
                File.Create("levels.json").Close();

            else
                CastomLevelsList = GetCustomLevels();
        }

        public static void ChangeCorrectLevelList(bool isCustomMode)
        {
            if(isCustomMode)
                CorrectlevelList = CastomLevelsList;
            else
                CorrectlevelList = GameLevelsList;
        }

        public static void AddLevel(Level level)
        {
            CastomLevelsList.Add(level);

            File.WriteAllText("levels.json", JsonConvert.SerializeObject(CastomLevelsList));
        }

        public static List<Level> GetCustomLevels()
        {
            try
            {
                List<Level> levels = JsonConvert.DeserializeObject<List<Level>>(File.ReadAllText("levels.json"));
                return levels != null ? levels : new List<Level>();
            }
            catch
            {
                DialogResult userAns = MessageBox.Show("Ошибка при считовании файла ! Очистить содержимое ?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userAns == DialogResult.Yes)
                {
                    File.Delete("levels.json");
                    File.Create("levels.json").Close();
                }
                return new List<Level>();
            }
        }
    }
}
