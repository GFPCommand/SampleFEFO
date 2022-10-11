using Debugger;

class ProductsContainer<T>
{
    private readonly int _dayNow, _monthNow, _yearNow;

    private Product<T> _productHead;
    private Product<T> _productTail;
    private int _count;

    private List<T> _productsList;

    public ProductsContainer()
    {
        _productsList = new List<T>();

        _dayNow = DateTime.Now.Day;
        _monthNow = DateTime.Now.Month;
        _yearNow = DateTime.Now.Year;
    }

    public int Count => _count;

    public List<T> ProductsList => _productsList;

    public int CheckExpiredItems()
    {
        int countExpiredItems = 0;

        int counter = 0;

        Product<T> node = _productHead;

        if (_count == 0) return 0;

        DebugClass.WriteDebugDataToFile(_count.ToString());

        while (counter < _count)
        {
            if (node.GetExpireDays() != 0)
            {
                countExpiredItems++;
                node = node.Next;
            }

            counter++;
        }

        return countExpiredItems;
    }

    public void Push(int day, int month, int year, T val, bool isCheck)
    {
        if (isCheck == false)
        {
            if ((day < _dayNow && month == _monthNow) || (month < _monthNow && (year < _yearNow || year == _yearNow)) || year < _yearNow)
            {
                throw new Exception("Object has already expired!");
            }
        }

        Product<T> node = new(day, month, year, val);

        if (_productTail == null) _productHead = node;
        else _productTail.Next = node;

        _productTail = node;

        _count++;
    }

    public void PopBad() //i have some issues in this method. i should try to fix it anyway. one of variants is change pointers
    {
        int counter = 0;

        Product<T> node = _productHead;

        if (_count == 0) throw new Exception("List is empty!");

        while (counter < _count)
        {
            if (node.GetExpireDays() > 0)
            {
                _productsList.Add(node.Value);
            }

            node = node.Next;

            counter++;
        }

        _count--;
    }

    public void PopFresh()
    {
        int counter = _count;

        Product<T> node = _productTail;

        if (_count == 0) throw new Exception("List is empty!");

        while (counter > 0)
        {
            if (node.GetExpireDays() > 0)
            {
                _productsList.Add(node.Value);
            }

            node = node.Previous;

            counter--;
        }

        _count--;
    }
}