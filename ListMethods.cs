using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class ListMethods
    {
        public void List()
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }

            list.Insert(1, 15);

            list.Remove(3);

            list.RemoveAt(0);

            bool cont = list.Contains(0);

            int p = list.IndexOf(40);

            list.AddRange(new int[] { 50, 60 });

            foreach (int x in list)
            {
                Console.Write(x + ",");
            }

            list.Clear();

            foreach (int x in list)
            {
                Console.Write(x + ",");
            }

            int a = list.Count;
            
            List<StudentA> st = new List<StudentA>();
            st.Add(new StudentA { Name = "KIran", Id = 32 });

            int[] arraya = { 2, 3, 4, 56 };
            list.AddRange(arraya);

            list.FindLast(l=>l>9);
        }
    }
}

public class StudentA
{
    public string Name;
    public int Id;
}
