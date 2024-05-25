class Fractions
{
    private int _numerator;
    private int _denominator;

    public Fractions()
    {
        this._numerator = 1;
        this._denominator = 1;
    }
   public Fractions(int numerator)
   {
        this._numerator = numerator;
        this._denominator = 1;
   }
    public Fractions(int numerator, int denominator)
    {
          this._numerator = numerator;
          this._denominator = denominator;
    }
    public int GetNumerator()
    {
        return this._numerator;
    }   
    public int GetDenominator()
    {
        return this._denominator;
    }   
    public void SetNumerator(int numerator)
    {
        this._numerator = numerator;
    }    
    public void SetDenominator(int denominator)
    {
        this._denominator = denominator;
    }
    public string GetFractionString()
    {
        return $"{this._numerator}/{this._denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)this._numerator / this._denominator;
    }
} 
   