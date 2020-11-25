using System;
using System.Linq.Expressions;

namespace RefPropCrash
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate(() => new Model { Value = 1 });
            // Compiler crashes when this next line is uncommented:
            TestExpression(() => new Model { Value = 1 });
        }

        static void TestDelegate(Func<Model> expression)
        {
        }

        static void TestExpression(Expression<Func<Model>> expression)
        {
        }
    }

    class Model
    {
        int value;
        public ref int Value => ref value;
    }
}
