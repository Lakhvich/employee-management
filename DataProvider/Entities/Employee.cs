using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Entities
{
    [Table(Name = "Employees")]
    public class Employee
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "EmployeeID")]
        public int EmployeeID { get; set; }

        [Column(Name = "FName")]
        [StringLength(15, ErrorMessage = "Имя превышает 15 символов")]
        [Required(ErrorMessage = "Поле Имя обязательна для заполнения")]
        public string FName { get; set; }

        [Column(Name = "LName")]
        [StringLength(15, ErrorMessage = "Фамилия превышает 15 символов")]
        [Required(ErrorMessage = "Поле Фамилия обязательна для заполнения")]
        public string LName { get; set; }

        [Column(Name = "Position")]
        [StringLength(50, ErrorMessage = "Введеная должность превышает 50 символов")]
        [Required(ErrorMessage = "Навание должности не может быть пустым")]
        public string Position { get; set; }

        [Column(DbType = "Money", Name = "Salary")]
        [Required(ErrorMessage = "Пожалуйста введите заработную плату сотрудника")]
        public decimal Salary { get; set; }

        [Column(Name = "DateOfBirth")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Пожалуйста введите дату рождения сотрудника")]
        public DateTime DateOfBirth { get; set; }
    }
}
