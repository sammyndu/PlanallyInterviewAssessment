using System;
using System.Collections.Generic;
using System.Text;

namespace Question6
{
    public class Building
    {
        private List<string> rooms = new List<string>();
        private string description = "";

        public Building AddKitchen(string kitchenName = "")
        {
            var kitchen = "kitchen";

            this.rooms.Add(String.IsNullOrEmpty(kitchenName) ? kitchen : kitchenName + " " + kitchen);
            return this;
        }

        public Building AddBedroom(string bedroomName = "")
        {
            var bedroom = "room";

            this.rooms.Add(String.IsNullOrEmpty(bedroomName) ? bedroom : bedroomName + " " + bedroom);

            return this;
        }

        public Building AddBalcony(string balconyName = "")
        {
            var balcony = "balcony";

            this.rooms.Add(String.IsNullOrEmpty(balconyName) ? balcony : balconyName + " " + balcony);

            return this;
        }

        public Building Build()
        {
            description = String.Join(", ", rooms.ToArray());

            return this;
        }

        public string Describe()
        {

            return description;
        }



    }
}
