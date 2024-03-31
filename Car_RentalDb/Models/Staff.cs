﻿namespace Car_RentalDb.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Active { get; set; }
        public string Address { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
