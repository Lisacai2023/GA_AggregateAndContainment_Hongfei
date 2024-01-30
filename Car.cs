using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_Hongfei
{
    internal class Car
    {
        string _make;
        string _model;
        Engine _engine;
        Suspension _suspension;

        public Car(string make, string model, Engine engine, Suspension suspension = null)
        {
            _make=make;
            _model=model;
            //Aggregation
            _engine=engine;
            _suspension=suspension;
        }

        public void SwapEngine(Engine engine)
        {
            if ( _engine != null )
            {
                _engine = engine;
            }
        }

        public void SwaEngine(int hp)
        {
            _engine = new Engine(hp);
        }

        public override string ToString()
        {
            return $"{_make} {_model} :{_engine.Hp} :\n" +
            $"Suspension: Front Balance {_suspension.FrontBalance}\n" +
            $"Rear Balance : {_suspension.RearBalance}\n" +
            $"Springness :{_suspension.SpringNess}";
        }


    }
}
