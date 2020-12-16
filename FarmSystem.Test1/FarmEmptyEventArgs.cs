using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    /// The class contain farmempty event data
    /// </summary>
    public class FarmEmptyEventArgs : EventArgs
    {
        private string _farmMessage;
        public string FarmMessage
        {
            get => _farmMessage;
        }

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="farmMessage">event message</param>
        public FarmEmptyEventArgs(string farmMessage) : base()
        {
            this._farmMessage = farmMessage;
        }

    }
}
