using Observer;
using Conditions;

// Create weather station
var weatherStation = new WeatherStation();

// Create display devices
var currentConditionsDisplay = new CurrentConditionsDisplay();
var statisticsDisplay = new StatisticsDisplay();

// Register display devices as observers
weatherStation.RegisterObserver(currentConditionsDisplay);
weatherStation.RegisterObserver(statisticsDisplay);

// Simulate weather changes
weatherStation.SetWeatherData(25.5f, 60f, 1013.2f, 10.2f);
weatherStation.SetWeatherData(27.8f, 55f, 1011.5f, 12.5f);
weatherStation.SetWeatherData(23.9f, 70f, 1015.6f, 8.7f);

