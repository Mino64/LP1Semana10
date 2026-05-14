using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcadeLog
{
    public class ScoreByNameComparer : IComparer<Score>
    {
        public int Compare(Score x, Score y)
        {
            switch (x.Name.CompareTo(y.Name))
            {
                case > 0:
                    return 1;

                case < 0:
                    return -1;
                    
                default:
                    return 0;
            }
        }
    }
}