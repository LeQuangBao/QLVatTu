using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class UtilityArray {
        /// <summary>
        /// Return a list of remainging elements in list1 after remove any intersect elements betwwen list1 and list2
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static List<int> RemoveIntersect(List<int> list1, List<int> list2) {
            List<int> result = new List<int>();
            foreach (int i in list1) {
                bool isIntersect = false;
                foreach (int j in list2) {
                    if (i == j)
                        isIntersect = true;
                }
                if (!isIntersect) {
                    result.Add(i);
                }
            }
            return result;
        }

        /// <summary>
        /// merging list1 and list2 into one, all elements will be unique
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static List<int> UniqueMerge(List<int> list1, List<int> list2) {
            List<int> result = new List<int>();
            result.AddRange(list1);
            foreach (int i in list2) {
                bool isContain = false;
                foreach (int j in list1) {
                    if (i == j) {
                        isContain = true;
                    }
                }
                if (!isContain) {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
