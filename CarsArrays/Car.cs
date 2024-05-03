using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CarsArrays
{
    internal class Car
    {
		protected string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		protected string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		protected string motor;

		public string Motor
		{
			get { return motor; }
			set { motor = value; }
		}

       

        public Car(string brand, string model,string motor)
        {
			this.brand = brand;
			this.model = model;
			this.motor = motor;
        }

        public override string ToString()
        {
            return "Brand: " + brand + " Model: " + model + " Motor: " + motor;
        }
    }
}
