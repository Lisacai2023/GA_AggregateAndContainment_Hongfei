using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_Hongfei
{
    internal class Suspension
    {
        float _frontBalance;
        float _springNess;
        float _rearBalance;

        public Suspension(float frontBalance, float springNess, float rearBalance)
        {
            _frontBalance=frontBalance;
            _springNess=springNess;
            _rearBalance=rearBalance;
        }

        public float FrontBalance
        {
            get => _frontBalance;

            //Between -1 to 1: 0 is center, -1 is left balance, 1 is right
            set
            {
                if (value >= -1 && value <= 1)
                {
                    _frontBalance = value;
                }

            }

        }

        public float SpringNess { get => _springNess; set => _springNess=value; }
        public float RearBalance { get => _rearBalance; set => _rearBalance=value; }
    }
}
