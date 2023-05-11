using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notify
    {
        public Notify() 
        {
            Notifications = new List<Notify>();
        }

        [NotMapped]
        public string? NamePropierty { get; set; }

        [NotMapped]
        public string? Message { get; set; }

        [NotMapped]
        public List<Notify> Notifications { get; set; }

        public bool ValidatePropiertyString(string value, string namePropierty)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(namePropierty))
            {
                Notifications.Add(new Notify
                {
                    Message = value,
                    NamePropierty = namePropierty,
                });
                return false;
            }
            return true;
        }
    }
}