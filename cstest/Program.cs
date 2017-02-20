using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLua;

namespace cstest
{
    [LuaCallCSharp]
    class A
    {
        public float x, y;

        public float add()
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var luaenv = new LuaEnv();
            A a = new A() { x = 1, y = 2 };
            luaenv.Global.Set("a", a);
            a.x = 3;
            luaenv.DoString("print(a:add())");
        }
    }
}
