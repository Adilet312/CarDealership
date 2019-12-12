using System;
using System.Collections.Generic;
namespace DealerShip{
    public class CarList{
        //private List<Car> list;
        public CarList(){
           List<Car> list  =  new List<Car>();
        }
        public void addCar(Car newCar){
            list.Add(newCar);
            size++;
        }
        public int getSize(){
            return this.size;
        }
    }
}