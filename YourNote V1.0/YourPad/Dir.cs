using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace YourPad
{
    class Dir
    {
        //删除分类
        public bool deleteDir() 
        {
            Console.Write("请输入分类名：");
            string dirName = Console.ReadLine();
            if(!Directory.Exists("\\"+dirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", dirName);
                return false;
            }
            else 
            {
                File.Delete("\\" + dirName);
                return true;
            }
        }
        //重命名分类
        public bool renameDir()
        {
            Console.Write("请输入分类名：");
            string srcDirName = Console.ReadLine();
            if (!File.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else
            {
                string destDirName = Console.ReadLine();
                File.Move(srcDirName, destDirName);
                return true;
            }
        }
        //移动分类
        public bool moveDir()
        {
            Console.Write("请输入分类名：");
            string srcDirName = Console.ReadLine();
            if (!File.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else
            {
                string destDirName = Console.ReadLine();
                File.Move(srcDirName, destDirName);
                return true;
            }
        }
        //复制分类
        public bool copyDir()
        {
            Console.Write("请输入分类名：");
            string srcDirName = Console.ReadLine();
            if (!File.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else
            {
                string destDirName = Console.ReadLine();
                File.Copy(srcDirName, destDirName);
                return true;
            }
        }
        //粘贴分类
        public bool pasteDir()
        {
            Console.Write("请输入分类名：");
            string srcDirName = Console.ReadLine();
            if (!File.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else
            {
                string destDirName = Console.ReadLine();
                File.Move(srcDirName, destDirName);

                return true;
            }
        }
        //替换分类
        public bool replaceDir()
        {
            Console.Write("请输入源分类名：");
            string srcDirName = Console.ReadLine();
            if (!File.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else
            {
                Console.WriteLine("请输入目标分类名：");
                string destDirName = Console.ReadLine();
                Console.WriteLine("请输入目标备份分类名：");
                string destBDirName = Console.ReadLine();
                File.Replace(srcDirName, destDirName, destBDirName);
                return true;
            }
        }
        public bool getDirFiles()
        {
            Console.Write("请输入源分类名：");
            string srcDirName = Console.ReadLine();
            if (!Directory.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else 
            { 
                string[] files = Directory.GetFiles(srcDirName);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
                return true;
            }
        }
        //用通配符查找目录下的文件
        public bool searchDirFiles()
        {
            Console.Write("请输入源分类名：");
            string srcDirName = Console.ReadLine();
            if (!Directory.Exists(srcDirName))
            {
                Console.WriteLine("您输入的目录{0}名错误或目录不存在！", srcDirName);
                return false;
            }
            else 
            { 
                string []strings = Directory.GetFiles(@"D:\资源\","*.rmvb",SearchOption.AllDirectories);
                foreach(string s in strings)
                {
                    Console.WriteLine(s);
                }
                return true;
            } 
        }


    }
}
