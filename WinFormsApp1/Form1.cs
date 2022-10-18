using Debugger;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int _dd, _mm, _yyyy;
        private string _product = "";
        private string _productSaveName = "";
        private int _count = 1;
        private List<int> _numbers;

        private List<string> _productsList;

        ProductsContainer<string> container;

        public Form1()
        {
            InitializeComponent();

            container = new ProductsContainer<string>();
            _numbers = new List<int>();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (elementName.Text.Equals(""))
            {
                MessageBox.Show("Empty product name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _product = $"{elementName.Text} {date.Value.Day}.{date.Value.Month}.{date.Value.Year}";

            _dd = date.Value.Day;
            _mm = date.Value.Month;
            _yyyy = date.Value.Year;

            try
            {
                container.Push(_dd, _mm, _yyyy, _product, helperBox.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_productSaveName.Equals(_product))
            {
                _count++;

                if (_count <= 2)
                    products.Items.Remove($"{_product}");
                else
                    products.Items.Remove($"{_product} x{_count - 1}");

                _product += $" x{_count}";


            }
            else
            {
                _productSaveName = _product;
                _count = 1;
            }

            products.Items.Add(_product);

        }

        private void check_Click(object sender, EventArgs e)
        {
            _productsList = container.FindExpiredElements();

            if (_productsList.Count > 0)
            {
                del.Visible = true;
                checkText.Visible = true;
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            string value = "";

            for (int i = 0; i < products.Items.Count; i++)
            {
                value = products.Items[i].ToString();
                
                foreach (var item in _productsList)
                {
                    if (value.Contains(item))
                        products.Items.Remove(value);
                }
            }

            container.PopBad();
            container.PopFresh();

            MessageBox.Show("Success", "Success", MessageBoxButtons.OK);

            _count = 1;

            checkText.Visible = false;
            del.Visible = false;
        }
    }
}
