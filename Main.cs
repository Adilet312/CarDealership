using System;
namespace DealerShip{
    public class ClientSide{
        public static void Main(){
            // Console.WriteLine("Please Enter car's model: ");
            // string model = Console.ReadLine();
            // Console.WriteLine("Please enter car's color: ");
            // string color = Console.ReadLine();
            // Console.WriteLine("Please enter car's price: ");
            // float price = float.Parse(Console.ReadLine());
            // Console.WriteLine("Please enter car's year: ex: (year,month,day) <=> 2019,12,18 ");
            // string  date = Console.ReadLine();
            // int year = int.Parse(date.Substring(0,4));
            // int month = int.Parse(date.Substring(5,2));
            // int day = int.Parse(date.Substring(8,2));


            
            Car car1 = new Car("Honda","Black",5000,new DateTime(1909,12,17));
            Car car2 = new Car("Volvo","Grey",5000,new DateTime(1900,12,17));
            Car car3 = new Car("Jeep","White",4000,new DateTime(2010,12,17));
            Car car4 = new Car("Ford","Red",6000,new DateTime(1998,12,17));
            Car car5 = new Car("BMW","Black",9000,new DateTime(1809,12,17));
            CarList list = new CarList();
            list.addCar(car1);
            list.addCar(car2);
            list.addCar(car3);
            list.addCar(car4);
            list.addCar(car5);
            for(int index=0; index<list.getSize(); index++){
                Console.WriteLine(list[index].toString());
            }
            
            
        }
    }
}