namespace SingleCustomerList
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SclContext : DbContext
    {
        // Контекст настроен для использования строки подключения "MyCustomersModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SingleCustomerList.MyCustomersModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MyCustomersModel" 
        // в файле конфигурации приложения.
        //static SclContext()
        //{
        //    //Database.SetInitializer<SclContext>(new SclContextInitializer());
        //}

        public SclContext()
            : base("name=MYSQLConnection")
        {
            Database.SetInitializer(new SclContextInitializer());
        }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Login> Logins { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<City> Cities { get; set; }

        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}