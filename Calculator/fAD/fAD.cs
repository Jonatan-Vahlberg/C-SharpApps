using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace fAD
{
    public partial class fAD : Form
    {
        public fAD()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region clear Methods
        /// <summary>
        /// This method clears the typing area and removes all inputs 
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">The actual event used</param>
        private void ce_Click(object sender, EventArgs e)
        {
            //Clears user input text
            this.uiText.Text = String.Empty;
        }
        /// <summary>
        /// This method returns the equation sum,mean etc
        /// </summary>
        /// <param name="sender">the button pressed</param>
        /// <param name="e">the actual event used</param>
        private void equals_Click(object sender, EventArgs e)
        {
            //call to a method for calculating the equation
            calcEquation();

        }



        /// <summary>
        /// Method for erasing one char ahead of cursor placement in input feild
        /// </summary>
        /// <param name="sender">the button pressed</param>
        /// <param name="e">the actual event used</param>
        private void erease_Click(object sender, EventArgs e)
        {
            //Call to method for removal of character
            removeTextValue();

            //call to method for refocusing the cursor position
            focusInputText();

        }

        #endregion

        /// <summary>
        /// Method for taking input from either a number a dot or operator
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">the actual event</param>
        private void num_Click(object sender, EventArgs e)
        {
            //the input char
            string value = (sender as Button).Text;

            //places value into cursor pos in input feild
            insertTextValue(value);

            //refocuses the cursor
            focusInputText();

        }

        /// <summary>
        /// Method for placing char into cursor position in input feild
        /// </summary>
        /// <param name="value">The char that is to be inputed</param>
        private void insertTextValue(string value)
        {
            //previous cursor pos
            var selecStart = this.uiText.SelectionStart;

            //inserting the char in input feild
            this.uiText.Text = this.uiText.Text.Insert(this.uiText.SelectionStart, value);

            //reseting the cursor to its new pos
            this.uiText.SelectionStart = selecStart + value.Length;

        }

        /// <summary>
        /// Removes one char from input feild unless at start of input 
        /// </summary>
        private void removeTextValue()
        {
            //input is at start
            if (this.uiText.Text.Length < this.uiText.SelectionStart + 1)
            {
                return;
            }
            var selecStart = this.uiText.SelectionStart;
            this.uiText.Text = this.uiText.Text.Remove(this.uiText.SelectionStart, 1);


            this.uiText.SelectionStart = selecStart;

        }
        /// <summary>
        /// Refocus the cursor
        /// </summary>
        private void focusInputText()
        {
            this.uiText.Focus();
        }
        private void calcEquation()
        {
            var userInput = this.uiText.Text;

            this.calcText.Text = parseOperation();

        }
        /// <summary>
        /// Parses the users equation and calculate the result
        /// </summary>
        /// <returns></returns>
        private string parseOperation()
        {
            try
            {
                //User input
                var userInput = this.uiText.Text;

                //Remove all spaces
                userInput = userInput.Replace(" ", "");

                //new toplevel operation
                var operation = new Operation();
                var leftside = true;

                //Loops all char in input moving left to right
                //TODO: Handle order priority
                for(int i = 0; i < userInput.Length; i++)
                {
                    //check if char is number or dot
                    if("0123456789.".Any(c => userInput[i] == c ))
                    {
                        if (leftside)
                        {
                            operation.leftSide = addNumPart(operation.leftSide, userInput[i]);
                        }
                        else
                        {
                            operation.rightSide = addNumPart(operation.rightSide, userInput[i]);
                        }
                    }
                    //if char is operator
                    else if("+-*/".Any(c => userInput[i] == c))
                    {
                        //if we are on the right side we now need to calc our current operation
                        if (!leftside) {
                            var operatorType = getOperationType(userInput[i]);
                            if (operation.rightSide.Length == 0)
                            {
                                if (operatorType != (OperationType.SUB))
                                {
                                    throw new InvalidOperationException($"Operator (+*/ or more than one -) specified without an Rightside number");
                                }
                                operation.rightSide += userInput[i];
                            }
                            else
                            { 
                                //calc previous operation
                                operation.leftSide = calcOperation(operation);

                                //set new operator
                                operation.oT = operatorType;

                                //rightside  clear

                                operation.rightSide = string.Empty;

                            }

                        }
                        else
                        {
                            var operatorType = getOperationType(userInput[i]);

                            //check if leftside exsists
                            if(operation.leftSide.Length == 0)
                            {
                                if(operatorType != (OperationType.SUB))
                                {
                                    throw new InvalidOperationException($"Operator (+*/ or more than one -) specified without an left side number");
                                }
                                operation.leftSide += userInput[i];
                            }
                            else
                            {
                                operation.oT = operatorType;
                                leftside = false;
                            }
                        }

                    }
                }
                return calcOperation(operation);

                //throw new ArgumentNullException("Something is nulll");
            }
            catch (Exception ex)
            {
                return $"Invalid Eqaution. { ex.Message}";
            }
        }

        private string calcOperation(Operation operation)
        {
            //stort the number value
            double left = 0;
            double right = 0;

            if (string.IsNullOrEmpty(operation.leftSide) || !double.TryParse(operation.leftSide, out left))
            {
                throw new InvalidOperationException($"Leftside was not a number. {operation.leftSide}");
            }
            if (string.IsNullOrEmpty(operation.rightSide) || !double.TryParse(operation.rightSide, out right))
            {
                throw new InvalidOperationException($"Rightside was not a number. {operation.rightSide}");
            }
            try
            {
                switch (operation.oT)
                {
                    case OperationType.ADD:
                        return (left + right).ToString();
                    case OperationType.SUB:
                        return (left - right).ToString();
                    case OperationType.DIV:
                        return (left / right).ToString();
                    case OperationType.MULT:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkown operatortype when calculating operation. {operation.oT}");
                }
            }catch(Exception ex)
            {
                throw new InvalidOperationException($"Faild Calculation {operation.leftSide} {operation.oT} {operation.rightSide}");
            }

            return string.Empty;

        }

        /// <summary>
        /// Acepts a known <see cref="OperationType"></see>
        /// </summary>
        /// <param name="c">Character to pass</param>
        /// <returns></returns>
        private OperationType getOperationType(char c)
        {
            switch (c)
            {
                case '+':
                    return OperationType.ADD;
                    
                case '-':
                    return OperationType.SUB;
                case '/':
                    return OperationType.DIV;
                case '*':
                    return OperationType.MULT;
                default:
                    throw new InvalidOperationException($"Unkown operator type{c}");
            }
        }

        /// <summary>
        /// Attempts to add a new char to current number checking as we go
        /// </summary>
        /// <param name="current">current number string</param>
        /// <param name="toAdd">the new character to append</param>
        /// <returns></returns>
        private string addNumPart(string current, char toAdd)
        {
            //check if dot exsist
            if(toAdd == '.' && current.Contains('.'))
            {
                throw new InvalidOperationException($"Number {current} already contains a . and another cant be added");
            }
            return current + toAdd;
        }
    }
}
