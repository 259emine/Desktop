using System.Collections.Generic;

namespace lısteler
{
    class Program
    {
        static void Main(string[] args)
        {

           List<string> deneme = new List<string>();

           deneme.Add("ahmet");
           deneme.Add("mehmet");
           deneme.Add("hasan");
           deneme.Add("hüseyin");
           deneme.Add("ali");
           deneme.Add("ayşe");
           deneme.Add("fatma");

            deneme.Remove("mehmet");
            deneme.RemoveAt(1);

        }
    }
}
