using UniversityEntities;

namespace ConsoleClient
{
    public class UniversityInitializer
    {
        public static University Initialize()
        {
            // Створення координаторів
            var coordinator1 = new Coordinator(Guid.NewGuid(), "Іван", "Петров", new DateTime(1980, 5, 15), 50000);
            var coordinator2 = new Coordinator(Guid.NewGuid(), "Марія", "Іванова", new DateTime(1985, 8, 20), 55000);
            var coordinator3 = new Coordinator(Guid.NewGuid(), "Андрій", "Коваленко", new DateTime(1978, 3, 12), 60000);
            var coordinator4 = new Coordinator(Guid.NewGuid(), "Світлана", "Мороз", new DateTime(1982, 7, 30), 58000);

            // Створення студентів
            var students = new List<Student>
            {
                new(Guid.NewGuid(), "Олександр", "Коваленко", new DateTime(2000, 1, 10), 90),
                new(Guid.NewGuid(), "Наталія", "Шевченко", new DateTime(2001, 2, 15), 85),
                new(Guid.NewGuid(), "Дмитро", "Сидоренко", new DateTime(2000, 3, 20), 88),
                new(Guid.NewGuid(), "Ольга", "Мельник", new DateTime(2001, 4, 25), 92),
                new(Guid.NewGuid(), "Володимир", "Гончаренко", new DateTime(2000, 5, 5), 87),
                new(Guid.NewGuid(), "Юлія", "Романенко", new DateTime(2001, 6, 10), 91),
                new(Guid.NewGuid(), "Максим", "Литвин", new DateTime(1999, 7, 15), 89),
                new(Guid.NewGuid(), "Тетяна", "Захарова", new DateTime(2002, 8, 20), 93),
                new(Guid.NewGuid(), "Олег", "Михайленко", new DateTime(2001, 9, 5), 86),
                new(Guid.NewGuid(), "Ірина", "Гаврилюк", new DateTime(2000, 10, 11), 90),
                new(Guid.NewGuid(), "Петро", "Кравченко", new DateTime(1999, 11, 30), 88),
                new(Guid.NewGuid(), "Вікторія", "Семенюк", new DateTime(2002, 12, 25), 95),
                new(Guid.NewGuid(), "Артем", "Данилюк", new DateTime(2001, 1, 7), 84),
                new(Guid.NewGuid(), "Катерина", "Луценко", new DateTime(2000, 2, 14), 89),
                new(Guid.NewGuid(), "Сергій", "Паламарчук", new DateTime(1999, 3, 21), 87),
                new(Guid.NewGuid(), "Анна", "Дорошенко", new DateTime(2001, 4, 8), 92),
                new(Guid.NewGuid(), "Ігор", "Шевчук", new DateTime(2000, 5, 19), 90),
                new(Guid.NewGuid(), "Марина", "Бондаренко", new DateTime(2002, 6, 29), 94)
            };

            // Створення груп
            var group1 = new Group("Група 1", coordinator1) { Students = students.GetRange(0, 4) };
            var group2 = new Group("Група 2", coordinator2) { Students = students.GetRange(4, 4) };
            var group3 = new Group("Група 3", coordinator3) { Students = students.GetRange(8, 5) };
            var group4 = new Group("Група 4", coordinator4) { Students = students.GetRange(13, 5) };

            // Створення факультетів
            var faculty1 = new Faculty("Факультет комп'ютерних наук") { Coordinators = [coordinator1, coordinator3], Groups = [group1, group3] };
            var faculty2 = new Faculty("Факультет електроніки") { Coordinators = [coordinator2, coordinator4], Groups = [group2, group4] };
            var faculty3 = new Faculty("Факультет інформаційних технологій") { Coordinators = [coordinator3], Groups = [group3] };
            var faculty4 = new Faculty("Факультет телекомунікацій") { Coordinators = [coordinator4], Groups = [group4] };

            // Створення університету
            var university = new University("ХНУРЕ")
            {
                YearOfFoundation = new DateTime(1930, 11, 8), // Дата заснування ХНУРЕ
                Faculties = [faculty1, faculty2, faculty3, faculty4]
            };
            
            return university;
        }
    }
}
