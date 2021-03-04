using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class subclass
    {
        // public 可以直接存取 更改 取值
        public string name;
        

        // private 必須透過 set get 才能存取
        private string sex;
        public string setsex
        {
            get { return sex; }
            set { sex = value; }
        }

        // 如果只有set 只能存 不能取
        // 必須透過function 才能列印出來
        private int age;
        public int getage
        {
            set { age = value; }  
        }
        public void ShowAge()
        {
            Console.WriteLine("=======");
            Console.WriteLine(age.ToString());
        }
    }

    class program
    {   
        static void Main()
        {
            subclass e = new subclass();
            e.name = "Una";

            Console.WriteLine("=======");
            Console.WriteLine(e.name);

            e.setsex = "girl";

            Console.WriteLine("=======");
            Console.WriteLine(e.setsex);


            e.ShowAge();
            e.getage = 22;
            e.ShowAge();
        }
    }
}

