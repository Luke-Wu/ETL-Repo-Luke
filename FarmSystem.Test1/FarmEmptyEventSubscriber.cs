using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    /// FarmEmpty event subscriber class
    /// </summary>
    public class FarmEmptyEventSubscriber
    {
        /// <summary>
        /// FarmEmpty event handle method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onFarmEmpty(Object sender, FarmEmptyEventArgs e)
        {
            Console.WriteLine(e.FarmMessage);
        }

        public FarmEmptyEventSubscriber(EmydexFarmSystem farm)
        {
            farm.FarmEmpty += new EmydexFarmSystem.FarmEmptyHandler(this.onFarmEmpty);
        }

    }
}
