using UniversityApp.UniversityDomain.Entities;
using UniversityApp.UniversityDomain.ValueObjects;

namespace UniversityApp.ConsoleClient
{
    public class UniversityInitializer
    {
        public static University Initialize()
        {
            // Створення координаторів
            var coordinator1 = new Coordinator(Guid.NewGuid(), new FullName("Олександр", "Петренко"), 50000, new DateTime(1985, 6, 15), new Address("вул. Хрещатик, 1", "Київ", "Київська область", "01001", "Україна"));
            var coordinator2 = new Coordinator(Guid.NewGuid(), new FullName("Марія", "Іваненко"), 52000, new DateTime(1990, 3, 22), new Address("вул. Стрийська, 10", "Львів", "Львівська область", "79000", "Україна"));
            var coordinator3 = new Coordinator(Guid.NewGuid(), new FullName("Ігор", "Сердюк"), 48000, new DateTime(1982, 11, 5), new Address("вул. Дерибасівська, 7", "Одеса", "Одеська область", "65000", "Україна"));
            var coordinator4 = new Coordinator(Guid.NewGuid(), new FullName("Анна", "Коваленко"), 51000, new DateTime(1988, 9, 12), new Address("просп. Науки, 15", "Харків", "Харківська область", "61000", "Україна"));

            // Створення студентів
            var students = new List<Student>
            { 
                new Student(Guid.NewGuid(), new FullName("Олександр", "Іванов"), 90, new DateTime(2000, 1, 10), new Address("вул. Льва Толстого, 2", "Київ", "Київська область", "01001", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Марія", "Петрівна"), 85, new DateTime(2001, 2, 15), new Address("вул. Шевченка, 5", "Львів", "Львівська область", "79000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Ігор", "Мельник"), 88, new DateTime(2000, 3, 20), new Address("вул. Січових Стрільців, 8", "Одеса", "Одеська область", "65000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Анна", "Дерев'янко"), 92, new DateTime(2001, 4, 25), new Address("вул. Різдвяна, 12", "Харків", "Харківська область", "61000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Петро", "Коваленко"), 87, new DateTime(2000, 5, 5), new Address("вул. Миколи Лисенка, 7", "Київ", "Київська область", "02000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Ірина", "Гречка"), 91, new DateTime(2001, 6, 10), new Address("вул. Суворова, 10", "Дніпро", "Дніпропетровська область", "49000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Віталій", "Сидоренко"), 89, new DateTime(1999, 7, 15), new Address("вул. Ломоносова, 3", "Київ", "Київська область", "03000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Олена", "Степанова"), 93, new DateTime(2002, 8, 20), new Address("вул. Леніна, 21", "Запоріжжя", "Запорізька область", "69000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Тарас", "Мельник"), 86, new DateTime(2001, 9, 5), new Address("вул. Пушкіна, 13", "Суми", "Сумська область", "40000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Людмила", "Косенко"), 90, new DateTime(2000, 10, 11), new Address("вул. Коцюбинського, 4", "Київ", "Київська область", "02000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Микита", "Савченко"), 88, new DateTime(1999, 11, 30), new Address("вул. Гагаріна, 1", "Одеса", "Одеська область", "65000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Анастасія", "Коваль"), 95, new DateTime(2002, 12, 25), new Address("вул. Свердлова, 9", "Харків", "Харківська область", "61000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Олег", "Руденко"), 84, new DateTime(2001, 1, 7), new Address("вул. Мельниченка, 16", "Чернівці", "Чернівецька область", "58000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Дмитро", "Шевченко"), 89, new DateTime(2000, 2, 14), new Address("вул. Небесної Сотні, 22", "Івано-Франківськ", "Івано-Франківська область", "76000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Ірина", "Павленко"), 87, new DateTime(1999, 3, 21), new Address("вул. Тараса Шевченка, 4", "Черкаси", "Черкаська область", "18000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Максим", "Левченко"), 92, new DateTime(2001, 4, 8), new Address("вул. Софіївська, 6", "Луцьк", "Волинська область", "43000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Єва", "Коваленко"), 90, new DateTime(2000, 5, 19), new Address("вул. Квітнева, 11", "Харків", "Харківська область", "61000", "Україна")),
                new Student(Guid.NewGuid(), new FullName("Тимур", "Бондаренко"), 94, new DateTime(2002, 6, 29), new Address("вул. Леніна, 18", "Житомир", "Житомирська область", "10000", "Україна"))
            };

            // Створення груп
            var group1 = new Group(Guid.NewGuid(),"Група 1", coordinator1) { Students = students.GetRange(0, 4) };
            var group2 = new Group(Guid.NewGuid(),"Група 2", coordinator2) { Students = students.GetRange(4, 4) };
            var group3 = new Group(Guid.NewGuid(),"Група 3", coordinator3) { Students = students.GetRange(8, 5) };
            var group4 = new Group(Guid.NewGuid(),"Група 4", coordinator4) { Students = students.GetRange(13, 5) };

            // Створення факультетів
            var faculty1 = new Faculty(Guid.NewGuid(),"Факультет комп'ютерних наук") { Coordinators = [coordinator1, coordinator3], Groups = [group1, group3] };
            var faculty2 = new Faculty(Guid.NewGuid(),"Факультет електроніки") { Coordinators = [coordinator2, coordinator4], Groups = [group2, group4] };
            var faculty3 = new Faculty(Guid.NewGuid(),"Факультет інформаційних технологій") { Coordinators = [coordinator3], Groups = [group3] };
            var faculty4 = new Faculty(Guid.NewGuid(),"Факультет телекомунікацій") { Coordinators = [coordinator4], Groups = [group4] };

            // Створення університету
            var university = new University(Guid.NewGuid(),"ХНУРЕ")
            {
                YearOfFoundation = new DateTime(1930, 11, 8), // Дата заснування ХНУРЕ
                Faculties = [faculty1, faculty2, faculty3, faculty4]
            };

            return university;
        }
    }
}
