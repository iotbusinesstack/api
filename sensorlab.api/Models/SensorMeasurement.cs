using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace sensorlab.api.Models
{
    [Table(Name = "SensorMeasurement")]
    public class SensorMeasurement
    {
       
       
        private long id;
        [Column(Storage = "id")]
        public long Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public int SensorId { get; set; }

        //private long sensor_id;
        //[Column(Name = "SensorId", Storage = "sensor_id")]
        //public long SensorId
        //{
        //    get
        //    {
        //        return this.sensor_id;
        //    }
        //    set
        //    {
        //        this.sensor_id = value;
        //    }
        //}

        private string type;
        [Column(Storage = "type")]
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }


        private string measurementnumber;
        [Column(Storage = "measurementnumber")]
        public string MeasurementNumber
        {
            get
            {
                return this.measurementnumber;
            }
            set
            {
                this.measurementnumber = value;
            }
        }

        private decimal measurementdecimal;
        [Column(Storage = "measurementdecimal")]
        public decimal MeasurementDecimal
        {
            get
            {
                return this.measurementdecimal;
            }
            set
            {
                this.measurementdecimal = value;
            }
        }

        private string measurementmext;
        [Column(Storage = "measurementmext")]
        public string MeasurementText
        {
            get
            {
                return this.measurementmext;
            }
            set
            {
                this.measurementmext = value;
            }
        }


        private DateTime? created;
        [Column(Storage = "created")]
        public DateTime? Created
        {
            get
            {
                return this.created;
            }
            set
            {
                this.created = value;
            }
        }

        private DateTime? received;
        [Column(Storage = "received")]
        public DateTime? Received
        {
            get
            {
                return this.received;
            }
            set
            {
                this.received = value;
            }
        }

        private Guid measurementgroup;
        [Column(Storage = "measurementgroup")]
        public Guid MeasurementGroup
        {
            get
            {
                return this.measurementgroup;
            }
            set
            {
                this.measurementgroup = value;
            }
        }

    }

    
}