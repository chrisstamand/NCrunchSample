using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mapper = new Mapper();
            var modelClass = new ModelClass();
            modelClass = mapper.MapData(modelClass);
        }
    }
}
