namespace karuna_book_lister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Add columns to the DataGridView
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("author", "author");
            dataGridView1.Columns.Add("Publication", "Publication");
            dataGridView1.Columns.Add("Published Date", "Published Date");
            // Assuming your DataGridView is named dataGridView1
            dataGridView1.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["author"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Publication"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Published Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // create a new book object
            book b = new book(input_name.Text, input_author.Text, input_publication.Text, input_published_date.Text);

            // check if the input fields are empty with date picker it shold be  less than today's date
            if (b.validate())
            {
                // add the book to the list
                ListViewItem item = new ListViewItem(b.get_name());
                item.SubItems.Add(b.get_author());
                item.SubItems.Add(b.get_publication());
                item.SubItems.Add(b.get_published_date());
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Please enter valid values");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            library.search(input_name.Text, input_author.Text, input_publication.Text);

            // clear existing rows in dataGridView1
            dataGridView1.Rows.Clear();

            // search the list for the value
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == input_name.Text || item.SubItems[1].Text == input_author.Text || item.SubItems[2].Text == input_publication.Text)
                {
                    item.BackColor = Color.Yellow;

                    // show all the items that match the search in dataGridView1 
                    dataGridView1.Rows.Add(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                }
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
