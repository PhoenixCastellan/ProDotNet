using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LanguageFeatures.Indexer
{
    public class IndexerByNum
    {
        private string[] name = new string[2];

        //索引器必须以this关键字定义，其实这个this就是类实例化之后的对象
        public string this[int index]
        {
            //实现索引器的get方法
            get
            {
                if (index < 2)
                {
                    return name[index];
                }
                return null;
            }

            //实现索引器的set方法
            set
            {
                if (index < 2)
                {
                    name[index] = value;
                }
            }
        }
    }

    public class IndexerByString
    {
        private Hashtable _name=new Hashtable();

        public string this[string index]
        {
            get
            {
                if (_name.ContainsKey(index))
                {
                    return _name[index].ToString();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (_name.ContainsKey(index))
                {
                    _name[index] = value;
                }
                else
                {
                    _name.Add(index,value);
                }
            }
        }
    }

    public class IndexerByObject
    {
        private Hashtable _name = new Hashtable();


        public string this[object index]
        {
            get
            {
                if (_name.ContainsKey(index))
                {
                    return _name[index].ToString();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (_name.ContainsKey(index))
                {
                    _name[index] = value;
                }
                else
                {
                    _name.Add(index, value);
                }
            }
        }
    }

    public class IndexerByMultiParam
    {
        public const int _x = 5;
        public const int _y = 5;
        private int[,] _value = new int[_x,_y];

        public int this[int x,int y]
        {
            get
            {
                if (x >= _x || x < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(x));
                }
                else if (y >= _y || y < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(y));
                }
                else
                {
                    return _value[x, y];
                }
            }
            set
            {
                if (x >= _x || x < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(x));
                }
                else if (y >= _y || y < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(y));
                }
                else
                {
                    _value[x, y] = value;
                }
            }
        }
    }


    public class TestIndexer
    {
        public static string UseIndexerByNumber()
        {
            var index1 = new IndexerByNum();
            index1[0] = "Michael";
            index1[1] = "Jackson";

            return $"First name:{index1[0]} Last name:{index1[1]}";
        }

        public static string UseIndexerByString()
        {
            var index1 = new IndexerByString();
            index1["FirstName"] = "Michael";
            index1["LastName"] = "Jackson";
            index1["Sex"] = "Man";

            return $"First name:{index1["FirstName"]} " +
                   $"Last name:{index1["LastName"]} " +
                   $"Sex:{index1["Sex"]}";
        }

        public static string UseIndexerByObject()
        {
            var index1 = new IndexerByObject();
            index1["FirstName"] = "Michael";
            index1["LastName"] = "Jackson";
            index1["Sex"] = "Man";
            index1["Age"] = "Fifty";

            return $"First name:{index1["FirstName"]} " +
                   $"Last name:{index1["LastName"]} " +
                   $"Sex:{index1["Sex"]}" +
                   $"Age:{index1["Age"]}";
        }

        public static string UseIndexerByMultiParam()
        {
            var index1 = new IndexerByMultiParam();
            for (int x = 0; x < IndexerByMultiParam._x; x++)
            {
                for (int y = 0; y < IndexerByMultiParam._y; y++)
                {
                    index1[x, y] = x * 10 + y;
                }
            }
            var sb = new StringBuilder();
            for (int x = 0; x < IndexerByMultiParam._x; x++)
            {
                for (int y = 0; y < IndexerByMultiParam._y; y++)
                {
                    sb.Append(index1[x, y] + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}