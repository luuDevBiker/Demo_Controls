using Demo_Controls_UI.Models;
using Demo_Controls_UI.Services;
namespace Demo_Controls_UI
{
    public partial class Form1 : Form
    {
        private int _id;
        private List<Book> _lstBook;
        private BookServices _bookServices;
        public Form1()
        {
            InitializeComponent();
            _lstBook = new List<Book>();
            _bookServices = new BookServices();
            GetData();
        }
        private void GetData()
        {
            _lstBook = _bookServices.GetBooks();
            var lstPrice = _lstBook.Select(x => x.Price).ToList();
            if(lstPrice.Count > 0)// 1 2 3 4 
            {
                var index = lstPrice.Count - 1;
                foreach (var item in lstPrice)
                {
                    cbb_Price.Items.Add(item);
                }
                cbb_Price.SelectedIndex = index;
            }

        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            GetData();
            Dgv_Book.Rows.Clear();
            var countColumns = _lstBook.Count;
            Dgv_Book.ColumnCount = countColumns;
            Dgv_Book.Columns[0].Name = "Mã Sách";
            Dgv_Book.Columns[1].Name = "Tên sách";
            Dgv_Book.Columns[2].Name = "Title";
            Dgv_Book.Columns[3].Name = "Số lượng";
            Dgv_Book.Columns[4].Name = "Giá";
            int columnIndex = 0;
            _lstBook.ForEach(entity =>
            { 
                DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn();
                DeleteButton.Name = "Delete";
                DeleteButton.Text = "Delete";
                DeleteButton.UseColumnTextForButtonValue = true;

                if (Dgv_Book.Columns["Delete"] == null)
                {
                    Dgv_Book.Columns.Insert(5, DeleteButton);
                }
                DataGridViewButtonColumn AddButton = new DataGridViewButtonColumn();
                AddButton.Name = "Add";
                AddButton.Text = "Add";
                AddButton.UseColumnTextForButtonValue = true;

                if (Dgv_Book.Columns["Add"] == null)
                {
                    Dgv_Book.Columns.Insert(6, AddButton);
                }
                DataGridViewButtonColumn UpdateButton = new DataGridViewButtonColumn();
                UpdateButton.Name = "Update";
                UpdateButton.Text = "Update";
                UpdateButton.UseColumnTextForButtonValue = true;

                if (Dgv_Book.Columns["Update"] == null)
                {
                    Dgv_Book.Columns.Insert(7, UpdateButton);
                }
                Dgv_Book.Rows.Add(
                    entity.BookId,
                    entity.BookName,
                    entity.Title,
                    entity.Quantity,
                    entity.Price
                    );
            });

        }
        private void Dgv_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            int indexColumn = e.ColumnIndex;
            if (indexRow < 0) return;
            var row = Dgv_Book.Rows[indexRow];
            //else
            //{
            //    var row = Dgv_Book.Rows[indexRow];
            //    _id = int.Parse(row.Cells[0].Value + "");
            //    txt_Name.Text = Convert.ToString(row.Cells[1].Value);
            //    txt_Title.Text = Convert.ToString(row.Cells[2].Value);
            //    txt_Quantity.Text = Convert.ToString(row.Cells[3].Value);
            //    txt_Price.Text = Convert.ToString(row.Cells[4].Value);
            //}
            

            if(indexColumn == 6)
            {
                var book = new Book();
                
                book.BookId = _id;
                book.BookName = Convert.ToString(row.Cells[1].Value);
                book.Title = Convert.ToString(row.Cells[2].Value);
                book.Quantity = Convert.ToInt32(row.Cells[3].Value);
                book.Price = Convert.ToInt32(row.Cells[4].Value);
                _bookServices.AddBook(book);
                btn_load_Click(null, null);
            }

            if(indexColumn == 5)
            {
                var id = Convert.ToInt32(row.Cells[0].Value);
                _bookServices.DeleteBook(id);
                btn_load_Click(null, null);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var book = new Book();

            var name = txt_Name.Text;
            var title = txt_Title.Text;
            var quantity = int.Parse(txt_Quantity.Text);
            var price = float.Parse(txt_Price.Text);

            book.BookName = name;
            book.Title = title;
            book.Quantity = quantity;
            book.Price = price;

            _bookServices.AddBook(book);

            btn_load_Click(null, null);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var book = new Book();

            book.BookId = _id;
            book.BookName = txt_Name.Text;
            book.Title = txt_Title.Text;
            book.Quantity = Convert.ToInt32(txt_Quantity.Text);
            book.Price = Convert.ToInt32(txt_Price.Text);
        
            _bookServices.UpdateBook(book);

            btn_load_Click(null, null);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            _bookServices.DeleteBook(_id);
            btn_load_Click(null, null);
        }
    }
}