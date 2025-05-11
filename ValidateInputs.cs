using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_TerrariaBossInfo_AKG
{
    public class ValidateInputs
    {
        public static bool IsValidSelection(int game, int boss, int difficulty)
        {
            return !int.IsNegative(game - 1)
            && !int.IsNegative(boss - 1)
            && !int.IsNegative(difficulty - 1);
        }
    }
}
