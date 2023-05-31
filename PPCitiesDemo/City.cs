namespace PPCitiesDemo
{
    public record City
    {
        public string Country { get; set; }
        public string CityName { get; set; }
    }

    public class CityDB
    {
        private static List<City> _cities = new List<City>()
        {
            new City {Country = "USA", CityName = "Orlando"},
            new City {Country = "USA", CityName = "Seattle"},
            new City {Country = "USA", CityName = "Atlanta"},
            new City {Country = "Canada", CityName = "Vancouver"},
            new City {Country = "Canada", CityName = "Montreal"},
            new City {Country = "Brazil", CityName = "Sao Paulo"},
            new City {Country = "Brazil", CityName = "Santo Andre"},
            new City {Country = "Brazil", CityName = "Sao Caetano"},
            new City {Country = "Malta", CityName = "Marsaskala"},
            new City {Country = "Malta", CityName = "Valletta"},
            new City {Country = "New Zealand", CityName = "Christchurch"},
            new City {Country = "New Zealand", CityName = "Wellington"},
            new City {Country = "New Zealand", CityName = "Dunedin"},
            new City {Country = "New Zealand", CityName = "Queenstown"},
            new City {Country = "Netherlands", CityName = "Rotterdam"},
            new City {Country = "Netherlands", CityName = "The Hague"},
            new City {Country = "Netherlands", CityName = "Utrecht"},
            new City {Country = "Netherlands", CityName = "Gouda"},
            new City {Country = "Germany", CityName = "Munich"},
            new City {Country = "Germany", CityName = "Berlin"},
            new City {Country = "Argentina", CityName = "Rosario"}
        };

        public static List<City> GetCities()
        {
            return _cities;
        }

        public static List<City> GetCities(string country)
        {
            return _cities.Where(c => c.Country == country).ToList();
        }

        public static List<String> GetCountries()
        {
            return new List<string> { "USA", "Canada", "Brazil", "Netherlands", "Malta", "New Zealand" };
        }
    }
}
