using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.InheritanceAndOverloading
{
    class Parent
    {
        public virtual Parent foo()
        {
            System.Console.WriteLine("Parent.foo()");
            return this;
        }
    }

    /// <summary>
    /// 从下面的例子可以看出
    /// override只能针对父类的方法进行重写，要保证与父类方法具有相同的签名和保护级别
    /// 函数签名由函数的名称和它的每一个形参（按从左到右的顺序）的类型和种类（值、引用或输出）组成
    /// </summary>
    class ChildUseOverride : Parent
    {
        public override Parent foo()
        {
            System.Console.WriteLine("Child.foo()");
            return this;
        }

        #region 以下使用override的方法都不对
        //private override Parent foo()
        //{
        //    System.Console.WriteLine("Child.foo()");
        //    return this;
        //}
        //public override Parent foo(int a)
        //{
        //    System.Console.WriteLine("Child.foo() with different param");
        //    return this;
        //}
        //public override void foo()
        //{
        //    System.Console.WriteLine("Child.foo() with different return");
        //}
        #endregion
    }

    /// <summary>
    /// 从下面的可以看出
    /// new可以做任意重载只要保证满足重载规则即可，父类该函数的签名及保护级别对子类没有任何约束
    /// </summary>
    class ChildUseNew : Parent
    {
        private new Parent foo()
        {
            System.Console.WriteLine("Child.foo() with different protected level");
            return this;
        }
        public new Parent foo(int a)
        {
            System.Console.WriteLine("Child.foo() with different param");
            return this;
        }
        public new void foo(int a, int b)
        {
            System.Console.WriteLine("Child.foo() with different return");
        }
    }
}
