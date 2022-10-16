using Debugger;

class Product<T> : IExpired
{
    private int _dd, _mm, _yyyy;

    private static readonly int s_ddNow = DateTime.Now.Day, s_mmNow = DateTime.Now.Month, s_yyyyNow = DateTime.Now.Year;

    private T _value;

    public Product<T> Next, Previous;
    
    public Product(int day, int month, int year, T value)
    {
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

        if ((_dd < s_ddNow && _mm == s_mmNow) || (_mm < s_mmNow && (_yyyy < s_yyyyNow || _yyyy == s_yyyyNow)) || _yyyy < s_yyyyNow)
        {
            days = (s_ddNow - _dd) + ((s_mmNow - _mm) * 30) + ((s_yyyyNow - _yyyy) * 365);
        }

        return days;
    }
}