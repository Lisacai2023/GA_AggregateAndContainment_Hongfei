using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AggregateAndContainment_Hongfei
{
    public class GraphicsCard
    {
        public enum Brand { Nvidia,AMD, Interl}

        Brand _graphicsCardBrand;

        public Brand GraphicsCardBrand { get => _graphicsCardBrand; set => _graphicsCardBrand=value; }

        public GraphicsCard(Brand graphicsCardBrand)
        {
            _graphicsCardBrand=graphicsCardBrand;
        }
    }
}
