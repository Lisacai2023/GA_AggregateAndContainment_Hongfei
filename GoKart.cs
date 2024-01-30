using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_Hongfei
{
    internal class GoKart
    {
        //string _make;
        //string _model;
        Engine _engine;
        Character _playerCharacter;

        public GoKart(Character playerCharacter)
        {
            //_make=make;
            //_model=model;
            _playerCharacter=playerCharacter;
            _engine= new Engine(250 -(playerCharacter.Weight/4));

        }

        internal Engine Engine1 { 
            get => _engine;
           }

        public void TweakEngine(int newHp)
        {
            _engine.Hp = newHp;

        }

        public override string ToString()
        {
            return $"Character {_playerCharacter.Name} - Weight : {_playerCharacter.Weight} : Engine Hp {_engine.Hp}";
        }





    }
}
