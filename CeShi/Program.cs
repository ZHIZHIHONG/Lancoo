using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace CeShi
{
    class Program
    {
        static void Main(string[] args)
        {
            ////委托调用匿名方法
            //System.Threading.Thread t1=new Thread(delegate()
            //{
            //    Console.Write("hello,");
            //    Console.Write("world!");
            //    Console.ReadKey();
            //});
            //t1.Start();
            
            //集合
            //var str1 ="1";
            //string str2 = "A";
            //Console.WriteLine(Comparer.Default.Compare(str1,str2));
            //Console.ReadKey();
           
            //序列化
            //string fileName = "d:\\Company.xml";

            //XmlSerializer serializer = new XmlSerializer(typeof(Company));
            //TextWriter writer = new StreamWriter(fileName);
            //Company com = new Company();
            //com.CompanyName = "Lancoo Group";

            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            //employee1.Name = "john";
            //employee2.Name = "jack";

            //com.Employees = new Employee[2] { employee1, employee2 };
            //serializer.Serialize(writer, com);
            //writer.Close();

            //FileStream fs = new FileStream(fileName, FileMode.Open);

            //Company cmp = (Company)serializer.Deserialize(fs);
            //Console.WriteLine(cmp.CompanyName);
            //foreach (Employee employee in cmp.Employees)
            //{
            //    Console.WriteLine(" {0}", employee.Name);
            //}
            //Console.ReadKey();
            
            //文件批量重命名
            var filePath = "C://Users//Administrator//Desktop//重要勿乱删//学生头像//20090001.jpg";
            DirectoryInfo dir=new DirectoryInfo(filePath);
            var imgFile = dir.GetFiles();

            for (int i = 0; i < 500; i++)
            {
                if (i < 10)
                {
                    imgFile[i].MoveTo(filePath + "//" + "2009000" + i + ".jpg");
                }
                if (i >= 10 && i < 100)
                {
                    imgFile[i].MoveTo(filePath + "//" + "200900" + i + ".jpg");
                }
                if (i >= 100 && i < 1000)
                {
                    imgFile[i].MoveTo(filePath + "//" + "20090" + i + ".jpg");
                }
            }
            Console.WriteLine("批量改名成功！");
            Console.ReadKey();
        }
    }
}
