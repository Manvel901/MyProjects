namespace Seminar1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            FaamilyMember Grandfather1 = new FaamilyMember()
            {
                Age = 66,
                FullName = "Навоян Манвел Хачикович",
                Gender = Gender.man,
               
             };

            FaamilyMember Grandfather2 = new FaamilyMember()
            {
                Age = 64,
                FullName = "Мардоян Ваник Варданович",
                Gender = Gender.man,
              
             };
            FaamilyMember Grandmother1 = new FaamilyMember()
            {
                Age = 60,
                FullName = "Навоян Светлана Георгиевна",
                Gender = Gender.woman,
               
             };
            FaamilyMember Grandmother2 = new FaamilyMember()
            {
                Age = 58,
                FullName = "Мардоян Анна Вагановна",
                Gender = Gender.woman,
            
             }; FaamilyMember Mother = new FaamilyMember()
             {
                 Age = 41,
                 FullName = "Мардоян Сюзанна Ваниковна",
                 Gender = Gender.woman,
                 Father = Grandfather2,
                 Mother = Grandmother2
             };
            FaamilyMember Father = new FaamilyMember()
            {
                Age = 47,
                FullName = "Навоян Эмиль Манвелович",
                Gender = Gender.man,
                Father = Grandfather1,
                Mother =Grandmother1
             };
            FaamilyMember Son = new FaamilyMember()
            {
                Age = 20,
                FullName = "Навоян Манвел Эмильевич",
                Gender = Gender.man,
                Father = Father,
                Mother = Mother

             };

            var GrandFather = Son.GetGrandFatherName();
            Console.WriteLine(GrandFather[0]?.FullName.ToUpper());
            Console.WriteLine(GrandFather[1]?.FullName.ToLower());
            Console.WriteLine(GrandFather[1].FullName);

        }
    }
}
