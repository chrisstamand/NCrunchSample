using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCrunchTester
{
    public class Mapper
    {
        public ModelClass MapData(ModelClass myEntity)
        {
            myEntity.Prop1 = 1;
            myEntity.Prop2 = "Hey";
            myEntity.Prop3 = "There";

            return myEntity;
        }
    }
}
