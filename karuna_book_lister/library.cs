using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace karuna_book_lister
{
    internal class library
    {
        // search can be used name, author, publication
        // if the search field is empty, ask to enter a value
        public static void search(string name, string author, string publication)
        {
            if (name == "" && author == "" && publication == "")
            {
                MessageBox.Show("Please enter a value to search");
            }
            else
            {

            }
        }
 
    }
}
