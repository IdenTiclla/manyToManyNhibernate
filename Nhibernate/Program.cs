using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhibernate
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    /*
                    var fordMake = new Make
                    {
                        Name = "fordx4"
                    };
                    var fiestaModel = new Model
                    {
                        Name = "fiestax2",
                        Make = fordMake
                    };

                    var car = new Car
                    {
                        Make = fordMake,
                        Model = fiestaModel,
                        Title = "dans carx2"
                    };

                    session.Save(car);
                    transaction.Commit();
                    Console.WriteLine("create car" + car.Title);
                    */

                    
                    var author = new Author { Name = "Gabriel", LastName = "Marquez" };
                    var book = new Book { Title = "La Odisea", Author = author };


                    session.Save(book);
                    transaction.Commit();
                    Console.WriteLine("create book " + book.Title);
                    
                }
                Console.ReadLine();
            }
        }
    }


    

    



    
    


    

    


}
