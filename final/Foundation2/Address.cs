using System;

public class Address
{
    public string StreetAddress { get; }
    public string City { get; }
    public string StateProvince { get; }
    public string Country { get; }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public string GetAddressAsString()
    {
        return $" {StreetAddress}\n {City}, {StateProvince}\n {Country}";
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }
}
