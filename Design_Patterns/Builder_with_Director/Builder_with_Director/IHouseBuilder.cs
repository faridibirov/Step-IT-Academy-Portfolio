

public interface IHouseBuilder
{
    House House { get; set; }

    IHouseBuilder BuildWalls(int count);
    IHouseBuilder BuildDoors(int count);
    IHouseBuilder BuildWindows(int count);
    IHouseBuilder BuildRoof();
    IHouseBuilder BuildGarage();
    IHouseBuilder BuildGarden();
    IHouseBuilder BuildPool();

    void Reset();

    House Build();

}