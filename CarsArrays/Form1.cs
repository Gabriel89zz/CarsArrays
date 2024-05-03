namespace CarsArrays
{
    public partial class Form1 : Form
    {
        Car[] myCars;
        int index;
        public Form1()
        {
            InitializeComponent();
            myCars = new Car[3];
            index = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == myCars.Length)
            {
                string data = "";
                for (int i = 0; i < myCars.Length; i++)
                {
                    data += myCars[i] + " ";
                }
                MessageBox.Show("Array is full " + data);
                myCars = null;
                myCars = new Car[3];
                index = 0;
                return;

            }
            myCars[index++] = new Car(cbxBrand.Text, txtModel.Text, txtMotor.Text);
            switch (cbxBrand.Text)
            {
                case "TOYOTA":
                    lblShowPrice.Text = "\nThe price of your car is: $450,000";
                    break;
                case "NISSAN":
                    lblShowPrice.Text =  "\nThe price of your car is: $550,000";
                    break;
                case "HONDA":
                    lblShowPrice.Text = "\nThe price of your car is: $350,000";
                    break;
            }
        }

    }
}
