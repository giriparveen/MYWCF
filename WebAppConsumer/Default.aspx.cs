using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppConsumer
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalculateCost.IServicecalculatorCost Icost = new CalculateCost.ServicecalculatorCostClient();
            CalculateCost.ProductData objProductName = new CalculateCost.ProductData();
            objProductName.PerProductCost = 200;
            objProductName.ProductQuantity = 4;
            objProductName.ProductName = "Pen drive";
            
            Response.Write(Icost.GetTotalCost(objProductName));

        }
    }
}