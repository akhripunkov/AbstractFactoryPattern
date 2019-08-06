using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
