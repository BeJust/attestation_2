using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Listutils
    {
        public List<int> List { get; set; }

        public Listutils(List<int> list)
        {
            this.List = list;
        }



        public List<int> CreateNewList(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < List.Count; i++)
            {
                result.Add(List[i]);
            }

            if (n > 0)
            {
                for (int j = 0; j < n; j++)
                {

                    if (result.Count > 1)
                    {
                        var tmp = result[result.Count - 1];

                        for (var i = result.Count - 1; i != 0; --i)
                            result[i] = result[i - 1];

                        result[0] = tmp;
                    }

                }
            }
            else
            {
                n = Math.Abs(n);
                for (int j = 0; j < n; j++)
                {

                    if (result.Count > 1)
                    {
                        var tmp = result[0];

                        for (var i = 0; i != result.Count - 1; ++i) result[i] = result[i + 1];

                        result[result.Count - 1] = tmp;
                    }

                }
            }


           
            return result;

        }


    }
}
