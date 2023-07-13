﻿
//using ProjectAPI.Models;

namespace ProjectAPI.Model
{
    public class HotelDetail
    {
        public int Id  { get; set; }

        public DateTime? StayDateFrom { get; set; }

        public DateTime? StayDateTo { get; set; }

        public virtual CommonTypeReference? MealPreference { get; set; }
        public int MealPreferenceId { get; set; }

        public Request Request { get; set; }    
        public int RequestId { get; set; }


        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Boolean IsActive { get; set; } = true;

    }
}
