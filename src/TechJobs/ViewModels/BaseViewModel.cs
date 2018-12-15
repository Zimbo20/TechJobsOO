using System;
using System.Collections.Generic;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {


        // The current column
        public JobFieldType Column { get; set; }

        // All fields in the given column
        public IEnumerable<JobField> Fields { get; set; }

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // View title
        public string Title { get; set; } = "";

        // The search results
        public List<Job> Jobs { get; set; }


    
    }
}
