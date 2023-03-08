using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEPAPIServices.BuObjects
{
    public class ObservationBo
    {
        public string Filename { get; set; }
        public string observation
        { get; set; }
        public string observation_images
        { get; set; }
        public string fda_address
        { get; set; }
        public string receiver
        { get; set; }
        public string zip_code
        { get; set; }
        public string street_address
        { get; set; }
        public string inspection_dates
        { get; set; }
        public string fei_number
        { get; set; }
        public string firm_name
        { get; set; }
        public string type
        { get; set; }
        public string investigator

        { get; set; }
        public int UniqueID
        { get; set; }

    }
}