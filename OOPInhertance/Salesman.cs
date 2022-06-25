using System;

public abstract class Salesman
{
    private string _firstName;
    private string _lastName;

    public Salesman(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FullName
    {
        get
        {
            return string.Format("{0} {1}", _firstName, _lastName);
        }
    }

    public abstract void Sell();
}