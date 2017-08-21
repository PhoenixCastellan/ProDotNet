using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.InheritanceAndOverloading.AbstractParent
{
    abstract class Parent
    {
        public abstract void foo();

        public void xoo()
        {
            Console.WriteLine("parent.xoo()");
        }
    }

    /// <summary>
    /// 从下面的例子可以看出
    /// override只能针对父类的方法进行重写，要保证与父类方法具有相同的签名和保护级别
    /// 函数签名由函数的名称和它的每一个形参（按从左到右的顺序）的类型和种类（值、引用或输出）组成
    /// </summary>
    class Child : Parent
    {
        #region 以下使用override的方法都不对

        //public override Parent foo()
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

        public override void foo()
        {
            Console.WriteLine("Child.foo()");
        }
    }

    class ChildUseNew : Parent
    {
        public override void foo()
        {
            throw new NotImplementedException();
        }
    }
}
