using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace YourPad
{
    class DirFile:Dir
    {
        
        //新建笔记
        public void CreateFile() 
        {
            //Console.WriteLine("\t");
            Console.Write("请输入文件名：");
            string fileName=Console.ReadLine();
            File.Create("\\"+fileName);

        }

        //打开笔记
        public bool OpenFile() 
        {
           Console.Write("请输入文件名：");
           string openFile = Console.ReadLine();
           if (File.Exists(openFile))
           {
               Console.WriteLine("您输入的文件名错误或文件不存在！");
               return false;
           }
           else
           { 
                string[] s = File.ReadAllLines("\\"+openFile);
                foreach (var mw in s)
                {
                    Console.WriteLine(mw);
                }
                return true;
           }
        }
        //新建分类
        public void CreateDir() 
        {
            Console.Write("请输入分类名：");
            string dirName = Console.ReadLine();
            Directory.CreateDirectory("\\"+dirName);
        }
        //管理分类
        public void OperateDir() 
        {
            Menu dirMenu = new Menu();
            dirMenu.showDirMenu();
            Dir dirName = new Dir();
            string dirChoose = Console.ReadLine();
            Dir dir = new Dir();
            switch(dirChoose)
            {
                case "1":
                    //删除分类
                    dir.deleteDir();
                    break;
                case "2":
                    //重命名分类
                    dir.renameDir();
                    break;
                case "3":
                    //移动分类
                    dir.moveDir();
                    break;
                case "4":
                    //复制分类
                    dir.copyDir();
                    break;
                case "5":
                    //粘贴分类
                    dir.pasteDir();
                    break;
                case "6":
                    //替换分类
                    dir.replaceDir();
                    break;
                case "7":
                    //获取目录下所有文件
                    dir.getDirFiles();
                    break;
                case "8":
                    //查找当前分类中的目录
                    dir.searchDirFiles();
                    break;
                case "9":
                    //替换分类
                    
                    break;
                case "10":
                    //回到上一级

                    break;
                case "11":
                    //退出

                    break;
                default:
                    break;
            }
        }
        //保存笔记
        public void StoreFile() 
        { 
            
        }
        

        //获取文件的访问权限
        public void fileAble()
        {
            int read = 0, write = 0, exe = 0;
            //if(File.)
        }
        
        //    /* 获取文件的访问权限，为成员属性able赋初值，使用8进制的整数格式代表        */
        //    /* 返回值：权限值4可读\2可写\1可执行，7为4+2+1表示可读可写可执行，0没权限 */
        //protected function fileAble(){
        //    $read=0;                      //初使用化可读的变量为0，表示不可读
        //    $write=0;                     //初使用化可写的变量为0，表示可写
        //    $exe=0;                      //初使用化执行的变量为0，表示执行
        //    if(is_readable($this->name))      //如果文件可读则条件成立
        //        $read=4;                 //将可读的变量设置为4
        //    if(is_writable($this->name))      //如果文件可写则条件成立
        //        $write=2;                //将可写的变量设置为2
        //    if(is_executable($this->name))    //如果文件可执行则条件成立
        //        $exe=1;                  //将可执行的变量设置为1
        //    return $read+$write+$exe;       //返回文件的访问权限值
        //}
    }
}
