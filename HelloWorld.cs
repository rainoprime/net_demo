// 程序结构 C# 9 及以后有的特性
using System;

//Console.WriteLine("newStuctApplicaton");

namespace NetDemo.StructApplicaiton
{
    // 类
    public class StructApplicationClass
    {

    }

    // 结构
    public struct StructApplicationStruch
    {

    }

    // 接口
    public interface StructApplicationInterface
    {

    }

    // 委托
    public delegate int StructApplicationDelegate();

    // 枚举
    public enum StructApplicationEnum
    {

    }

    // 命名空间嵌套命名空间
    namespace StructApplication.space
    {
        // 结构...
        public struct StructApplicationStruct
        {

        }
    }

    // 以下为c# 9 之前的写法，需要Main方法作为程序的入口
    public class ProjectDemo
    {
        public static void Main()
        {
            Console.WriteLine("c# 9以下的程序入口");
        }
    }
}