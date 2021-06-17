using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stonesList;

        public Lake(params int[] stonesList)
        {
            this.stonesList = stonesList.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            int count = this.stonesList.Count;

            for (int i = 0; i < count; i += 2)
            {
                yield return this.stonesList[i];
            }

            int lastOddIndex = count - 1;

            if (lastOddIndex % 2 == 0)
            {
                lastOddIndex--;
            }

            for (int i = lastOddIndex; i > 0; i -= 2)
            {
                yield return this.stonesList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
