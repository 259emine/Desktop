using System;
using System.Collections.Generic;

namespace LINQ.DENEME
{
    class Program
    {
        static void Main(string[] args)
        {
            var deneme = new List<string>();

             deneme.Add("ahmet");
             deneme.Add("mehmet");
             deneme.Add("hasan");
             deneme.Add("hüseyin");  
             deneme.Add("ali");
             deneme.Add("veli");
             deneme.Add("ayşe");
             deneme.Add("fatma");


             var sonuc = deneme.where( x => x.length == 3);
        }
    }
}
