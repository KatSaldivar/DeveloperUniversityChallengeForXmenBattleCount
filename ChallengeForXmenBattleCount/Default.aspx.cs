using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };
            
            int largestNumberIndex = 0;
            int smallestNumberIndex = 0;

            for(int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[largestNumberIndex])
                {
                    largestNumberIndex = i;
                }
                if (numbers[i] < numbers[smallestNumberIndex])
                {
                    smallestNumberIndex = i;
                }
            }
            resultLabel.Text = String.Format("Most Battles Belongs to: {0} (Value: {1}) <br />"
                        + "Least Battles Belongs to: {2} (Value: {3}) ", 
                        names[largestNumberIndex], numbers[largestNumberIndex],
                        names[smallestNumberIndex], numbers[smallestNumberIndex]);
            
            
        }
    }
}