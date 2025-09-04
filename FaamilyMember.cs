using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    /*
    * Спроектируйте программу для построения генеалогического дерева. 
    * Учтите что у нас есть члены семьи у кого нет детей(дет).
    * Есть члены семьи у кого дети есть (взрослые).
    * Есть мужчины и женщины.*/

    /*Доработать предыдущий класс реализовав методы вывода родителей, детей, 
     * братьев/сестер (включая двоюродных),
     * бабушеки дедушек. 
     * Подумайте как лучше реализовать данные методы.*/

   public enum Gender { man, woman}
    public class FaamilyMember
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get; set; }
       public FaamilyMember Father { get; set; }
        public FaamilyMember Mother { get; set; }

        public FaamilyMember[] GetGrandMotherName()
        {
            return new FaamilyMember[] { Mother?.Mother, Father?.Mother };
        }
        public FaamilyMember[] GetGrandFatherName()
        {
            return new FaamilyMember[] { Mother?.Father, Father?.Father };
        }
    }
}
