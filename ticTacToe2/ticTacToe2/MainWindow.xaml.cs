using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ticTacToe2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            newGame();
        }
        #endregion

        #region private members
        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] mResults;

        /// <summary>
        /// wich player turn is it
        /// </summary>
        private bool mplayer1Turn;
        /// <summary>
        /// Is there a winner of the current game
        /// </summary>
        private bool mGameEnd;
        #endregion

        #region gameFunctions
        private void newGame()
        {
            //create a new blank array
            mResults = new MarkType[9];

            for (int i = 0; i < mResults.Length; i++) mResults[i] = MarkType.FREE;

            mplayer1Turn = true;

            container.Children.Cast<Button>().ToList().ForEach(Button =>
            {
                Button.Content = string.Empty;
                Button.Background = Brushes.White;
                Button.Foreground = Brushes.Blue;
                Button.FontFamily = new FontFamily("Ink Free");
            });

            mGameEnd = false;
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mGameEnd)
            {
                newGame();
                return;
            }
            //cast sender to a button
            var button = (Button)sender;
            //colum and row of button
            var col = Grid.GetColumn(button);
            var row = Grid.GetRow(button);
            // index in array
            var index = col + (row * 3);

            if (mResults[index] != MarkType.FREE) return;
            else
            {
                mResults[index] = mplayer1Turn ? MarkType.CROSS : MarkType.CIRCLE;

                button.Content = mplayer1Turn ? "X" : "O";
                if (!mplayer1Turn)
                {
                    button.Foreground = Brushes.Tomato;
                }
                mplayer1Turn ^= true;

                checkForWinner();
            }
        }

        private void checkForWinner()
        {
            
            //check for horrizontal win

            //Row 1
            if(mResults[0] != MarkType.FREE && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
                highLightInGreen(bu0_0, bu0_1, bu0_2);
            //Row 2
            else if (mResults[3] != MarkType.FREE && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
                highLightInGreen(bu1_0, bu1_1, bu1_2);
            //Row 3
            else if (mResults[6] != MarkType.FREE && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
                highLightInGreen(bu2_0, bu2_1, bu2_2);

            //check for Vertical win

            //column 1
            if (mResults[0] != MarkType.FREE && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
                highLightInGreen(bu0_0, bu1_0, bu2_0);
            //collumn 2
            else if (mResults[1] != MarkType.FREE && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
                highLightInGreen(bu0_1, bu1_1, bu2_1);

            //column 3
            else if (mResults[2] != MarkType.FREE && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
                highLightInGreen(bu0_2, bu1_2, bu2_2);

            //check for Diagonal win

            //left top to right bottom
            if(mResults[0] != MarkType.FREE && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
                highLightInGreen(bu0_0, bu1_1, bu2_2);

            //Right top to left bottom
            else if (mResults[2] != MarkType.FREE && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
                highLightInGreen(bu0_2, bu1_1, bu2_0);

            //If all spaces taken and no winner
            if (!mResults.Any(f => f == MarkType.FREE)) {
                mGameEnd = true;
                container.Children.Cast<Button>().ToList().ForEach(Button =>
                { 
                    Button.Background = Brushes.Orange;
                    Button.Foreground = Brushes.White;
                });

            }
        }

        private void highLightInGreen(Button one, Button two, Button three)
        {
            one.Background = two.Background = three.Background = Brushes.Green;
            one.Foreground = two.Foreground = three.Foreground = Brushes.White;
            mGameEnd = true;
        }
    }
}
