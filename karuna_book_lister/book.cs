using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karuna_book_lister
{
    internal class book
    {
        public string name;
        public string author;
        public string publication;
        public string published_date;

        public book(string name, string author, string publication, string published_date)
        {
            this.name = name;
            this.author = author;
            this.publication = publication;
            this.published_date = published_date;
        }
        // check if the input fields are empty with date picker it shold be  less than today's date
        
        public bool validate()
        {
            if (name == "" || author == "" || publication == "" || published_date == "")
            {
                return false;
            }
            else if (DateTime.Parse(published_date) > DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string get_name()
        {

            return name;
        }
        public string get_author()
        {

            return author;
        }
        public string get_publication()
        {

            return publication;
        }
        public string get_published_date()
        {

            return published_date;
        }


    }
}
