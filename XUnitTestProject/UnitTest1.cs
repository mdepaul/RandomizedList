/* Attributions
 * Mike DePaul
 * https://github.com/mdepaul/RandomizedList.git
 * **/
using MD.RandomizedList;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void NewRandomListTest()
        {
            bool allMatch = true;
            RandomizedList<string> randoList = new RandomizedList<string>(new PrngSHA256());
            List<string> baseList = new List<string>();

            baseList.Add("a");
            baseList.Add("A");
            baseList.Add("b");
            baseList.Add("B");
            baseList.Add("CCC");
            baseList.Add("D");
            baseList.Add("0");
            baseList.Add("1");
            baseList.Add("$^%#$%^%$#");

            foreach (var item in baseList)
            {
                randoList.Add(item);
            }


            for (int i = 0; i < baseList.Count; i++)
            {
                if (baseList[i] != randoList[i])
                    allMatch = false;
            }

            Assert.False(allMatch);
        }

        [Fact]
        public void RandomListItemCountTest()
        {
            RandomizedList<string> randoList = new RandomizedList<string>(new PrngSHA256());
            List<string> baseList = new List<string>();

            baseList.Add("a");
            baseList.Add("A");
            baseList.Add("b");
            baseList.Add("B");
            baseList.Add("CCC");
            baseList.Add("D");
            baseList.Add("0");
            baseList.Add("1");
            baseList.Add("$^%#$%^%$#");

            foreach (var item in baseList)
            {
                randoList.Add(item);
            }
            Assert.True(randoList.Count == baseList.Count);
        }

        [Fact]
        public void RandomListClearTest()
        {
            RandomizedList<string> randoList = new RandomizedList<string>(new PrngSHA256());
            List<string> baseList = new List<string>();

            baseList.Add("a");
            baseList.Add("A");
            baseList.Add("b");
            baseList.Add("B");
            baseList.Add("CCC");
            baseList.Add("D");
            baseList.Add("0");
            baseList.Add("1");
            baseList.Add("$^%#$%^%$#");

            foreach (var item in baseList)
            {
                randoList.Add(item);
            }

            randoList.Clear();
            Assert.True(randoList.Count == 0);
        }

        [Fact]
        public void RandomListContainsTest()
        {
            bool isMissingAValue = false;
            RandomizedList<string> randoList = new RandomizedList<string>(new PrngSHA256());
            List<string> baseList = new List<string>();

            baseList.Add("a");
            baseList.Add("A");
            baseList.Add("b");
            baseList.Add("B");
            baseList.Add("CCC");
            baseList.Add("D");
            baseList.Add("0");
            baseList.Add("1");
            baseList.Add("$^%#$%^%$#");

            foreach (var item in baseList)
            {
                randoList.Add(item);
            }

            for (int i = 0; i < baseList.Count; i++)
            {
                if (randoList.Contains(baseList[i]) == false)
                {
                    isMissingAValue = true;
                }
            }

            randoList.Clear();
            Assert.False(isMissingAValue);
        }

        [Fact]
        public void AddArrayTest()
        {
            RandomizedList<string> randoList = new RandomizedList<string>(new PrngSHA256());
            string[] baseArray = new string[5];

            baseArray[0] = "a";
            baseArray[1] = "B";
            baseArray[2] = "J";
            baseArray[3] = "a^&^*";
            baseArray[4] = "001";

            randoList.Add(baseArray);

            Assert.True(randoList.Count == baseArray.Length);
        }
    }
}
