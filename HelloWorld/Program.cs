namespace Helloworld{
    class Program{
         static void Main(){
            DateOnly dateConverted = new DateOnly() ;
            string nameInput;
            String birthdayDate;
            bool isDateValid = false;

            Console.WriteLine(" welcome to calculator of Age");
            Console.WriteLine(" Writte your name.");
            nameInput = Console.ReadLine();
            Console.WriteLine("It is a pleasure will have haere you " +( nameInput) );  
            
            while (!isDateValid){
                Console.WriteLine("Tell me your Birthday date please in format dd/mm/yy");
                birthdayDate = Console.ReadLine();
                isDateValid = DateOnly.TryParse(birthdayDate,out dateConverted);
            if(!isDateValid) Console.WriteLine("this date is incorrect, the correct format is:" + (dateConverted));
            else Console.WriteLine($"The date {dateConverted} is valid.");
            }
            Console.WriteLine();

            var person = new Person{
                name = nameInput,
                birthday = dateConverted,
                age = DateTime.Now.Year-dateConverted.Year, 
            };
            Console.WriteLine($"Your name is {person.name}");
            Console.WriteLine($"Your birthday is {person.birthday}");
            Console.WriteLine($"Your Age is {person.age}");

            
                 }
    }

    class Person{
        public string name { get; set; }
        public int age { get; set; }
        public DateOnly birthday { get; set; }
    }
}