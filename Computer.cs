using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_Hongfei
{
    public class Computer
    {
        string _cpu;
        string _mother;
        GraphicsCard _graphicsCard;

        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard=graphicsCard;
        }

        public string Cpu { get => _cpu; set => _cpu=value; }
        public string Mother { get => _mother; set => _mother=value; }
        public GraphicsCard GraphicsCard { get => _graphicsCard; set => _graphicsCard=value; }

        public override string ToString()
        {
            return $"Graphics Card Brand: {GraphicsCard.Brand.Nvidia}";
        }








    }
}
