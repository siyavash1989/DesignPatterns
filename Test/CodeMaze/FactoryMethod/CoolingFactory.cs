﻿namespace Test.CodeMaze.FactoryMethod
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature)
        {
            return new CoolingManager(temperature);
        }
    }
}
