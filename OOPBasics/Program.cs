// See https://aka.ms/new-console-template for more information
using OOPBasics.Models;

Console.WriteLine("Hello, World!");

//Bike bike = new Bike() 
//{
//    Capacity=300,
//    Name="Benelli",
//    Id=1001,
//    YearMake=2018,
//    IsABS=true,
//    NumberOfCylinder=5,
//    TopSpeed=300,
//    EngineType="5"
//};

////bike.Capacity = 300;
////bike.Name = "Benelli";
////bike.Id = 1001;
////bike.YearMake = 2018;
////bike.IsABS = true;
////bike.NumberOfCylinder = 5;
////bike.TopSpeed = 300;
////bike.EngineType = "V4";
//bool isStarted = bike.Start();

//if(isStarted)
//{

//}
//else
//{

//}
//bool isStopped=bike.Stop();
//Console.WriteLine(bike.Name + " " + bike.NumberOfCylinder);



ShowRoom showRoom = new ShowRoom();
showRoom.Id = 101;
showRoom.Name = "Teynampet Honda";
showRoom.BikeList = new List<Bike>();
showRoom.BikeList.Add(new Bike() { Id = 1001, Name = "Benelli", IsABS = true });
showRoom.BikeList.Add(new Bike() { Id = 1002, Name = "Honda", IsABS = false });
showRoom.BikeList.Add(new Bike() { Id = 1003, Name = "Yamaha", IsABS = true });
bool isBikeAvailable = showRoom.FindBike("Benelli1");



Console.WriteLine(showRoom.Name);
