using System;
namespace DealerShip{
    class Car{
        private string model;
        private string color;
        private float price;
        private DateTime year;
        
        public Car (string model, string color, float price, DateTime year){
            this.model = model;
            this.color = color;
            this.price = price;
            this.year = year;

        }
        /*Data validation for each instance variable */
        public void setModel(string model){
            this.model = model;
        }
        public void setColor(string color){
            this.color = color;
        }
        public void setPrice(float price){
            this.price = price;
        }

        public void setYear(DateTime year){
            this.year = year;
        }
        public string getModel(){
            return this.model;
        }

        public string getColor(){
            return this.color;
        }

        public float getPrice(){
            return this.price;
        }

        public DateTime getYear(){
            return this.year;
        }

        public string toString(){
            string stringReprestationOfCar = "Model: " + this.model + ", Color: " + this.color + 
            ", Price: "+this.price+"$, Year: "+this.year.ToShortDateString();
            return stringReprestationOfCar;
        }

    }
}