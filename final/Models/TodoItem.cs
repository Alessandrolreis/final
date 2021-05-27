using System;
using System.ComponentModel.DataAnnotations;
namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string email { get; set; }
        public string card { get; set; }

        
    }
}