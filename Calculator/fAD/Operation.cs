using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fAD
{
    /// <summary>
    /// Holds Info on a single calculator operation
    /// </summary>
    public class Operation
    {
        #region public
        /// <summary>
        /// The left side of an operation
        /// </summary>
        public string leftSide { get; set;}

        /// <summary>
        /// The right side of an operation
        /// </summary>
        public string rightSide { get; set; }

        /// <summary>
        /// The type of operation to perform
        /// </summary>
        public OperationType oT { get; set; }

        /// <summary>
        /// The innner operation to be performed before this one
        /// </summary>
        public Operation iO { get; set; }
        #endregion
        #region constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            this.leftSide = string.Empty;
            this.rightSide = string.Empty;
        }
        #endregion
    }
}
