﻿using NET.W._2018.Zenovich._01.ServiceClassification.API;
using NET.W._2018.Zenovich._01.ServiceClassification.Exception;
using System;

namespace NET.W._2018.Zenovich._01.ServiceClassification.Model
{
    public class WeatherService : Service
    {
        private double _temperature;
        private string _location;

        public WeatherService(string name, string urlAdress) 
            : base(name, urlAdress)
        {
            _temperature = Double.NaN;
        }

        public double Temperature
        {
            get
            {
                if (_temperature == Double.NaN)
                {
                    throw new InvalidOperationServiceException();
                }

                return _temperature;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value ?? throw new ArgumentNullException(nameof(Location));
            }
        }

        public override string Request()
        {
            if (_location == null)
            {
                throw new InvalidOperationException($"{nameof(Location)} is undefined");
            }

            Console.WriteLine($"{nameof(WeatherService)}...");

            _temperature = 10.5;

            Console.WriteLine(new String('-', 10));

            return $"Service name: {_name}\nLocation: {_location}\nTemperature: {_temperature}\n";
        }
    }
}
