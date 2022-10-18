using Debugger;

class ProductsContainer<T>
{
    private static readonly int s_dayNow = DateTime.Now.Day, s_monthNow = DateTime.Now.Month, s_yearNow = DateTime.Now.Year;

    private Product<T> _productHead;
    private Product<T> _productTail;
    private int _count;

    private List<T> _productsList;

    public ProductsContainer()
    {
        _productsList = new List<T>();
    }

    public int Count => _count;

    public int CheckExpiredItems()
    {
        int countExpiredItems = 0;

        int counter = 0;

        Product<T> node = _productHead;

        if (_count == 0) return 0;

        while (counter < _count)
        {
            if (node.GetExpireDays() > 0)
            {
                countExpiredItems++;
            }

            node = node.Next;

            counter++;
        }

        return countExpiredItems;
    }

    public void Push(int day, int month, int year, T val, bool isCheck)
    {
        if (isCheck == false)
        {
            if ((day < s_dayNow && month == s_monthNow) || (month < s_monthNow && year == s_yearNow) || year < s_yearNow)
            {
                throw new Exception("Object has already expired!");
            }
        }

        Product<T> node = new(day, month, year, val);

        node.Previous = _productTail;

        if (_productTail == null) _productHead = node;
        else _productTail.Next = node;

        _productTail = node;

        _count++;
    }

    public List<T> FindExpiredElements()
    {
        int counter = 0;

        Product<T> node = _productHead;

        if (_count == 0) return default;

        while (counter < _count)
        {
            if (node.GetExpireDays() > 0)
            {
                _productsList.Add(node.Value);
            }

            node = node.Next;

            counter++;
        }

        return _productsList;
    }

    public void PopBad()
    {
        int counter = 0;

        Product<T> node = _productHead;

        if (_count == 0) throw new Exception("List is empty!");

        if (_count == 1)
        {
            node = null;
        }

        if (node == null) return;

        while (counter < _count)
        {
            if (node.GetExpireDays() > 0)
            {
                node = node.Next;

                node.Previous = null;

                _count--;
                
            }
            node = node.Next;

            counter++;
        }
    }

    public void PopFresh()
    {
        int counter = _count;

        Product<T> node = _productTail;

        if (_count == 0) throw new Exception("List is empty!");

        while (counter > 0)
        {
            if (node?.GetExpireDays() > 0)
            {
                if (counter == 0)
                {
                    node = node.Previous;

                    node.Next = null;

                    _count--;
                }
            }

            node = node?.Previous;

            counter--;
        }      
    }
}
