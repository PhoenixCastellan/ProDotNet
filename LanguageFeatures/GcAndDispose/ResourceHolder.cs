using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.GcAndDispose
{
    class ResourceHolder : IDisposable
    {
        private bool _isDisposed = false;

        private FileStream _fs;


        public ResourceHolder(string filePath)
        {
            if (!File.Exists(filePath))
            {
                filePath = System.IO.Directory.GetCurrentDirectory() + "\\" + filePath;

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException();
                }
            }
            _fs =File.OpenRead(filePath);
        }

        public void Read()
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (_fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    //释放托管资源   
                    DisposeManagedResource();
                }
                //释放非托管资源   
                DisposeUnmanagedResource();
            }
            _isDisposed = true;
        }

        protected virtual void DisposeManagedResource()
        {
            Console.WriteLine("释放托管的资源");
        }


        protected virtual void DisposeUnmanagedResource()
        {
            Console.WriteLine("释放非托管的文件流");
            _fs?.Dispose();
        }

        ~ResourceHolder()
        {
            Console.WriteLine("GC调用析构函数");
            Dispose(false);
        }
    }

    class TestResourceHolder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        public static void Test(string filePath)
        {
            var rh = new ResourceHolder(filePath);
            rh.Read();
            GC.Collect();
        }

        public static void TestByUseUsing(string filePath)
        {
            using (var rh = new ResourceHolder(filePath))
            {
                rh.Read();
            }
        }
    }
}