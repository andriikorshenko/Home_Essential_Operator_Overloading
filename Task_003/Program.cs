using Task_003;

House house1 = new House();
house1.appartmentsQuontity = 12;
house1.name = new Developer("AAA");

House house2 = (House)house1.Clone();

DisplayInfo(house1);
DisplayInfo(house2);

house1.appartmentsQuontity = 24;
house1.name = new Developer("BBB");

House house3 = (House)house1.DeepClone();

DisplayInfo(house1);
DisplayInfo(house3);

static void DisplayInfo(House house)
{
    Console.WriteLine($"Appartment Quontity : {house.appartmentsQuontity} " +
        $"\nDeveloper : {house.name}");
}
    