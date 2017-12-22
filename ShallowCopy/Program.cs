using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShallowCopy
{
    public class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person sourceP = new Person() { Name = "张三" };
            Person copyP = sourceP; // 浅拷贝
            copyP.Name = "张老三"; // 拷贝对象改变Name值
            // 结果都是"张老三",因为实现的是浅拷贝，一个对象的改变都会影响到另一个对象
            Console.WriteLine("Person.Name: [SourceP: {0}] [CopyP:{1}]", sourceP.Name, copyP.Name);
            Console.Read();
        }
    }
}
