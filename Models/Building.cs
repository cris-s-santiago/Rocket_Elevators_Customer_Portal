using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocket_Elevators_Customer_Portal.Models
{
    public class Building
    {
        public int id { get; set; }
        public string full_name_of_the_building_administrator { get; set; }
        public string email_of_the_administrator_of_the_building { get; set; }
        public string phone_number_of_the_building_administrator { get; set; }
        public string full_name_of_the_technical_contact_for_the_building { get; set; }
        public string technical_contact_email_for_the_building { get; set; }
        public string technical_contact_phone_for_the_building { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int customer_id { get; set; }
        public int address_id { get; set; }
        public List<Battery> batteries { get; set; }
        public Customer customer { get; set; }
    }


// BUILDING TABLE from the schema of the Ruby on Rails's base project
/* create_table "buildings", options: "ENGINE=InnoDB DEFAULT CHARSET=utf8", force: :cascade do | t |
    t.string "full_name_of_the_building_administrator"
    t.string "email_of_the_administrator_of_the_building"
    t.string "phone_number_of_the_building_administrator"
    t.string "full_name_of_the_technical_contact_for_the_building"
    t.string "technical_contact_email_for_the_building"
    t.string "technical_contact_phone_for_the_building"
    t.datetime "created_at", null: false
    t.datetime "updated_at", null: false
    t.bigint "customer_id"
    t.bigint "address_id"
    t.index["address_id"], name: "index_buildings_on_address_id"
    t.index["customer_id"], name: "index_buildings_on_customer_id"
  end */
