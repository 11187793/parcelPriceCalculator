using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace parcelPriceCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        bool sufficientData()
        {
            if (lengthBox.Text.Trim() == "")
                lengthBox.Text = "1";

            if (widthBox.Text.Trim() == "") return false;
            else if (heightBox.Text.Trim() == "") return false;
            else if (!groundRadio.Checked && !airRadio.Checked && !nextDayRadio.Checked) return false; 
            else return true;
        }


        int[] getData()
        {
            // first index is width, second index is height, third index is volume

            int[] data = { int.Parse(widthBox.Text.Trim()),  int.Parse(heightBox.Text.Trim()), int.Parse(lengthBox.Text.Trim()) };

            return data;
        }

        int getVolume(int[] data)
        {
            return data[0] * data[1] * data[2];
        }

        double determineMultiplier()
        {
            double multiplier = 0;

            if (groundRadio.Checked) multiplier = 0.15;
            else if (airRadio.Checked) multiplier = 0.25;
            else if (nextDayRadio.Checked) multiplier = 0.45;

            return multiplier;
        }

        double getCost(int volume, double multiplier)
        {
            return volume * multiplier; 
        }

        protected void calculateBtn_Click(object sender, EventArgs e)
        {
            if (sufficientData() == false)
            {
                errorLabel.Text = "Insufficient Data";
                resultLabel.Text = ""; 
                return; 
            } else
            {
                errorLabel.Text = "";
            }

            resultLabel.Text = String.Format("The cost is {0:C}", getCost(getVolume(getData()), determineMultiplier()));
        }
    }
}