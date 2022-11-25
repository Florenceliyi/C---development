// See https://aka.ms/new-console-template for more information

using System;

class Programme {
    static void Main()
    {   
        //变量
        /*有符号的整型变量 能存储一定范围正负数包括0的变量类型 */
        //sbyte -128~127
        sbyte i = 3;
        // int -21亿~21亿多
        int e = 2;
        // short -32768~32767之间
        short q = 45;
        // long -9百万兆~9百万兆之间的数
        long p = 32;
        // 无符号的整形变量 能存储一定范围0 和证书的变量类型
        // byte 0~255
        byte b = 3;
        // uint 0~42亿多的范围
        uint ab = 90;
        // ushort us = 76;
        ushort tt = 87;
        // ulong 0~18百万兆之间的数
        ulong ol = 333;

        //浮点数 
        // float 存储7，8位有效数字
        float f = 0.434343434f;
        Console.WriteLine(f);

        //double 存储15~27位有效数字,后面的数字会四舍五入
        double oo = 0.4342489237489237489;

        //decimal 存储27~28位有效数字 不建议使用
        decimal dee = 0.43434345789374589378957394m;

        //特殊类型
        // bool 表示真假的数据类型
        bool bt = true;
        bool bt2 = false;

        // char 存储单个字符的变量类型；
        char ccc = 'r';
        Console.WriteLine(ccc);

        //string 字符串类型，用来存储多个字符没有上限
        string bbb = "fsfsfsdfsdfs";

        //占用内存
        Console.WriteLine("********************整点型");
        int sbyteSize = sizeof(sbyte);
        Console.WriteLine("sbyte 所占字节数为" + sbyteSize);
        int shortSize = sizeof(short);
        Console.WriteLine("int 所占字节数为" + shortSize);
        int intSize = sizeof(int);
        Console.WriteLine("int 所占字节数为" + intSize);
        int longSize = sizeof(long);
        Console.WriteLine("long 所占字节数为" + longSize);
        int byteSize = sizeof(byte);
        Console.WriteLine("byte 所占字节数为" + byteSize);
        int uintSize = sizeof(uint);
        Console.WriteLine("uint 所占字节数为" + uintSize);
        int ushortSize = sizeof(ushort);
        Console.WriteLine("ushort 所占字节数为" + ushortSize);
        int ulongSize = sizeof(ulong);
        Console.WriteLine("ulong 所占字节数为" + ulongSize);
        
        Console.WriteLine("********************浮点型");
        int floatSize = sizeof(float);
        Console.WriteLine("float 所占字节数为" + floatSize);
        int doubleSize = sizeof(double);
        Console.WriteLine("double 所占字节数为" + doubleSize);
        int decimalSize = sizeof(decimal);
        Console.WriteLine("decimal 所占字节数为" + decimalSize);

        Console.WriteLine("********************其他类型");
        int boolSize = sizeof(bool);
        Console.WriteLine("bool 所占字节数为" + boolSize);
        int charSize = sizeof(char);
        Console.WriteLine("char 所占字节数为" + charSize);
        //string的内存大小是不固定的
        // int stringSize = sizeof(string);
        // Console.WriteLine("string 所占字节数为" + stringSize);

        //常量
        //1.必须初始化
        //2.不能被修改
        const float a1 = 232323;
        // a1 = 23;
        Console.WriteLine(a1);


        /*隐式转换*/
        //什么情况下会出现数据类型的隐式转换，请举例说明
        // 大范围存小范围
        // double——>float ——> 整形（无符号、有符号）——> char
        // decimal ——> 整形（无符号、有符号）——> char
        // long ——>int ——> short ——> sbyte
        // ulong ——> uint ——> ushort ——> byte
        // 无符号 没法 隐式存储 有符号的
        // 有符号的 可以 隐式存储 无符号（范围大小）
        
        //Parse法 把字符串类型转换成对应的类型
        int i1 = int.Parse("3232");
        Console.WriteLine(i1);

        short s1 = short.Parse("331");
        Console.WriteLine(s1);

        //Convert.To方法
        int aa = Convert.ToInt32("23");
        Console.WriteLine(aa);

    }
}
