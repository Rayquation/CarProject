using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Car
    {
        public Car()
        {

        }
        public Car(ColorEnum color,string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
        }
        public Car(ColorEnum color,string brand, string model, double topspeed, double weight, double hp) : this(color,brand,model)
        {
            //Ikke nødvendigt da vi har this() med parameter som overgiver det til constructor nummer 2
            //this.Color=color;
            //this.Brand = brand;
            //this.Model = model;

            this.Topspeed = topspeed;
            this.Weight = weight;
            this.HP = hp;
        }
        private string _brand;
        private string _model;
        private ColorEnum _color;
        private double _topspeed;
        private double _weight;
        private double _hP;


        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public ColorEnum Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public double Topspeed
        {
            get { return _topspeed; }
            set { _topspeed = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public double HP
        {
            get { return _hP; }
            set { _hP = value; }
        }
        public override string ToString()
        {
            return ($"Brand:{this.Brand,-8} Model:{this.Model,-8} Color:{this.Color,-8} Topspeed:{this.Topspeed,5} Weight:{this.Weight,5} HorsePower:{this.HP,5} Acceleration:{GetAcceleration(),5:0.000}");
        }
        public double GetAcceleration()
        {
            double accel = Weight/HP;
            return accel;
        }
    }
}