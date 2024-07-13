using ERP.TrainingManagement.Core.Entities;
using ERP.TrainingManagement.DataServices.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.TrainingManagement.DataServices.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ERP.TrainingManagement.DataServices.Data;


namespace ERP.TrainingManagement.DataServices.Repository
{
    public class StudentManagementRepository : GenericRepository<Student>, IStudentManagementRepository
    {
        public StudentManagementRepository(AppDbContext context, ILogger logger) : base(context, logger)
        {

            
        }

        public Task<bool> Add(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

       
        public Task<bool> Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<ApplicationUser>> IGenericRepository<ApplicationUser>.All()
        {
            throw new NotImplementedException();
        }

        Task<ApplicationUser?> IGenericRepository<ApplicationUser>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Student?> IStudentManagementRepository.GetStudentByRegisterNumber(int registerNumber)
        {
            throw new NotImplementedException();
        }
    }
    
}
