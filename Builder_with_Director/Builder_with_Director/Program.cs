using Builder_pattern;


Director director = new Director();
HouseBuilder builder = new HouseBuilder();

director.Builder = builder;


director.BuildCheapHouse();

House cheap = builder.Build();

Console.WriteLine(cheap);


builder.Reset();



director.BuildStandardHouse();

House standard = builder.Build();

Console.WriteLine(standard);


builder.Reset();



director.BuildLuxuryHouse();

House luxury = builder.Build();

Console.WriteLine(luxury);

