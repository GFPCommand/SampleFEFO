using Debugger;

class Product<T> : IExpired
{
    private int _dd, _mm, _yyyy;

    private int _ddNow, _mmNow, _yyyyNow;

    private T _value;

    public Product<T> Next, Previous;
    
    public Product(int day, int month, int year, T value)
    {
        _ddNow = DateTime.Now.Day;
        _mmNow = DateTime.Now.Month;
        _yyyyNow = DateTime.Now.Year;

        _dd = day;
        _mm = month;
        _yyyy = year;

        _value = value;
    }

    public int Day => _dd;
    public int Month => _mm;
    public int Year => _yyyy;

    public T Value => _value;

    public int GetExpireDays()
    {
        int days = 0;

        if ((_dd < _ddNow && _mm == _mmNow) || (_mm < _mmNow && (_yyyy < _yyyyNow || _yyyy == _yyyyNow)) || _yyyy < _yyyyNow)
        {
            days = (_ddNow - _dd) + ((_mmNow - _mm) * 30) + ((_yyyyNow - _yyyy) * 365);
        }

        return days;
    }
}