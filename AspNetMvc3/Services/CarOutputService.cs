using AspNetMvc3.Abstractions;
using AspNetMvc3.Models;
using Newtonsoft.Json;

namespace AspNetMvc3.Services
{
    public class CarOutputService : ICarsOutputService
    {
        public void SaveToFile(Car car, string filePath)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(car.ToString());
                sw.WriteLine("*************");
            }
        }

        public void SaveToJson(Car car, string filePath)
        {
            List<Car> cars = new List<Car>();

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(jsonString))
                {
                    cars = JsonConvert.DeserializeObject<List<Car>>(jsonString);
                }
            }

            cars.Add(car);

            string updatedJson = JsonConvert.SerializeObject(cars, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }


        public List<Car> LoadFromFile(string filePath)
        {
            List<Car> cars = new List<Car>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (!line.Any(c => c == '*' || c == '?' || c == '%' || c == '$' || c == '#' || c == '@' || c == '!'))
                {
                    string[] parts = line.Split(' ');

                    string name = "", color = "", manufacturer = "";
                    int year = 0;
                    double engineSize = 0;

                    for (int i = 0; i < parts.Length; i++)
                    {
                        string partValue = parts[i].Trim().Split(':')[1].Trim();

                        switch (parts[i].Split(':')[0].Trim())
                        {
                            case "Name":
                                name = partValue;
                                break;

                            case "Color":
                                color = partValue;
                                break;
                            case "Manufacturer":
                                manufacturer = partValue;
                                break;
                            case "Year":
                                year = int.Parse(partValue);
                                break;
                            case "Engine":
                                engineSize = double.Parse(partValue);
                                break;

                        }
                    }

                    cars.Add(new Car()
                    {
                        Name = name,
                        Color = color,
                        Manufacturer = manufacturer,
                        Year = year,
                        EngineSize = engineSize
                    });
                }
            }
            return cars;
        }

        public List<Car> LoadFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(jsonString);

            List<Car> figures = cars.Cast<Car>().ToList();
            return figures;
        }

        public bool CreateCar(CarViewModel car)
        {
            SaveToFile(car.Car, "cars.txt");
            return true;
        }
    }
}
