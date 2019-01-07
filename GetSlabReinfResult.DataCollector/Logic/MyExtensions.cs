using System.Collections.Generic;
using System.Linq;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public static class MyExtensions
    {
        public static string ToRobotSelectionString(this int[] sel) 
        {
            var selR = sel.ToList().OrderBy(x => x).ToList();

            var res = "";
            for (int i = 0; i < selR.Count(); i++)
            {
                if(i == selR.Count() - 1)
                    res += selR[i] + " ";
                else if(selR[i] + 1 != selR[i + 1])
                    res += selR[i] + " ";
                else
                {
                    var f = selR[i];
                    do
                    {
                        i++;
                        if (i == selR.Count() - 1) break;
                    } while (selR[i] + 1 == selR[i + 1]);
                    var s = selR[i];
                    res += f+"to"+s + " ";
                }
            }
            return res.Trim();
        }
        public static int[] ToIntArrayFromRobotStringSelection(this string sel) 
        {
            var section = sel.Split(' ');
            var clean=new List<int>();
            for (int i = 0; i < section.Length; i++)
            {
                int x;
                if (int.TryParse(section[i], out x))
                    clean.Add(x);
                else
                {
                    clean.AddRange(SplitNumToNum(section[i]));
                }
            }
            return clean.ToArray();
            
        }
        private static int[] SplitNumToNum(string sec)
        {
            var result = new List<int>();
            if (sec.Contains("to"))
            {
                var split = sec.Replace("to", " ").Split(' ');
                int min,max;
                if(int.TryParse(split[0],out min) && int.TryParse(split[1], out max)) 
                    for (int i = min; i <= max; i++)
                    {
                        result.Add(i);
                    }
                else
                    throw new System.Exception("Invalid selection string: " + sec);
            }
            else
                throw new System.Exception("Invalid selection string: "+sec);

            return result.ToArray();
        }
    }
}
