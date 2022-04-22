using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoUniversityModelBinding.Models;
using DotVVM.Framework.Controls;
using DotVVM.Framework.ViewModel;

namespace DotvvmApp1.ViewModels
{
    public class StudentsViewModel : SiteViewModel
    {
        public GridViewDataSet<Student> _Students { get; set; } = new GridViewDataSet<Student>();
        public override Task PreRender()
        {  
            if (_Students.IsRefreshRequired)
            {
                List<Student> dt = new List<Student>();
                using(var studentData = new SchoolContext())
                {
                    dt = studentData.Students.Where(s => !string.IsNullOrEmpty(s.FirstName)).ToList();
                    
                }
                _Students.LoadFromQueryable(dt.AsQueryable<Student>());

                //var queryable = ContosoUniversityModelBinding.Models.SchoolContext;

            }
            return base.PreRender();
        }
    }

}
