using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    public class Director
    {

        public IHouseBuilder Builder { get; set; }



        public void BuildCheapHouse()
        {
            this.Builder.House.Name = "Cheap House";
            this.Builder.BuildWalls(4);
            this.Builder.BuildDoors(1);
            this.Builder.BuildWindows(1);
            this.Builder.BuildRoof();
        }

        public void BuildStandardHouse()
        {
            this.Builder.House.Name="Standard House";
            this.Builder.BuildWalls(4);
            this.Builder.BuildDoors(2);
            this.Builder.BuildGarage();
            this.Builder.BuildWindows(2);
            this.Builder.BuildRoof();
        }

        public void BuildLuxuryHouse()
        {
            this.Builder.House.Name = "Luxury House";
            this.Builder.BuildWalls(8);
            this.Builder.BuildDoors(4);
            this.Builder.BuildGarage();
            this.Builder.BuildWindows(5);
            this.Builder.BuildPool();
            this.Builder.BuildGarden();
            this.Builder.BuildRoof();

        }

    }
}
