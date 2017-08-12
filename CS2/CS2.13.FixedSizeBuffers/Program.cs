using System;
using System.Runtime.InteropServices;

// ・固定サイズ バッファー(fixed)
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/unsafe-code-pointers/fixed-size-buffers
// DLL や COM を扱う際に使える、固定サイズの配列を持ったバッファーを作成することができる。
namespace CS2.FixedSizeBuffers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            unsafe
            {
                Console.WriteLine(Marshal.SizeOf(new MyUnfixedBufferA() { Buffer = new char[128]}));
                Console.WriteLine(Marshal.SizeOf(new MyUnfixedBufferB() { Buffer = null}));
				Console.WriteLine(Marshal.SizeOf(new MyFixedBuffer()));
				Console.WriteLine(sizeof(MyFixedBuffer));
			}

            Console.ReadKey();
        }
    }

    internal struct MyUnfixedBufferA
	{
        public char[] Buffer;
	}

	internal struct MyUnfixedBufferB
	{
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		public char[] Buffer;
	}

	internal unsafe struct MyFixedBuffer
	{
		public fixed char FixedBuffer[128];
	}
}
