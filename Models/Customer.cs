using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCustomers.Api.Models
{
    public class Customer
    {
    public int Id { get; set; }
	public string Full_name { get; set; } 
	public DateTime Date_of_birth {get; set;}
	public string Gender { get; set; }
	public string Cuil { get; set; }
	public string Phone { get; set; }
	public bool Deleted { get; set; } 
    }
}