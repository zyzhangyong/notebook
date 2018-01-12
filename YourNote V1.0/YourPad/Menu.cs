using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace YourPad
{
    class Menu:DirFile
    {
        //显示主菜单
        public void ShowMenu()
        {
            Console.WriteLine("\n" + "\n" + "\n");
            Console.WriteLine("\t*********************************************************");
            Console.WriteLine("\t*\t\t\t\t\t\t\t*");
            Console.WriteLine("\t*\t1.新建笔记\t2.打开笔记\t3.新建分类\t*");
            Console.WriteLine("\t*\t4.管理分类\t5.保存笔记\t6.退出\t\t*");
            Console.WriteLine("\t*\t\t\t\t\t\t\t*");
            Console.WriteLine("\t*********************************************************");
            Console.WriteLine("\t请输入菜单选项（1-6）:");
        }
        //显示管理分类子菜单
        public void showDirMenu()
        {
            Console.WriteLine("\n" + "\n" + "\n");
            Console.WriteLine("\t**************************管理分类***********************");
            Console.WriteLine("\t*\t\t\t\t\t\t\t*");
            Console.WriteLine("\t*\t1.删除分类\t2.重命名分类\t3.移动分类\t*");
            Console.WriteLine("\t*\t4.复制分类\t5.粘贴分类\t6.替换分类\t*");
            Console.WriteLine("\t*\t7.查找文件\t8.获取所有文件\t9.替换分类\t*");
            Console.WriteLine("\t*\t10.回到上一级\t11.退出\t\t\t\t*");
            Console.WriteLine("\t*\t\t\t\t\t\t\t*");
            Console.WriteLine("\t*********************************************************");
            Console.WriteLine("\t请输入菜单选项（1-8）:");
        }
        //主菜单选择页面
        public void ChooseMenu()
        {

            DirFile file = new DirFile();
            //DirFile dir = new DirFile();
            string choose=Console.ReadLine();
            switch (choose)
            {
                case "1":
                    //新建笔记
                    file.CreateFile();
                    break;
                case "2":
                    //打开笔记
                    file.OpenFile();
                    break;
                case "3":
                    //新建分类
                    file.CreateDir();
                    break;
                case "4": 
                    //管理分类
                    file.OperateDir();
                    break;
                case "5": 
                    //保存笔记
                    file.StoreFile();
                    break;
                case "6": 
                    //退出
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
        
    }
}
