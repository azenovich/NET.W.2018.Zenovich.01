﻿using NET.W._2018.Zenovich._01.ServiceClassification.API;
using NET.W._2018.Zenovich._01.ServiceClassification.Exception;
using System;

namespace NET.W._2018.Zenovich._01.ServiceClassification.Model
{
    public class DateTimeService : Service
    {
        private DateTime _dateTime;

        public DateTimeService(string name, string urlAddress)
            : base(name, urlAddress)
        {
        }

        public string Time
        {
            get
            {
                return _dateTime.ToShortTimeString() ?? throw new InvalidOperationServiceException();
            }
        }

        public string Date
        {
            get
            {
                return _dateTime.ToShortDateString() ?? throw new InvalidOperationServiceException();
            }
        }

        public override string Request()
        {
            Console.WriteLine($"{nameof(DateTimeService)}...");

            _dateTime = DateTime.Now;

            Console.WriteLine(new String('-', 10));

            return $"Service name: {_name}\nTime: {Date}\nDate: {Time}\n";
        }
    }
}
