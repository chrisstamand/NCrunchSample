using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Mapper
    {
        public ModelClass MapData(ModelClass myEntity)
        {
            myEntity.Prop1 = 1;
            myEntity.Prop2 = "Hey";
            myEntity.Prop3 = "There";
            myEntity.Prop4 = "There";
            myEntity.Prop5 = "There";
            myEntity.Prop6 = "There";
            myEntity.Prop7 = "There";
            myEntity.Prop8 = "There";
            myEntity.Prop9 = "There";

            return myEntity;
        }
    }
}
