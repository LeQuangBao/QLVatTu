using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class UtilityArray {
        /// <summary>
        /// Return a list of remainging elements in array1 after remove any intersect elements betwwen array1 and array2
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static System.Collections.Generic.List<int> RemoveIntersect(List<int> array1, List<int> array2) {
            List<int> result = new List<int>();
            foreach(int i in array1) {
                bool isIntersect = false;
                foreach (int j in array2) {
                    if (i == j)
                        isIntersect = true;
                }
                if (!isIntersect) {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
