using System;
using System.Collections;

namespace SortedListDemoAss
{
    public class ListSort
    {
        public void PrintSortedList(SortedList IN)
        {
            IDictionaryEnumerator IDE = IN.GetEnumerator();


            while (IDE.MoveNext())
            {
                Console.WriteLine("\t{0}\t{1}", IDE.Key, IDE.Value);
            }
        }
    }
    class SortedListEx
    {
        static void Main(string[] args)
        {
            SortedList SL = new SortedList();
            SL.Add(1, "Vivek");
            SL.Add(4, "Krunal");
            SL.Add(5, "Sameer");
            SL.Add(2, "Abhi");
            SL.Add(3, "Raj");
            ListSort ls = new ListSort();
            ls.PrintSortedList(SL);
        }
    }
}
